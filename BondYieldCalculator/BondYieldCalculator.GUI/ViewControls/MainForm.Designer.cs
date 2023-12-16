namespace BondYieldCalculator.GUI.ViewControls
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTableLayoutPanel = new TableLayoutPanel();
            linksTableView = new Views.LinksTableView();
            commonInfoView = new Views.CommonInfoView();
            couponInfoView = new Views.CouponInfoView();
            yieldInfoView = new Views.YieldInfoView();
            mainTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(linksTableView, 0, 0);
            mainTableLayoutPanel.Controls.Add(commonInfoView, 0, 2);
            mainTableLayoutPanel.Controls.Add(couponInfoView, 0, 3);
            mainTableLayoutPanel.Controls.Add(yieldInfoView, 0, 4);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 5;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.Size = new Size(584, 811);
            mainTableLayoutPanel.TabIndex = 1;
            // 
            // linksTableView
            // 
            linksTableView.AddLinkButtonEnabled = true;
            linksTableView.AnalyzeButtonEnabled = true;
            linksTableView.Dock = DockStyle.Fill;
            linksTableView.LinkText = "";
            linksTableView.LintTextBoxEnabled = true;
            linksTableView.Location = new Point(3, 3);
            linksTableView.Name = "linksTableView";
            linksTableView.RemoveLinksButtonEnabled = true;
            linksTableView.RestoreLinksButtonEnabled = true;
            linksTableView.SaveLinksButtonEnabled = true;
            linksTableView.Size = new Size(578, 261);
            linksTableView.TabIndex = 0;
            // 
            // commonInfoView
            // 
            commonInfoView.CurrentPriceText = "";
            commonInfoView.Dock = DockStyle.Fill;
            commonInfoView.GroupBoxEnabled = true;
            commonInfoView.Location = new Point(3, 320);
            commonInfoView.MaturityText = "";
            commonInfoView.Name = "commonInfoView";
            commonInfoView.NameText = "";
            commonInfoView.NominalPriceText = "";
            commonInfoView.Size = new Size(578, 149);
            commonInfoView.TabIndex = 1;
            // 
            // couponInfoView
            // 
            couponInfoView.AccumulatedCouponIncomeText = "";
            couponInfoView.CouponsQuantityText = "";
            couponInfoView.CouponText = "";
            couponInfoView.Dock = DockStyle.Fill;
            couponInfoView.GroupBoxEnabled = true;
            couponInfoView.Location = new Point(3, 475);
            couponInfoView.Name = "couponInfoView";
            couponInfoView.QuantityOfPaymentsInYearText = "";
            couponInfoView.Size = new Size(578, 149);
            couponInfoView.TabIndex = 2;
            // 
            // yieldInfoView
            // 
            yieldInfoView.CapitalGainsPercentText = "";
            yieldInfoView.Dock = DockStyle.Fill;
            yieldInfoView.GroupBoxEnabled = true;
            yieldInfoView.Location = new Point(3, 630);
            yieldInfoView.Name = "yieldInfoView";
            yieldInfoView.RealCouponIncomePercentText = "";
            yieldInfoView.RealCouponIncomeText = "";
            yieldInfoView.RealYieldPercentText = "";
            yieldInfoView.Size = new Size(578, 178);
            yieldInfoView.TabIndex = 3;
            yieldInfoView.YieldText = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 811);
            Controls.Add(mainTableLayoutPanel);
            KeyPreview = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bond yield calculator";
            mainTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private Views.LinksTableView linksTableView;
        private Views.CommonInfoView commonInfoView;
        private Views.CouponInfoView couponInfoView;
        private Views.YieldInfoView yieldInfoView;
    }
}