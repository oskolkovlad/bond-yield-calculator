namespace BondYieldCalculator.GUI.Controllers
{
    using System.Globalization;
    using BondYieldCalculator.Entities.Dto;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal class CommonInfoController : IInfoObserverController
    {
        private readonly ICommonInfoView _commonInfoView;

        public CommonInfoController(ICommonInfoView commonInfoView)
        {
            _commonInfoView = commonInfoView;
        }

        public void ClearInfo()
        {
            _commonInfoView.NameText = null;
            _commonInfoView.NominalPriceText = null;
            _commonInfoView.CurrentPriceText = null;
            _commonInfoView.MaturityText = null;
        }

        public void FillInfo(BondInfo? bondInfo)
        {
            if (bondInfo is null)
            {
                return;
            }

            _commonInfoView.NameText = bondInfo.CommonInfo?.Name;
            _commonInfoView.NominalPriceText = bondInfo.CommonInfo?.NominalPrice.ToString(CultureInfo.InvariantCulture);
            _commonInfoView.CurrentPriceText = bondInfo.CommonInfo?.CurrentPrice.ToString(CultureInfo.InvariantCulture);
            _commonInfoView.MaturityText = bondInfo.CommonInfo?.Maturity.ToString(CultureInfo.InvariantCulture);
        }
    }
}
