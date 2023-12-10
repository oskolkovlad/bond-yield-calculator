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
            var commonInfoController = new CommonBondInfoController(mainForm);
            var couponInfoController = new CouponInfoController(mainForm);
            var yieldInfoController = new YieldInfoController(mainForm);
            var linkController = new LinkController(mainForm, smartLabBondParser);

            linkController.Subcribe(commonInfoController);
            linkController.Subcribe(couponInfoController);
            linkController.Subcribe(yieldInfoController);

            try
            {
                mainForm.LinkText = "https://smart-lab.ru/q/bonds/SU26227RMFS7/"; // For local testing. Delete.
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}