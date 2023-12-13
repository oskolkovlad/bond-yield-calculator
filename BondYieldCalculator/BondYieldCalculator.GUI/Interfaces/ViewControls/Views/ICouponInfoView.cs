namespace BondYieldCalculator.GUI.Interfaces.ViewControls.Views
{
    internal interface ICouponInfoView : IView
    {
        string? AccumulatedCouponIncomeText { get; set; }

        string? CouponText { get; set; }

        string? CouponsQuantityText { get; set; }

        string? QuantityOfPaymentsInYearText { get; set; }
    }
}
