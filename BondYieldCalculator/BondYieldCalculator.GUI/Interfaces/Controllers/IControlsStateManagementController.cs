﻿namespace BondYieldCalculator.GUI.Interfaces.Controllers
{
    internal interface IControlsStateManagementController : IController
    {
        public bool LintTextBoxEnabled { get; set; }

        public bool AddLinkButtonEnabled { get; set; }

        public bool RemoveLinksButtonEnabled { get; set; }

        public bool AnalyzeButtonEnabled { get; set; }

        public bool RestoreLinksButtonEnabled { get; set; }

        public bool SaveLinksButtonEnabled { get; set; }

        public bool BondInfoEnabled { get; set; }

        void SetAnalyzeProcessingControlsState(bool value);

        void SetRowsCountControlsState(bool value);
    }
}
