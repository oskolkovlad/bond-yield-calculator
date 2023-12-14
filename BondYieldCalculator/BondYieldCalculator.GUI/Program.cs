namespace BondYieldCalculator.GUI
{
    using System;
    using BondYieldCalculator.GUI.Controllers;
    using BondYieldCalculator.GUI.Services;
    using BondYieldCalculator.GUI.ViewControls;
    using BondYieldCalculator.Parser;

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

            var bondParser = new BondParserCreator();
            var smartLabBondParser = bondParser.CreateSmartLabBondParser();

            var configService = new ConfigService(ConfigPath);
            var yieldCalculatorService = new YieldCalculatorService(configService);
            var linksStorageService = new LinksStorageService();

            var commonInfoController = new CommonInfoController(mainForm.CommonInfoView);
            var couponInfoController = new CouponInfoController(mainForm.CouponInfoView);
            var yieldInfoController = new YieldInfoController(mainForm.YieldInfoView);
            var controlsStateManagementController = new ControlsStateManagementController(
                mainForm.LinksControlsStateManagementView,
                mainForm.CommonInfoControlsStateManagementView,
                mainForm.CouponInfoControlsStateManagementView,
                mainForm.YieldInfoControlsStateManagementView);
            var linksTableController = new LinksTableController(mainForm.LinksTableView, controlsStateManagementController);
            var linksManagementController = new LinksManagementController(
                mainForm.LinksManagementView,
                smartLabBondParser,
                yieldCalculatorService,
                linksStorageService,
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}