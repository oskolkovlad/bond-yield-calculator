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
            var linksStorageService = new LinksStorageService();
            var commonInfoController = new CommonBondInfoController(mainForm);
            var couponInfoController = new CouponInfoController(mainForm);
            var yieldInfoController = new YieldInfoController(mainForm);
            var controlsStateController = new ControlsStateController(mainForm);
            var linksDataGridViewController = new LinksDataGridViewController(mainForm, controlsStateController);
            var linksController = new LinksController(
                mainForm,
                smartLabBondParser,
                yieldCalculatorService,
                linksStorageService,
                linksDataGridViewController,
                linksDataGridViewController,
                controlsStateController);

            linksController.Subcribe(commonInfoController);
            linksController.Subcribe(couponInfoController);
            linksController.Subcribe(yieldInfoController);

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