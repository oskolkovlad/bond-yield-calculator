namespace BondYieldCalculator.GUI
{
    using System;
    using BondYieldCalculator.Parser;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var mainForm = new Form();
            var bondParser = new BondParserCreator();
            var smartLabBondParser = bondParser.CreateSmartLabBondParser();

            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}