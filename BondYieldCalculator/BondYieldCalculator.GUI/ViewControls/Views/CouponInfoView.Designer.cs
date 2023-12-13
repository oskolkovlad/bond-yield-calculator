namespace BondYieldCalculator.GUI.ViewControls.Views
{
    partial class CouponInfoView
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
            couponInfoGroupBox = new GroupBox();
            couponInfoTableLayoutPanel = new TableLayoutPanel();
            accumulatedCouponIncomeLabel = new Label();
            accumulatedCouponIncomeTextBox = new TextBox();
            couponLabel = new Label();
            couponTextBox = new TextBox();
            couponsQuantityLabel = new Label();
            couponsQuantityTextBox = new TextBox();
            quantityOfPaymentsInYearLabel = new Label();
            quantityOfPaymentsInYearTextBox = new TextBox();
            couponInfoGroupBox.SuspendLayout();
            couponInfoTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // couponInfoGroupBox
            // 
            couponInfoGroupBox.Controls.Add(couponInfoTableLayoutPanel);
            couponInfoGroupBox.Dock = DockStyle.Top;
            couponInfoGroupBox.Location = new Point(0, 0);
            couponInfoGroupBox.Name = "couponInfoGroupBox";
            couponInfoGroupBox.Padding = new Padding(8);
            couponInfoGroupBox.Size = new Size(300, 150);
            couponInfoGroupBox.TabIndex = 0;
            couponInfoGroupBox.TabStop = false;
            couponInfoGroupBox.Text = "Информация по купонам";
            // 
            // couponInfoTableLayoutPanel
            // 
            couponInfoTableLayoutPanel.ColumnCount = 2;
            couponInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231F));
            couponInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            couponInfoTableLayoutPanel.Controls.Add(accumulatedCouponIncomeLabel, 0, 0);
            couponInfoTableLayoutPanel.Controls.Add(accumulatedCouponIncomeTextBox, 1, 0);
            couponInfoTableLayoutPanel.Controls.Add(couponLabel, 0, 1);
            couponInfoTableLayoutPanel.Controls.Add(couponTextBox, 1, 1);
            couponInfoTableLayoutPanel.Controls.Add(couponsQuantityLabel, 0, 2);
            couponInfoTableLayoutPanel.Controls.Add(couponsQuantityTextBox, 1, 2);
            couponInfoTableLayoutPanel.Controls.Add(quantityOfPaymentsInYearLabel, 0, 3);
            couponInfoTableLayoutPanel.Controls.Add(quantityOfPaymentsInYearTextBox, 1, 3);
            couponInfoTableLayoutPanel.Dock = DockStyle.Top;
            couponInfoTableLayoutPanel.Location = new Point(8, 24);
            couponInfoTableLayoutPanel.Name = "couponInfoTableLayoutPanel";
            couponInfoTableLayoutPanel.RowCount = 4;
            couponInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            couponInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            couponInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            couponInfoTableLayoutPanel.RowStyles.Add(new RowStyle());
            couponInfoTableLayoutPanel.Size = new Size(284, 117);
            couponInfoTableLayoutPanel.TabIndex = 0;
            // 
            // accumulatedCouponIncomeLabel
            // 
            accumulatedCouponIncomeLabel.AutoSize = true;
            accumulatedCouponIncomeLabel.ImeMode = ImeMode.NoControl;
            accumulatedCouponIncomeLabel.Location = new Point(3, 3);
            accumulatedCouponIncomeLabel.Margin = new Padding(3);
            accumulatedCouponIncomeLabel.Name = "accumulatedCouponIncomeLabel";
            accumulatedCouponIncomeLabel.Size = new Size(63, 15);
            accumulatedCouponIncomeLabel.TabIndex = 0;
            accumulatedCouponIncomeLabel.Text = "НКД, руб.:";
            // 
            // accumulatedCouponIncomeTextBox
            // 
            accumulatedCouponIncomeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accumulatedCouponIncomeTextBox.Location = new Point(234, 3);
            accumulatedCouponIncomeTextBox.Name = "accumulatedCouponIncomeTextBox";
            accumulatedCouponIncomeTextBox.ReadOnly = true;
            accumulatedCouponIncomeTextBox.Size = new Size(47, 23);
            accumulatedCouponIncomeTextBox.TabIndex = 1;
            // 
            // couponLabel
            // 
            couponLabel.AutoSize = true;
            couponLabel.ImeMode = ImeMode.NoControl;
            couponLabel.Location = new Point(3, 32);
            couponLabel.Margin = new Padding(3);
            couponLabel.Name = "couponLabel";
            couponLabel.Size = new Size(73, 15);
            couponLabel.TabIndex = 2;
            couponLabel.Text = "Купон, руб.:";
            // 
            // couponTextBox
            // 
            couponTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            couponTextBox.Location = new Point(234, 32);
            couponTextBox.Name = "couponTextBox";
            couponTextBox.ReadOnly = true;
            couponTextBox.Size = new Size(47, 23);
            couponTextBox.TabIndex = 3;
            // 
            // couponsQuantityLabel
            // 
            couponsQuantityLabel.AutoSize = true;
            couponsQuantityLabel.ImeMode = ImeMode.NoControl;
            couponsQuantityLabel.Location = new Point(3, 61);
            couponsQuantityLabel.Margin = new Padding(3);
            couponsQuantityLabel.Name = "couponsQuantityLabel";
            couponsQuantityLabel.Size = new Size(164, 15);
            couponsQuantityLabel.TabIndex = 4;
            couponsQuantityLabel.Text = "Общее кол-во купонов, шт.:";
            // 
            // couponsQuantityTextBox
            // 
            couponsQuantityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            couponsQuantityTextBox.Location = new Point(234, 61);
            couponsQuantityTextBox.Name = "couponsQuantityTextBox";
            couponsQuantityTextBox.ReadOnly = true;
            couponsQuantityTextBox.Size = new Size(47, 23);
            couponsQuantityTextBox.TabIndex = 5;
            // 
            // quantityOfPaymentsInYearLabel
            // 
            quantityOfPaymentsInYearLabel.AutoSize = true;
            quantityOfPaymentsInYearLabel.ImeMode = ImeMode.NoControl;
            quantityOfPaymentsInYearLabel.Location = new Point(3, 90);
            quantityOfPaymentsInYearLabel.Margin = new Padding(3);
            quantityOfPaymentsInYearLabel.Name = "quantityOfPaymentsInYearLabel";
            quantityOfPaymentsInYearLabel.Size = new Size(147, 15);
            quantityOfPaymentsInYearLabel.TabIndex = 6;
            quantityOfPaymentsInYearLabel.Text = "Кол-во выплат в год, шт.:";
            // 
            // quantityOfPaymentsInYearTextBox
            // 
            quantityOfPaymentsInYearTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            quantityOfPaymentsInYearTextBox.Location = new Point(234, 90);
            quantityOfPaymentsInYearTextBox.Name = "quantityOfPaymentsInYearTextBox";
            quantityOfPaymentsInYearTextBox.ReadOnly = true;
            quantityOfPaymentsInYearTextBox.Size = new Size(47, 23);
            quantityOfPaymentsInYearTextBox.TabIndex = 7;
            // 
            // CouponInfoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(couponInfoGroupBox);
            Name = "CouponInfoView";
            Size = new Size(300, 149);
            couponInfoGroupBox.ResumeLayout(false);
            couponInfoTableLayoutPanel.ResumeLayout(false);
            couponInfoTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox couponInfoGroupBox;
        private TableLayoutPanel couponInfoTableLayoutPanel;
        private Label accumulatedCouponIncomeLabel;
        private TextBox accumulatedCouponIncomeTextBox;
        private Label couponLabel;
        private TextBox couponTextBox;
        private Label couponsQuantityLabel;
        private TextBox couponsQuantityTextBox;
        private Label quantityOfPaymentsInYearLabel;
        private TextBox quantityOfPaymentsInYearTextBox;
    }
}
