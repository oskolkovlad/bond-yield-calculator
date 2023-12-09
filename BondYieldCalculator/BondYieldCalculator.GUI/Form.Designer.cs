namespace BondYieldCalculator.GUI
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            mainTableLayoutPanel = new TableLayoutPanel();
            linkTableLayoutPanel = new TableLayoutPanel();
            linkLabel = new Label();
            linkTextBox = new TextBox();
            bondTableLayoutPanel = new TableLayoutPanel();
            yieldInfoGroupBox = new GroupBox();
            yieldInfoTableLayoutPanel = new TableLayoutPanel();
            yieldTextBox = new TextBox();
            capitalGainsPercentTextBox = new TextBox();
            realYieldPercentTextBox = new TextBox();
            yieldLabel = new Label();
            capitalGainsPercentLabel = new Label();
            realYieldPercentLabel = new Label();
            commonInfoGroupBox = new GroupBox();
            commonInfoTableLayoutPanel = new TableLayoutPanel();
            nominalPriceLabel = new Label();
            maturityTextBox = new TextBox();
            nominalPriceTextBox = new TextBox();
            currentPriceTextBox = new TextBox();
            currentPriceLabel = new Label();
            maturityLabel = new Label();
            couponInfoGroupBox = new GroupBox();
            couponInfoTableLayoutPanel = new TableLayoutPanel();
            accumulatedCouponIncomeLabel = new Label();
            accumulatedCouponIncomeTextBox = new TextBox();
            couponTextBox = new TextBox();
            couponsQuantityTextBox = new TextBox();
            quantityOfPaymentsTextBox = new TextBox();
            realCouponIncomeTextBox = new TextBox();
            realCouponIncomePercentTextBox = new TextBox();
            couponLabel = new Label();
            couponsQuantityLabel = new Label();
            quantityOfPaymentsLabel = new Label();
            realCouponIncomeLabel = new Label();
            realCouponIncomePercentLabel = new Label();
            mainTableLayoutPanel.SuspendLayout();
            linkTableLayoutPanel.SuspendLayout();
            bondTableLayoutPanel.SuspendLayout();
            yieldInfoGroupBox.SuspendLayout();
            yieldInfoTableLayoutPanel.SuspendLayout();
            commonInfoGroupBox.SuspendLayout();
            commonInfoTableLayoutPanel.SuspendLayout();
            couponInfoGroupBox.SuspendLayout();
            couponInfoTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            resources.ApplyResources(mainTableLayoutPanel, "mainTableLayoutPanel");
            mainTableLayoutPanel.Controls.Add(linkTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Controls.Add(bondTableLayoutPanel, 0, 2);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            // 
            // linkTableLayoutPanel
            // 
            resources.ApplyResources(linkTableLayoutPanel, "linkTableLayoutPanel");
            linkTableLayoutPanel.Controls.Add(linkLabel, 0, 0);
            linkTableLayoutPanel.Controls.Add(linkTextBox, 1, 0);
            linkTableLayoutPanel.Name = "linkTableLayoutPanel";
            // 
            // linkLabel
            // 
            resources.ApplyResources(linkLabel, "linkLabel");
            linkLabel.Name = "linkLabel";
            // 
            // linkTextBox
            // 
            resources.ApplyResources(linkTextBox, "linkTextBox");
            linkTextBox.Name = "linkTextBox";
            // 
            // bondTableLayoutPanel
            // 
            resources.ApplyResources(bondTableLayoutPanel, "bondTableLayoutPanel");
            bondTableLayoutPanel.Controls.Add(yieldInfoGroupBox, 0, 2);
            bondTableLayoutPanel.Controls.Add(commonInfoGroupBox, 0, 0);
            bondTableLayoutPanel.Controls.Add(couponInfoGroupBox, 0, 1);
            bondTableLayoutPanel.Name = "bondTableLayoutPanel";
            // 
            // yieldInfoGroupBox
            // 
            resources.ApplyResources(yieldInfoGroupBox, "yieldInfoGroupBox");
            yieldInfoGroupBox.Controls.Add(yieldInfoTableLayoutPanel);
            yieldInfoGroupBox.Name = "yieldInfoGroupBox";
            yieldInfoGroupBox.TabStop = false;
            // 
            // yieldInfoTableLayoutPanel
            // 
            resources.ApplyResources(yieldInfoTableLayoutPanel, "yieldInfoTableLayoutPanel");
            yieldInfoTableLayoutPanel.Controls.Add(yieldTextBox, 1, 0);
            yieldInfoTableLayoutPanel.Controls.Add(capitalGainsPercentTextBox, 1, 1);
            yieldInfoTableLayoutPanel.Controls.Add(realYieldPercentTextBox, 1, 2);
            yieldInfoTableLayoutPanel.Controls.Add(yieldLabel, 0, 0);
            yieldInfoTableLayoutPanel.Controls.Add(capitalGainsPercentLabel, 0, 1);
            yieldInfoTableLayoutPanel.Controls.Add(realYieldPercentLabel, 0, 2);
            yieldInfoTableLayoutPanel.Name = "yieldInfoTableLayoutPanel";
            // 
            // yieldTextBox
            // 
            resources.ApplyResources(yieldTextBox, "yieldTextBox");
            yieldTextBox.Name = "yieldTextBox";
            yieldTextBox.ReadOnly = true;
            // 
            // capitalGainsPercentTextBox
            // 
            resources.ApplyResources(capitalGainsPercentTextBox, "capitalGainsPercentTextBox");
            capitalGainsPercentTextBox.Name = "capitalGainsPercentTextBox";
            capitalGainsPercentTextBox.ReadOnly = true;
            // 
            // realYieldPercentTextBox
            // 
            resources.ApplyResources(realYieldPercentTextBox, "realYieldPercentTextBox");
            realYieldPercentTextBox.Name = "realYieldPercentTextBox";
            realYieldPercentTextBox.ReadOnly = true;
            // 
            // yieldLabel
            // 
            resources.ApplyResources(yieldLabel, "yieldLabel");
            yieldLabel.Name = "yieldLabel";
            // 
            // capitalGainsPercentLabel
            // 
            resources.ApplyResources(capitalGainsPercentLabel, "capitalGainsPercentLabel");
            capitalGainsPercentLabel.Name = "capitalGainsPercentLabel";
            // 
            // realYieldPercentLabel
            // 
            resources.ApplyResources(realYieldPercentLabel, "realYieldPercentLabel");
            realYieldPercentLabel.Name = "realYieldPercentLabel";
            // 
            // commonInfoGroupBox
            // 
            resources.ApplyResources(commonInfoGroupBox, "commonInfoGroupBox");
            commonInfoGroupBox.Controls.Add(commonInfoTableLayoutPanel);
            commonInfoGroupBox.Name = "commonInfoGroupBox";
            commonInfoGroupBox.TabStop = false;
            // 
            // commonInfoTableLayoutPanel
            // 
            resources.ApplyResources(commonInfoTableLayoutPanel, "commonInfoTableLayoutPanel");
            commonInfoTableLayoutPanel.Controls.Add(nominalPriceLabel, 0, 0);
            commonInfoTableLayoutPanel.Controls.Add(maturityTextBox, 1, 2);
            commonInfoTableLayoutPanel.Controls.Add(nominalPriceTextBox, 1, 0);
            commonInfoTableLayoutPanel.Controls.Add(currentPriceTextBox, 1, 1);
            commonInfoTableLayoutPanel.Controls.Add(currentPriceLabel, 0, 1);
            commonInfoTableLayoutPanel.Controls.Add(maturityLabel, 0, 2);
            commonInfoTableLayoutPanel.Name = "commonInfoTableLayoutPanel";
            // 
            // nominalPriceLabel
            // 
            resources.ApplyResources(nominalPriceLabel, "nominalPriceLabel");
            nominalPriceLabel.Name = "nominalPriceLabel";
            // 
            // maturityTextBox
            // 
            resources.ApplyResources(maturityTextBox, "maturityTextBox");
            maturityTextBox.Name = "maturityTextBox";
            maturityTextBox.ReadOnly = true;
            // 
            // nominalPriceTextBox
            // 
            resources.ApplyResources(nominalPriceTextBox, "nominalPriceTextBox");
            nominalPriceTextBox.Name = "nominalPriceTextBox";
            nominalPriceTextBox.ReadOnly = true;
            // 
            // currentPriceTextBox
            // 
            resources.ApplyResources(currentPriceTextBox, "currentPriceTextBox");
            currentPriceTextBox.Name = "currentPriceTextBox";
            currentPriceTextBox.ReadOnly = true;
            // 
            // currentPriceLabel
            // 
            resources.ApplyResources(currentPriceLabel, "currentPriceLabel");
            currentPriceLabel.Name = "currentPriceLabel";
            // 
            // maturityLabel
            // 
            resources.ApplyResources(maturityLabel, "maturityLabel");
            maturityLabel.Name = "maturityLabel";
            // 
            // couponInfoGroupBox
            // 
            resources.ApplyResources(couponInfoGroupBox, "couponInfoGroupBox");
            couponInfoGroupBox.Controls.Add(couponInfoTableLayoutPanel);
            couponInfoGroupBox.Name = "couponInfoGroupBox";
            couponInfoGroupBox.TabStop = false;
            // 
            // couponInfoTableLayoutPanel
            // 
            resources.ApplyResources(couponInfoTableLayoutPanel, "couponInfoTableLayoutPanel");
            couponInfoTableLayoutPanel.Controls.Add(accumulatedCouponIncomeLabel, 0, 0);
            couponInfoTableLayoutPanel.Controls.Add(accumulatedCouponIncomeTextBox, 1, 0);
            couponInfoTableLayoutPanel.Controls.Add(couponTextBox, 1, 1);
            couponInfoTableLayoutPanel.Controls.Add(couponsQuantityTextBox, 1, 2);
            couponInfoTableLayoutPanel.Controls.Add(quantityOfPaymentsTextBox, 1, 3);
            couponInfoTableLayoutPanel.Controls.Add(realCouponIncomeTextBox, 1, 4);
            couponInfoTableLayoutPanel.Controls.Add(realCouponIncomePercentTextBox, 1, 5);
            couponInfoTableLayoutPanel.Controls.Add(couponLabel, 0, 1);
            couponInfoTableLayoutPanel.Controls.Add(couponsQuantityLabel, 0, 2);
            couponInfoTableLayoutPanel.Controls.Add(quantityOfPaymentsLabel, 0, 3);
            couponInfoTableLayoutPanel.Controls.Add(realCouponIncomeLabel, 0, 4);
            couponInfoTableLayoutPanel.Controls.Add(realCouponIncomePercentLabel, 0, 5);
            couponInfoTableLayoutPanel.Name = "couponInfoTableLayoutPanel";
            // 
            // accumulatedCouponIncomeLabel
            // 
            resources.ApplyResources(accumulatedCouponIncomeLabel, "accumulatedCouponIncomeLabel");
            accumulatedCouponIncomeLabel.Name = "accumulatedCouponIncomeLabel";
            // 
            // accumulatedCouponIncomeTextBox
            // 
            resources.ApplyResources(accumulatedCouponIncomeTextBox, "accumulatedCouponIncomeTextBox");
            accumulatedCouponIncomeTextBox.Name = "accumulatedCouponIncomeTextBox";
            accumulatedCouponIncomeTextBox.ReadOnly = true;
            // 
            // couponTextBox
            // 
            resources.ApplyResources(couponTextBox, "couponTextBox");
            couponTextBox.Name = "couponTextBox";
            couponTextBox.ReadOnly = true;
            // 
            // couponsQuantityTextBox
            // 
            resources.ApplyResources(couponsQuantityTextBox, "couponsQuantityTextBox");
            couponsQuantityTextBox.Name = "couponsQuantityTextBox";
            couponsQuantityTextBox.ReadOnly = true;
            // 
            // quantityOfPaymentsTextBox
            // 
            resources.ApplyResources(quantityOfPaymentsTextBox, "quantityOfPaymentsTextBox");
            quantityOfPaymentsTextBox.Name = "quantityOfPaymentsTextBox";
            quantityOfPaymentsTextBox.ReadOnly = true;
            // 
            // realCouponIncomeTextBox
            // 
            resources.ApplyResources(realCouponIncomeTextBox, "realCouponIncomeTextBox");
            realCouponIncomeTextBox.Name = "realCouponIncomeTextBox";
            realCouponIncomeTextBox.ReadOnly = true;
            // 
            // realCouponIncomePercentTextBox
            // 
            resources.ApplyResources(realCouponIncomePercentTextBox, "realCouponIncomePercentTextBox");
            realCouponIncomePercentTextBox.Name = "realCouponIncomePercentTextBox";
            realCouponIncomePercentTextBox.ReadOnly = true;
            // 
            // couponLabel
            // 
            resources.ApplyResources(couponLabel, "couponLabel");
            couponLabel.Name = "couponLabel";
            // 
            // couponsQuantityLabel
            // 
            resources.ApplyResources(couponsQuantityLabel, "couponsQuantityLabel");
            couponsQuantityLabel.Name = "couponsQuantityLabel";
            // 
            // quantityOfPaymentsLabel
            // 
            resources.ApplyResources(quantityOfPaymentsLabel, "quantityOfPaymentsLabel");
            quantityOfPaymentsLabel.Name = "quantityOfPaymentsLabel";
            // 
            // realCouponIncomeLabel
            // 
            resources.ApplyResources(realCouponIncomeLabel, "realCouponIncomeLabel");
            realCouponIncomeLabel.Name = "realCouponIncomeLabel";
            // 
            // realCouponIncomePercentLabel
            // 
            resources.ApplyResources(realCouponIncomePercentLabel, "realCouponIncomePercentLabel");
            realCouponIncomePercentLabel.Name = "realCouponIncomePercentLabel";
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainTableLayoutPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form";
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            linkTableLayoutPanel.ResumeLayout(false);
            linkTableLayoutPanel.PerformLayout();
            bondTableLayoutPanel.ResumeLayout(false);
            bondTableLayoutPanel.PerformLayout();
            yieldInfoGroupBox.ResumeLayout(false);
            yieldInfoGroupBox.PerformLayout();
            yieldInfoTableLayoutPanel.ResumeLayout(false);
            yieldInfoTableLayoutPanel.PerformLayout();
            commonInfoGroupBox.ResumeLayout(false);
            commonInfoGroupBox.PerformLayout();
            commonInfoTableLayoutPanel.ResumeLayout(false);
            commonInfoTableLayoutPanel.PerformLayout();
            couponInfoGroupBox.ResumeLayout(false);
            couponInfoGroupBox.PerformLayout();
            couponInfoTableLayoutPanel.ResumeLayout(false);
            couponInfoTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel linkTableLayoutPanel;
        private Label linkLabel;
        private TextBox linkTextBox;
        private GroupBox commonInfoGroupBox;
        private GroupBox couponInfoGroupBox;
        private GroupBox yieldInfoGroupBox;
        private TableLayoutPanel bondTableLayoutPanel;
        private TableLayoutPanel yieldInfoTableLayoutPanel;
        private TableLayoutPanel commonInfoTableLayoutPanel;
        private Label nominalPriceLabel;
        private TextBox nominalPriceTextBox;
        private TableLayoutPanel couponInfoTableLayoutPanel;
        private TextBox currentPriceTextBox;
        private Label currentPriceLabel;
        private TextBox maturityTextBox;
        private Label maturityLabel;
        private Label accumulatedCouponIncomeLabel;
        private TextBox accumulatedCouponIncomeTextBox;
        private TextBox yieldTextBox;
        private TextBox capitalGainsPercentTextBox;
        private TextBox realYieldPercentTextBox;
        private Label yieldLabel;
        private Label capitalGainsPercentLabel;
        private Label realYieldPercentLabel;
        private TextBox couponTextBox;
        private TextBox couponsQuantityTextBox;
        private TextBox quantityOfPaymentsTextBox;
        private TextBox realCouponIncomeTextBox;
        private TextBox realCouponIncomePercentTextBox;
        private Label couponLabel;
        private Label couponsQuantityLabel;
        private Label quantityOfPaymentsLabel;
        private Label realCouponIncomeLabel;
        private Label realCouponIncomePercentLabel;
    }
}