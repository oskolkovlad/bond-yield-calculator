namespace BondYieldCalculator.GUI.Interfaces.ViewControls.Views
{
    internal interface ICommonInfoView : IView
    {
        string? NameText { get; set; }

        string? NominalPriceText { get; set; }

        string? CurrentPriceText { get; set; }

        string? MaturityText { get; set; }
    }
}
