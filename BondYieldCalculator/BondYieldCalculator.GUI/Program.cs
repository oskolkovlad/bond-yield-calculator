namespace BondYieldCalculator.GUI
{
    using System;
    using BondYieldCalculator.GUI.Controllers;
    using BondYieldCalculator.Parser;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var mainForm = new Form();
            var bondParser = new BondParserCreator();
            var smartLabBondParser = bondParser.CreateSmartLabBondParser();
            var linkController = new LinkController(mainForm, smartLabBondParser);

            try
            {
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}