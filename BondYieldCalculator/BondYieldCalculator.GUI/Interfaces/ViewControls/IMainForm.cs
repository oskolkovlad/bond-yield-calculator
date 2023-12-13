namespace BondYieldCalculator.GUI.Interfaces.ViewControls
{
    using BondYieldCalculator.GUI.Interfaces.ViewControls.Views;

    internal interface IMainForm
    {
        ILinksTableView LinksTableView { get; }

        ILinksManagementView LinksManagementView { get; }

        ILinksControlsStateManagementView LinksControlsStateManagementView { get; }

        ICommonInfoView CommonInfoView { get; }

        ICommonInfoControlsStateManagementView CommonInfoControlsStateManagementView { get; }

        ICouponInfoView CouponInfoView { get; }

        ICouponInfoControlsStateManagementView CouponInfoControlsStateManagementView { get; }

        IYieldInfoView YieldInfoView { get; }

        IYieldInfoControlsStateManagementView YieldInfoControlsStateManagementView { get; }
    }
}
