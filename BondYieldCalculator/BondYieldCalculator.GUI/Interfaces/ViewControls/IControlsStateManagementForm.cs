using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

namespace BondYieldCalculator.GUI.Interfaces.ViewControls
{
    internal interface IControlsStateManagementForm : IForm
    {
        ILinksControlsStateManagementView LinksControlsStateManagementView { get; }

        ICommonInfoControlsStateManagementView CommonInfoControlsStateManagementView { get; }

        ICouponInfoControlsStateManagementView CouponInfoControlsStateManagementView { get; }

        IYieldInfoControlsStateManagementView YieldInfoControlsStateManagementView { get; }
    }
}
