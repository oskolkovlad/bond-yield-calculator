namespace BondYieldCalculator.GUI.Controllers
{
    using System.Globalization;
    using BondYieldCalculator.Entities.Dto;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal class CouponInfoController : IInfoObserverController
    {
        private readonly ICouponInfoView _couponInfoView;

        public CouponInfoController(ICouponInfoView couponInfoView)
        {
            _couponInfoView = couponInfoView;
        }

        public void ClearInfo()
        {
            _couponInfoView.AccumulatedCouponIncomeText = null;
            _couponInfoView.CouponText = null;
            _couponInfoView.CouponsQuantityText = null;
            _couponInfoView.QuantityOfPaymentsInYearText = null;
        }

        public void FillInfo(BondInfo? bondInfo)
        {
            if (bondInfo is null)
            {
                return;
            }

            _couponInfoView.AccumulatedCouponIncomeText = bondInfo.CouponInfo?.AccumulatedCouponIncome.ToString(CultureInfo.InvariantCulture);
            _couponInfoView.CouponText = bondInfo.CouponInfo?.Coupon.ToString(CultureInfo.InvariantCulture);
            _couponInfoView.CouponsQuantityText = bondInfo.CouponInfo?.CouponsQuantity.ToString();
            _couponInfoView.QuantityOfPaymentsInYearText = bondInfo.CouponInfo?.QuantityOfPaymentsInYear.ToString();
        }
    }
}
