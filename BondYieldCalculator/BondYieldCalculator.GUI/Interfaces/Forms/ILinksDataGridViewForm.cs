namespace BondYieldCalculator.GUI.Interfaces.Forms
{
    internal interface ILinksDataGridViewForm : IForm
    {
        bool RemoveButtonEnabled { get; set; }

        DataGridView LinksDataGridView { get; }
    }
}
