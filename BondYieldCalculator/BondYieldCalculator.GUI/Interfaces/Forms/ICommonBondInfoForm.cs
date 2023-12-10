namespace BondYieldCalculator.GUI.Interfaces.Forms
{
    internal interface ICommonBondInfoForm : IForm
    {
        string? NominalPriceText { get; set; }

        string? CurrentPriceText { get; set; }

        string? MaturityText { get; set; }
    }
}
