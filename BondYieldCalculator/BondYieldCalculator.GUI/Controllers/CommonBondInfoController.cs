namespace BondYieldCalculator.GUI.Controllers
{
    using System.Globalization;
    using BondYieldCalculator.Entities;
    using BondYieldCalculator.GUI.Interfaces.Controllers;
    using BondYieldCalculator.GUI.Interfaces.Forms;

    internal class CommonBondInfoController : IInfoObserverController
    {
        private readonly ICommonBondInfoForm _form;

        public CommonBondInfoController(ICommonBondInfoForm form)
        {
            _form = form;
        }

        public void FillInfo(BondInfo bondInfo)
        {
            if (bondInfo is null)
            {
                return;
            }

            _form.NominalPriceText = bondInfo.CommonInfo?.NominalPrice.ToString(CultureInfo.InvariantCulture);
            _form.CurrentPriceText = bondInfo.CommonInfo?.CurrentPrice.ToString(CultureInfo.InvariantCulture);
            _form.MaturityText = bondInfo.CommonInfo?.Maturity.ToString(CultureInfo.InvariantCulture);
        }
    }
}
