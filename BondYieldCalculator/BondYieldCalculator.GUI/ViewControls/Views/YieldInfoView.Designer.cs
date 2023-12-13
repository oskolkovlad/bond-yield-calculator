namespace BondYieldCalculator.GUI.ViewControls.Views
{
    partial class YieldInfoView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            yieldInfoGroupBox = new GroupBox();
            yieldInfoTableLayoutPanel = new TableLayoutPanel();
            yieldLabel = new Label();
            yieldTextBox = new TextBox();
            capitalGainsPercentLabel = new Label();
            capitalGainsPercentTextBox = new TextBox();
            realCouponIncomeLabel = new Label();
            realCouponIncomeTextBox = new TextBox();
            realCouponIncomePercentLabel = new Label();
            realCouponIncomePercentTextBox = new TextBox();
            realYieldPercentLabel = new Label();
            realYieldPercentTextBox = new TextBox();
            yieldInfoGroupBox.SuspendLayout();
            yieldInfoTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // yieldInfoGroupBox
            // 
            yieldInfoGroupBox.Controls.Add(yieldInfoTableLayoutPanel);
            yieldInfoGroupBox.Dock = DockStyle.Top;
            yieldInfoGroupBox.Location = new Point(0, 0);
            yieldInfoGroupBox.Name = "yieldInfoGroupBox";
            yieldInfoGroupBox.Padding = new Padding(8);
            yieldInfoGroupBox.Size = new Size(300, 179);
            yieldInfoGroupBox.TabIndex = 0;
            yieldInfoGroupBox.TabStop = false;
            yieldInfoGroupBox.Text = "Доходность";
            // 
            // yieldInfoTableLayoutPanel
            // 
            yieldInfoTableLayoutPanel.ColumnCount = 2;
            yieldInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231F));
            yieldInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            yieldInfoTableLayoutPanel.Controls.Add(yieldLabel, 0, 0);
            yieldInfoTableLayoutPanel.Controls.Add(yieldTextBox, 1, 0);
            yieldInfoTableLayoutPanel.Controls.Add(capitalGainsPercentLabel, 0, 1);
            yieldInfoTableLayoutPanel.Controls.Add(capitalGainsPercentTextBox, 1, 1);
            yieldInfoTableLayoutPanel.Controls.Add(realCouponIncomeLabel, 0, 2);
            yieldInfoTableLayoutPanel.Controls.Add(realCouponIncomeTextBox, 1, 2);
            yieldInfoTableLayoutPanel.Controls.Add(realCouponIncomePercentLabel, 0, 3);
            yieldInfoTableLayoutPanel.Controls.Add(realCouponIncomePercentTextBox, 1, 3);
            yieldInfoTableLayoutPanel.Controls.Add(realYieldPercentLabel, 0, 4);
            yieldInfoTableLayoutPanel.Controls.Add(realYieldPercentTextBox, 1, 4);
            yieldInfoTableLayoutPanel.Dock = DockStyle.Top;
            yieldInfoTableLayoutPanel.Location = new Point(8, 24);
            yieldInfoTableLayoutPanel.Name = "yieldInfoTableLayoutPanel";
            yieldInfoTableLayoutPanel.RowCount = 5;
            yieldInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            yieldInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            yieldInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            yieldInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            yieldInfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            yieldInfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            yieldInfoTableLayoutPanel.Size = new Size(284, 146);
            yieldInfoTableLayoutPanel.TabIndex = 0;
            // 
            // yieldLabel
            // 
            yieldLabel.AutoSize = true;
            yieldLabel.ImeMode = ImeMode.NoControl;
            yieldLabel.Location = new Point(3, 3);
            yieldLabel.Margin = new Padding(3);
            yieldLabel.Name = "yieldLabel";
            yieldLabel.Size = new Size(91, 15);
            yieldLabel.TabIndex = 0;
            yieldLabel.Text = "Прибыль, руб.:";
            // 
            // yieldTextBox
            // 
            yieldTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            yieldTextBox.Location = new Point(234, 3);
            yieldTextBox.Name = "yieldTextBox";
            yieldTextBox.ReadOnly = true;
            yieldTextBox.Size = new Size(47, 23);
            yieldTextBox.TabIndex = 1;
            // 
            // capitalGainsPercentLabel
            // 
            capitalGainsPercentLabel.AutoSize = true;
            capitalGainsPercentLabel.ImeMode = ImeMode.NoControl;
            capitalGainsPercentLabel.Location = new Point(3, 32);
            capitalGainsPercentLabel.Margin = new Padding(3);
            capitalGainsPercentLabel.Name = "capitalGainsPercentLabel";
            capitalGainsPercentLabel.Size = new Size(198, 15);
            capitalGainsPercentLabel.TabIndex = 2;
            capitalGainsPercentLabel.Text = "Прирост вложенного капитала, %:";
            // 
            // capitalGainsPercentTextBox
            // 
            capitalGainsPercentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            capitalGainsPercentTextBox.Location = new Point(234, 32);
            capitalGainsPercentTextBox.Name = "capitalGainsPercentTextBox";
            capitalGainsPercentTextBox.ReadOnly = true;
            capitalGainsPercentTextBox.Size = new Size(47, 23);
            capitalGainsPercentTextBox.TabIndex = 3;
            // 
            // realCouponIncomeLabel
            // 
            realCouponIncomeLabel.AutoSize = true;
            realCouponIncomeLabel.ImeMode = ImeMode.NoControl;
            realCouponIncomeLabel.Location = new Point(3, 61);
            realCouponIncomeLabel.Margin = new Padding(3);
            realCouponIncomeLabel.Name = "realCouponIncomeLabel";
            realCouponIncomeLabel.Size = new Size(211, 15);
            realCouponIncomeLabel.TabIndex = 4;
            realCouponIncomeLabel.Text = "Реальный купон. доход (за год), руб.:";
            // 
            // realCouponIncomeTextBox
            // 
            realCouponIncomeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            realCouponIncomeTextBox.Location = new Point(234, 61);
            realCouponIncomeTextBox.Name = "realCouponIncomeTextBox";
            realCouponIncomeTextBox.ReadOnly = true;
            realCouponIncomeTextBox.Size = new Size(47, 23);
            realCouponIncomeTextBox.TabIndex = 5;
            // 
            // realCouponIncomePercentLabel
            // 
            realCouponIncomePercentLabel.AutoSize = true;
            realCouponIncomePercentLabel.ImeMode = ImeMode.NoControl;
            realCouponIncomePercentLabel.Location = new Point(3, 90);
            realCouponIncomePercentLabel.Margin = new Padding(3);
            realCouponIncomePercentLabel.Name = "realCouponIncomePercentLabel";
            realCouponIncomePercentLabel.Size = new Size(194, 15);
            realCouponIncomePercentLabel.TabIndex = 6;
            realCouponIncomePercentLabel.Text = "Реальная купон. доход (за год), %:";
            // 
            // realCouponIncomePercentTextBox
            // 
            realCouponIncomePercentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            realCouponIncomePercentTextBox.Location = new Point(234, 90);
            realCouponIncomePercentTextBox.Name = "realCouponIncomePercentTextBox";
            realCouponIncomePercentTextBox.ReadOnly = true;
            realCouponIncomePercentTextBox.Size = new Size(47, 23);
            realCouponIncomePercentTextBox.TabIndex = 7;
            // 
            // realYieldPercentLabel
            // 
            realYieldPercentLabel.AutoSize = true;
            realYieldPercentLabel.ImeMode = ImeMode.NoControl;
            realYieldPercentLabel.Location = new Point(3, 119);
            realYieldPercentLabel.Margin = new Padding(3);
            realYieldPercentLabel.Name = "realYieldPercentLabel";
            realYieldPercentLabel.Size = new Size(186, 15);
            realYieldPercentLabel.TabIndex = 8;
            realYieldPercentLabel.Text = "Реальная доходность (за год), %:";
            // 
            // realYieldPercentTextBox
            // 
            realYieldPercentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            realYieldPercentTextBox.Location = new Point(234, 119);
            realYieldPercentTextBox.Name = "realYieldPercentTextBox";
            realYieldPercentTextBox.ReadOnly = true;
            realYieldPercentTextBox.Size = new Size(47, 23);
            realYieldPercentTextBox.TabIndex = 9;
            // 
            // YieldInfoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(yieldInfoGroupBox);
            Name = "YieldInfoView";
            Size = new Size(300, 178);
            yieldInfoGroupBox.ResumeLayout(false);
            yieldInfoTableLayoutPanel.ResumeLayout(false);
            yieldInfoTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox yieldInfoGroupBox;
        private TableLayoutPanel yieldInfoTableLayoutPanel;
        private Label yieldLabel;
        private TextBox yieldTextBox;
        private Label capitalGainsPercentLabel;
        private TextBox capitalGainsPercentTextBox;
        private Label realCouponIncomeLabel;
        private TextBox realCouponIncomeTextBox;
        private Label realCouponIncomePercentLabel;
        private TextBox realCouponIncomePercentTextBox;
        private Label realYieldPercentLabel;
        private TextBox realYieldPercentTextBox;
    }
}
