namespace BondYieldCalculator.GUI.ViewControls.Views
{
    partial class CommonInfoView
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
            commonInfoGroupBox = new GroupBox();
            commonInfoTableLayoutPanel = new TableLayoutPanel();
            nominalPriceLabel = new Label();
            maturityTextBox = new TextBox();
            nominalPriceTextBox = new TextBox();
            currentPriceTextBox = new TextBox();
            currentPriceLabel = new Label();
            maturityLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            commonInfoGroupBox.SuspendLayout();
            commonInfoTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // commonInfoGroupBox
            // 
            commonInfoGroupBox.Controls.Add(commonInfoTableLayoutPanel);
            commonInfoGroupBox.Dock = DockStyle.Top;
            commonInfoGroupBox.Location = new Point(0, 0);
            commonInfoGroupBox.Name = "commonInfoGroupBox";
            commonInfoGroupBox.Padding = new Padding(8);
            commonInfoGroupBox.Size = new Size(300, 150);
            commonInfoGroupBox.TabIndex = 0;
            commonInfoGroupBox.TabStop = false;
            commonInfoGroupBox.Text = "Общая информация";
            // 
            // commonInfoTableLayoutPanel
            // 
            commonInfoTableLayoutPanel.ColumnCount = 2;
            commonInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231F));
            commonInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            commonInfoTableLayoutPanel.Controls.Add(nominalPriceLabel, 0, 1);
            commonInfoTableLayoutPanel.Controls.Add(maturityTextBox, 1, 3);
            commonInfoTableLayoutPanel.Controls.Add(nominalPriceTextBox, 1, 1);
            commonInfoTableLayoutPanel.Controls.Add(currentPriceTextBox, 1, 2);
            commonInfoTableLayoutPanel.Controls.Add(currentPriceLabel, 0, 2);
            commonInfoTableLayoutPanel.Controls.Add(maturityLabel, 0, 3);
            commonInfoTableLayoutPanel.Controls.Add(nameLabel, 0, 0);
            commonInfoTableLayoutPanel.Controls.Add(nameTextBox, 1, 0);
            commonInfoTableLayoutPanel.Dock = DockStyle.Top;
            commonInfoTableLayoutPanel.Location = new Point(8, 24);
            commonInfoTableLayoutPanel.Name = "commonInfoTableLayoutPanel";
            commonInfoTableLayoutPanel.RowCount = 4;
            commonInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            commonInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            commonInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            commonInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            commonInfoTableLayoutPanel.Size = new Size(284, 117);
            commonInfoTableLayoutPanel.TabIndex = 0;
            // 
            // nominalPriceLabel
            // 
            nominalPriceLabel.AutoSize = true;
            nominalPriceLabel.ImeMode = ImeMode.NoControl;
            nominalPriceLabel.Location = new Point(3, 32);
            nominalPriceLabel.Margin = new Padding(3);
            nominalPriceLabel.Name = "nominalPriceLabel";
            nominalPriceLabel.Size = new Size(91, 15);
            nominalPriceLabel.TabIndex = 2;
            nominalPriceLabel.Text = "Номинал, руб.:";
            // 
            // maturityTextBox
            // 
            maturityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maturityTextBox.Location = new Point(234, 90);
            maturityTextBox.Name = "maturityTextBox";
            maturityTextBox.ReadOnly = true;
            maturityTextBox.Size = new Size(47, 23);
            maturityTextBox.TabIndex = 7;
            // 
            // nominalPriceTextBox
            // 
            nominalPriceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nominalPriceTextBox.Location = new Point(234, 32);
            nominalPriceTextBox.Name = "nominalPriceTextBox";
            nominalPriceTextBox.ReadOnly = true;
            nominalPriceTextBox.Size = new Size(47, 23);
            nominalPriceTextBox.TabIndex = 3;
            // 
            // currentPriceTextBox
            // 
            currentPriceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            currentPriceTextBox.Location = new Point(234, 61);
            currentPriceTextBox.Name = "currentPriceTextBox";
            currentPriceTextBox.ReadOnly = true;
            currentPriceTextBox.Size = new Size(47, 23);
            currentPriceTextBox.TabIndex = 5;
            // 
            // currentPriceLabel
            // 
            currentPriceLabel.AutoSize = true;
            currentPriceLabel.ImeMode = ImeMode.NoControl;
            currentPriceLabel.Location = new Point(3, 61);
            currentPriceLabel.Margin = new Padding(3);
            currentPriceLabel.Name = "currentPriceLabel";
            currentPriceLabel.Size = new Size(147, 15);
            currentPriceLabel.TabIndex = 4;
            currentPriceLabel.Text = "Текущая стоимость, руб.:";
            // 
            // maturityLabel
            // 
            maturityLabel.AutoSize = true;
            maturityLabel.ImeMode = ImeMode.NoControl;
            maturityLabel.Location = new Point(3, 90);
            maturityLabel.Margin = new Padding(3);
            maturityLabel.Name = "maturityLabel";
            maturityLabel.Size = new Size(62, 15);
            maturityLabel.TabIndex = 6;
            maturityLabel.Text = "Срок, лет:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ImeMode = ImeMode.NoControl;
            nameLabel.Location = new Point(3, 3);
            nameLabel.Margin = new Padding(3);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(93, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Наименование:";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(234, 3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(47, 23);
            nameTextBox.TabIndex = 1;
            // 
            // CommonInfoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(commonInfoGroupBox);
            Name = "CommonInfoView";
            Size = new Size(300, 149);
            commonInfoGroupBox.ResumeLayout(false);
            commonInfoTableLayoutPanel.ResumeLayout(false);
            commonInfoTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox commonInfoGroupBox;
        private TableLayoutPanel commonInfoTableLayoutPanel;
        private Label nominalPriceLabel;
        private TextBox maturityTextBox;
        private TextBox nominalPriceTextBox;
        private TextBox currentPriceTextBox;
        private Label currentPriceLabel;
        private Label maturityLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
    }
}
