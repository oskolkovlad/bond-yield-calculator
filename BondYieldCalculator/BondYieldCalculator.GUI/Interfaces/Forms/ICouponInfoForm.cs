namespace BondYieldCalculator.GUI.Interfaces.Forms
{
    internal interface ICouponInfoForm : IForm
    {
        string? AccumulatedCouponIncomeText { get; set; }

        string? CouponText { get; set; }

        string? CouponsQuantityText { get; set; }

        string? QuantityOfPaymentsInYearText { get; set; }
    }
}
