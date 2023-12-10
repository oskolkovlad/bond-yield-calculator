namespace BondYieldCalculator.GUI.Interfaces.Forms
{
    internal interface IYieldInfoForm : IForm
    {
        string? YieldText { get; set; }

        string? CapitalGainsPercentText { get; set; }

        string? RealCouponIncomeText { get; set; }

        string? RealCouponIncomePercentText { get; set; }

        string? RealYieldPercentText { get; set; }
    }
}
