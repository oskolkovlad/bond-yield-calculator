namespace BondYieldCalculator.GUI.Controllers
{
    using System.Globalization;
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;

    internal class CouponInfoController : IInfoObserverController
    {
        private readonly ICouponInfoForm _form;

        public CouponInfoController(ICouponInfoForm form)
        {
            _form = form;
        }

        public void FillInfo(BondInfo bondInfo)
        {
            if (bondInfo is null)
            {
                return;
            }

            _form.AccumulatedCouponIncomeText = bondInfo.CouponInfo?.AccumulatedCouponIncome.ToString(CultureInfo.InvariantCulture);
            _form.CouponText = bondInfo.CouponInfo?.Coupon.ToString(CultureInfo.InvariantCulture);
            _form.CouponsQuantityText = bondInfo.CouponInfo?.CouponsQuantity.ToString();
            _form.QuantityOfPaymentsInYearText = bondInfo.CouponInfo?.QuantityOfPaymentsInYear.ToString();
        }
    }
}
