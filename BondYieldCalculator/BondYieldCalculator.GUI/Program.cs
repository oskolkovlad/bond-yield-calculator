namespace BondYieldCalculator.GUI
{
    using System;
    using BondYieldCalculator.GUI.Controllers;
    using BondYieldCalculator.GUI.Services;
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
            var yieldCalculatorService = new YieldCalculatorService();
            var commonInfoController = new CommonBondInfoController(mainForm);
            var couponInfoController = new CouponInfoController(mainForm);
            var yieldInfoController = new YieldInfoController(mainForm);
            var linksDataGridViewController = new LinksDataGridViewController(mainForm);
            var linkController = new LinkController(mainForm, smartLabBondParser, yieldCalculatorService, linksDataGridViewController, linksDataGridViewController);

            linkController.Subcribe(commonInfoController);
            linkController.Subcribe(couponInfoController);
            linkController.Subcribe(yieldInfoController);

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