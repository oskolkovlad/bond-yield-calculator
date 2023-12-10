﻿namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;
    using BondYieldCalculator.GUI.Interfaces.Services;
    using BondYieldCalculator.Parser;

    internal class LinkController : IObservableController
    {
        private readonly ILinkForm _form;
        private readonly IBondParser _bondParser;
        private readonly IYieldCalculatorService _yieldCalculatorService;
        private readonly ILinksStorageService _linksStorageService;
        private readonly ILinksDataGridViewController _linksDataGridViewController;
        private readonly IBondLinkRowSelectionController _bondLinkRowSelectionController;
        private readonly IList<IInfoObserverController> _subscribers;

        private List<BondInfo?> _bondInfoItems;

        public LinkController(
            ILinkForm form,
            IBondParser bondParser,
            IYieldCalculatorService yieldCalculatorService,
            ILinksStorageService linksStorageService,
            ILinksDataGridViewController linksDataGridViewController,
            IBondLinkRowSelectionController bondLinkRowSelectionController)
        {
            _form = form;
            _bondParser = bondParser;
            _yieldCalculatorService = yieldCalculatorService;
            _linksStorageService = linksStorageService;
            _linksDataGridViewController = linksDataGridViewController;
            _bondLinkRowSelectionController = bondLinkRowSelectionController;
            _subscribers = new List<IInfoObserverController>();
            _bondInfoItems = new List<BondInfo?>();

            _form.LinkAdding += (sender, args) => HandleLinkAdding();
            _form.LinksRemoving += (sender, args) => HandleLinksRemoving();
            _form.LinksAnalyzing += (sender, args) => HandleLinksAnalyzing();
            _form.LinksOpening += (sender, args) => HandleLinksOpening();
            _form.LinksSaving += (sender, args) => HandleLinksSaving();

            _bondLinkRowSelectionController.SelectionChanged += HandleSelectionChanged;
        }

        #region IObservableController Members

        public void Subcribe(IInfoObserverController subscriber) => _subscribers.Add(subscriber);

        public void Unsubscribe(IInfoObserverController subscriber) => _subscribers.Remove(subscriber);

        #endregion IObservableController Members

        #region Private Members

        private void UpdateBondInfo()
        {
            var linkRowItem = _bondLinkRowSelectionController.GetSelectedBondLinkRowItem();
            if (linkRowItem is null)
            {
                return;
            }

            var bondInfo = _bondInfoItems?.FirstOrDefault(item => item!.Link == linkRowItem.Link);
            if (bondInfo is null)
            {
                return;
            }

            _subscribers.AsParallel().ForAll(subscriber => subscriber.FillInfo(bondInfo));
        }

        private void HandleLinkAdding() => _linksDataGridViewController.AddLinkRow(_form.LinkText);

        private void HandleLinksRemoving() => _linksDataGridViewController.RemoveSelectedLinkRows();

        private void HandleLinksAnalyzing()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.ClearInfo();
            }

            _form.BondPanelEnabled = false;

            var links = _linksDataGridViewController.GetLinks();
            _bondInfoItems = links
                .AsParallel()
                .Select(link => _bondParser.GetBondInfoAsync(link).Result)
                .Where(bondInfo => bondInfo is not null)
                .ToList();

            if (_bondInfoItems is null)
            {
                _bondInfoItems = new List<BondInfo?>();
                return;
            }

            _bondLinkRowSelectionController.SelectionChanged -= HandleSelectionChanged;

            foreach (var bondInfo in _bondInfoItems)
            {
                _yieldCalculatorService.UpdateYieldInfo(bondInfo);
                _linksDataGridViewController.UpdateLinkRowItem(bondInfo);
            }

            UpdateBondInfo();
            _form.BondPanelEnabled = true;

            _bondLinkRowSelectionController.SelectionChanged += HandleSelectionChanged;
        }

        private void HandleLinksOpening()
        {
            var links = _linksStorageService.GetLinks()?.ToList();
            if (links is null)
            {
                return;
            }

            foreach (var link in links)
            {
                _linksDataGridViewController.AddLinkRow(link);
            }
        }

        private void HandleLinksSaving()
        {
            _linksStorageService.Save(_linksDataGridViewController.GetLinks());
            MessageBox.Show("Ссылки успешно сохранены.", "Сохранение ссылок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HandleSelectionChanged(object? sender, EventArgs args)
        {
            _form.BondPanelEnabled = false;
            UpdateBondInfo();
            _form.BondPanelEnabled = true;
        }

        #endregion Private Members
    }
}
