namespace BondYieldCalculator.GUI.Interfaces.ViewControls.Views
{
    internal interface IYieldInfoView : IView
    {
        string? YieldText { get; set; }

        string? CapitalGainsPercentText { get; set; }

        string? RealCouponIncomeText { get; set; }

        string? RealCouponIncomePercentText { get; set; }

        string? RealYieldPercentText { get; set; }
    }
}
