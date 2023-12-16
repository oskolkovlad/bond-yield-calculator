namespace BondYieldCalculator.GUI.Controllers
{
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.Entities.CustomEventArgs;
    using BondYieldCalculator.Entities.Dto;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;
    using BondYieldCalculator.Parser;
    using BondYieldCalculator.Services;

    internal class LinksManagementController : IObservableController
    {
        private readonly ILinksManagementView _linksManagementView;
        private readonly IBondParser _bondParser;
        private readonly ILogService _logService;
        private readonly IYieldCalculatorService _yieldCalculatorService;
        private readonly ILinksStorageService _linksStorageService;
        private readonly ILinksTableController _linksTableController;
        private readonly ILinksSelectionController _linksSelectionController;
        private readonly IControlsStateManagementController _controlsStateManagementController;
        private readonly IList<IInfoObserverController> _subscribers;

        private List<BondInfo?> _bondInfoItems;

        public LinksManagementController(
            ILinksManagementView linksManagementView,
            IBondParser bondParser,
            ILogService logService,
            IYieldCalculatorService yieldCalculatorService,
            ILinksStorageService linksStorageService,
            IShortcutsController shortcutsController,
            ILinksTableController linksTableController,
            ILinksSelectionController linksSelectionController,
            IControlsStateManagementController controlsStateManagementController)
        {
            _linksManagementView = linksManagementView;
            _bondParser = bondParser;
            _logService = logService;
            _yieldCalculatorService = yieldCalculatorService;
            _linksStorageService = linksStorageService;
            _linksTableController = linksTableController;
            _linksSelectionController = linksSelectionController;
            _controlsStateManagementController = controlsStateManagementController;
            _subscribers = new List<IInfoObserverController>();
            _bondInfoItems = new List<BondInfo?>();

            _linksManagementView.LinkAdding += (sender, args) => HandleLinkAdding();
            _linksManagementView.LinksRemoving += (sender, args) => HandleLinksRemoving();
            _linksManagementView.LinksAnalyzing += (sender, args) => HandleLinksAnalyzing();
            _linksManagementView.LinksRestoring += (sender, args) => HandleLinksRestoring();
            _linksManagementView.LinksSaving += (sender, args) => HandleLinksSaving();

            shortcutsController.LinkAdding += (sender, args) => HandleLinkAdding();
            shortcutsController.LinksRemoving += (sender, args) => HandleLinksRemoving();
            shortcutsController.LinksAnalyzing += (sender, args) => HandleLinksAnalyzing();
            shortcutsController.LinksRestoring += (sender, args) => HandleLinksRestoring();
            shortcutsController.LinksSaving += (sender, args) => HandleLinksSaving();

            _linksSelectionController.SelectionChanged += HandleSelectionChanged;
        }

        #region IObservableController Members

        public void Subcribe(IInfoObserverController controller) => _subscribers.Add(controller);

        public void Unsubscribe(IInfoObserverController controller) => _subscribers.Remove(controller);

        #endregion IObservableController Members

        #region Private Members

        private void ClearBondInfo()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.ClearInfo();
            }
        }

        private void UpdateBondInfo(BondLinkRowItem? linkRowItem)
        {
            if (linkRowItem is null)
            {
                return;
            }

            ClearBondInfo();

            var bondInfo = _bondInfoItems?.FirstOrDefault(item => item!.Link == linkRowItem.Link);
            if (bondInfo is null)
            {
                return;
            }

            _subscribers.AsParallel().ForAll(subscriber => subscriber.FillInfo(bondInfo));
        }

        private void HandleLinkAdding()
        {
            if (!_controlsStateManagementController.AddLinkButtonEnabled)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(_linksManagementView.LinkText))
            {
                _logService.LogWarn("'Добавление ссылки': невозможно добавить пустую строку. Введите ссылку на облигацию.");
                MessageBox.Show("Невозможно добавить пустую строку. Введите ссылку на облигацию.", "Анализ информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            _linksTableController.AddLinkRow(_linksManagementView.LinkText, true);
            _linksManagementView.LinkText = null;
        }

        private void HandleLinksRemoving()
        {
            if (!_controlsStateManagementController.RemoveLinksButtonEnabled)
            {
                return;
            }

            foreach (var link in _linksTableController.RemoveSelectedLinkRows())
            {
                if (string.IsNullOrWhiteSpace(link))
                {
                    continue;
                }

                var bondInfo = _bondInfoItems?.FirstOrDefault(item => item!.Link == link);
                if (bondInfo is not null)
                {
                    _bondInfoItems?.Remove(bondInfo);
                }
            }

            if (_linksTableController.LinksCount == 0)
            {
                ClearBondInfo();
            }
        }

        private void HandleLinksAnalyzing()
        {
            if (!_controlsStateManagementController.AnalyzeButtonEnabled)
            {
                return;
            }

            ClearBondInfo();

            _controlsStateManagementController.SetAnalyzeProcessingControlsState(false);

            var links = _linksTableController.GetLinks();
            if (links is null)
            {
                _logService.LogWarn("'Анализ информации': oтсутствуют ссылки на облигации.");
                MessageBox.Show("Отсутствуют ссылки на облигации.", "Анализ информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _bondInfoItems = new List<BondInfo?>();
                _controlsStateManagementController.SetAnalyzeProcessingControlsState(true);

                return;
            }

            _bondInfoItems = links
                .AsParallel()
                .Where(link => !string.IsNullOrWhiteSpace(link))
                .Select(link => _bondParser.GetBondInfoAsync(link).Result)
                .Where(bondInfo => bondInfo is not null)
                .ToList() ?? new List<BondInfo?>();
            if (_bondInfoItems.Count == 0)
            {
                _logService.LogWarn("'Анализ информации': информация по добавленным ссылкам не найдена.");
                MessageBox.Show("Информация по добавленным ссылкам не найдена.", "Анализ информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _controlsStateManagementController.SetAnalyzeProcessingControlsState(true);

                return;
            }

            _linksSelectionController.SelectionChanged -= HandleSelectionChanged;

            foreach (var bondInfo in _bondInfoItems)
            {
                _yieldCalculatorService.UpdateYieldInfo(bondInfo);
                _linksTableController.UpdateLinkRowItem(bondInfo);
            }

            UpdateBondInfo(_linksSelectionController.GetSelectedBondLinkRowItem());

            _controlsStateManagementController.SetAnalyzeProcessingControlsState(true);
            _linksSelectionController.SelectionChanged += HandleSelectionChanged;
        }

        private void HandleLinksRestoring()
        {
            if (!_controlsStateManagementController.RestoreLinksButtonEnabled)
            {
                return;
            }

            if (!_linksStorageService.IsExists)
            {
                _logService.LogWarn("'Восстановление ссылок': хранилище не найдено.");
                MessageBox.Show("Хранилище не найдено.", "Восстановление ссылок", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            var links = _linksStorageService.GetLinks()?.ToList();
            if (links is null)
            {
                _logService.LogWarn("'Восстановление ссылок': в хранилище отсутствуют ссылки на облигации.");
                MessageBox.Show("В хранилище отсутствуют ссылки на облигации.", "Восстановление ссылок", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            ClearBondInfo();
            _bondInfoItems.Clear();
            _linksTableController.ClearTable();

            foreach (var link in links)
            {
                _linksTableController.AddLinkRow(link);
            }
        }

        private void HandleLinksSaving()
        {
            if (!_controlsStateManagementController.SaveLinksButtonEnabled)
            {
                return;
            }

            var links = _linksTableController
                .GetLinks()?
                .Where(link => !string.IsNullOrWhiteSpace(link))
                .ToList();
            if (links is null || links.Count == 0)
            {
                _logService.LogWarn("'Сохранение ссылок': отсутствуют ссылки на облигации.");
                MessageBox.Show("Отсутствуют ссылки на облигации.", "Сохранение ссылок", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            _linksStorageService.Save(links);

            _logService.LogInfo("'Сохранение ссылок': ссылки успешно сохранены");
            MessageBox.Show("Ссылки успешно сохранены.", "Сохранение ссылок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HandleSelectionChanged(object? sender, SelectionChangedEventArgs args)
        {
            _controlsStateManagementController.BondInfoEnabled = false;
            UpdateBondInfo(args?.Item);
            _controlsStateManagementController.BondInfoEnabled = true;
        }

        #endregion Private Members
    }
}
