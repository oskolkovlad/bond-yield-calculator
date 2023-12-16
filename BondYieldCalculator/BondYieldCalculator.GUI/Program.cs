namespace BondYieldCalculator.GUI
{
    using System;
    using BondYieldCalculator.GUI.Controllers;
    using BondYieldCalculator.GUI.ViewControls;
    using BondYieldCalculator.Parser;
    using BondYieldCalculator.Services;

    internal static class Program
    {
        private const string ConfigPath = "appsettings.json";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var mainForm = new MainForm();

            var servicesCreator = new ServicesCreator();
            var yieldCalculatorService = servicesCreator.CreateYieldCalculatorService(ConfigPath);
            var linksStorageService = servicesCreator.CreateLinksStorageService();
            var logService = servicesCreator.CreateLogService();

            var bondParserCreator = new BondParserCreator();
            var smartLabBondParser = bondParserCreator.CreateSmartLabBondParser(logService);

            var commonInfoController = new CommonInfoController(mainForm.CommonInfoView);
            var couponInfoController = new CouponInfoController(mainForm.CouponInfoView);
            var yieldInfoController = new YieldInfoController(mainForm.YieldInfoView);
            var shortcutsController = new ShortcutsController(mainForm);
            var controlsStateManagementController = new ControlsStateManagementController(mainForm);
            var linksTableController = new LinksTableController(mainForm.LinksTableView, logService, controlsStateManagementController);
            var linksManagementController = new LinksManagementController(
                mainForm.LinksManagementView,
                smartLabBondParser,
                logService,
                yieldCalculatorService,
                linksStorageService,
                shortcutsController,
                linksTableController,
                linksTableController,
                controlsStateManagementController);

            linksManagementController.Subcribe(commonInfoController);
            linksManagementController.Subcribe(couponInfoController);
            linksManagementController.Subcribe(yieldInfoController);

            try
            {
                Application.Run(mainForm);
            }
            catch (Exception exception)
            {
                logService.LogFatal(exception.Message, exception);
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}