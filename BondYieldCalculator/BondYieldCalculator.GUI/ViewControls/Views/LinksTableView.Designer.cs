namespace BondYieldCalculator.GUI.ViewControls.Views
{
    partial class LinksTableView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            linkTableLayoutPanel = new TableLayoutPanel();
            linkLabel = new Label();
            addLinkButton = new Button();
            linksTable = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            LinkColumn = new DataGridViewTextBoxColumn();
            MaturityColumn = new DataGridViewTextBoxColumn();
            RealYieldPercentColumn = new DataGridViewTextBoxColumn();
            removeLinksButton = new Button();
            analyzeButton = new Button();
            saveLinksButton = new Button();
            restoreLinksButton = new Button();
            linkTextBox = new TextBox();
            linkTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)linksTable).BeginInit();
            SuspendLayout();
            // 
            // linkTableLayoutPanel
            // 
            linkTableLayoutPanel.ColumnCount = 4;
            linkTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 239F));
            linkTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            linkTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            linkTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            linkTableLayoutPanel.Controls.Add(linkLabel, 0, 0);
            linkTableLayoutPanel.Controls.Add(addLinkButton, 2, 0);
            linkTableLayoutPanel.Controls.Add(linksTable, 0, 1);
            linkTableLayoutPanel.Controls.Add(removeLinksButton, 3, 0);
            linkTableLayoutPanel.Controls.Add(analyzeButton, 0, 2);
            linkTableLayoutPanel.Controls.Add(saveLinksButton, 3, 2);
            linkTableLayoutPanel.Controls.Add(restoreLinksButton, 2, 2);
            linkTableLayoutPanel.Controls.Add(linkTextBox, 1, 0);
            linkTableLayoutPanel.Dock = DockStyle.Fill;
            linkTableLayoutPanel.Location = new Point(0, 0);
            linkTableLayoutPanel.Name = "linkTableLayoutPanel";
            linkTableLayoutPanel.Padding = new Padding(2);
            linkTableLayoutPanel.RowCount = 3;
            linkTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            linkTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            linkTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            linkTableLayoutPanel.Size = new Size(1000, 150);
            linkTableLayoutPanel.TabIndex = 0;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.ImeMode = ImeMode.NoControl;
            linkLabel.Location = new Point(5, 5);
            linkLabel.Margin = new Padding(3);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(178, 15);
            linkLabel.TabIndex = 0;
            linkLabel.Text = "Введите ссылку на облигацию:";
            // 
            // addLinkButton
            // 
            addLinkButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addLinkButton.ImeMode = ImeMode.NoControl;
            addLinkButton.Location = new Point(801, 5);
            addLinkButton.Name = "addLinkButton";
            addLinkButton.Size = new Size(94, 23);
            addLinkButton.TabIndex = 2;
            addLinkButton.Text = "Добавить";
            addLinkButton.UseVisualStyleBackColor = true;
            // 
            // linksTable
            // 
            linksTable.AllowUserToAddRows = false;
            linksTable.AllowUserToResizeColumns = false;
            linksTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            linksTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            linksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            linksTable.Columns.AddRange(new DataGridViewColumn[] { NameColumn, LinkColumn, MaturityColumn, RealYieldPercentColumn });
            linkTableLayoutPanel.SetColumnSpan(linksTable, 4);
            linksTable.Dock = DockStyle.Fill;
            linksTable.Location = new Point(5, 35);
            linksTable.Name = "linksTable";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            linksTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            linksTable.RowHeadersWidth = 62;
            linksTable.RowTemplate.Height = 25;
            linksTable.Size = new Size(990, 80);
            linksTable.TabIndex = 4;
            // 
            // NameColumn
            // 
            NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameColumn.DataPropertyName = "Name";
            NameColumn.FillWeight = 25F;
            NameColumn.HeaderText = "Наименование облигации";
            NameColumn.MinimumWidth = 10;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // LinkColumn
            // 
            LinkColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LinkColumn.DataPropertyName = "Link";
            LinkColumn.FillWeight = 40F;
            LinkColumn.HeaderText = "Ссылка";
            LinkColumn.MinimumWidth = 50;
            LinkColumn.Name = "LinkColumn";
            // 
            // MaturityColumn
            // 
            MaturityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaturityColumn.DataPropertyName = "Maturity";
            MaturityColumn.FillWeight = 10F;
            MaturityColumn.HeaderText = "Срок, лет";
            MaturityColumn.MinimumWidth = 10;
            MaturityColumn.Name = "MaturityColumn";
            MaturityColumn.ReadOnly = true;
            // 
            // RealYieldPercentColumn
            // 
            RealYieldPercentColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RealYieldPercentColumn.DataPropertyName = "RealYieldPercent";
            RealYieldPercentColumn.FillWeight = 25F;
            RealYieldPercentColumn.HeaderText = "Реальная доходность (по сроку), %";
            RealYieldPercentColumn.MinimumWidth = 10;
            RealYieldPercentColumn.Name = "RealYieldPercentColumn";
            RealYieldPercentColumn.ReadOnly = true;
            // 
            // removeLinksButton
            // 
            removeLinksButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            removeLinksButton.ImeMode = ImeMode.NoControl;
            removeLinksButton.Location = new Point(901, 5);
            removeLinksButton.Name = "removeLinksButton";
            removeLinksButton.Size = new Size(94, 23);
            removeLinksButton.TabIndex = 3;
            removeLinksButton.Text = "Удалить";
            removeLinksButton.UseVisualStyleBackColor = true;
            // 
            // analyzeButton
            // 
            analyzeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            analyzeButton.ImeMode = ImeMode.NoControl;
            analyzeButton.Location = new Point(5, 121);
            analyzeButton.Name = "analyzeButton";
            analyzeButton.Size = new Size(233, 23);
            analyzeButton.TabIndex = 5;
            analyzeButton.Text = "Анализ";
            analyzeButton.UseVisualStyleBackColor = true;
            // 
            // saveLinksButton
            // 
            saveLinksButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            saveLinksButton.ImeMode = ImeMode.NoControl;
            saveLinksButton.Location = new Point(901, 121);
            saveLinksButton.Name = "saveLinksButton";
            saveLinksButton.Size = new Size(94, 23);
            saveLinksButton.TabIndex = 7;
            saveLinksButton.Text = "Сохранить";
            saveLinksButton.UseVisualStyleBackColor = true;
            // 
            // restoreLinksButton
            // 
            restoreLinksButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            restoreLinksButton.ImeMode = ImeMode.NoControl;
            restoreLinksButton.Location = new Point(801, 121);
            restoreLinksButton.Name = "restoreLinksButton";
            restoreLinksButton.Size = new Size(94, 23);
            restoreLinksButton.TabIndex = 6;
            restoreLinksButton.Text = "Восстановить";
            restoreLinksButton.UseVisualStyleBackColor = true;
            // 
            // linkTextBox
            // 
            linkTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            linkTextBox.Location = new Point(244, 5);
            linkTextBox.Name = "linkTextBox";
            linkTextBox.Size = new Size(551, 23);
            linkTextBox.TabIndex = 1;
            // 
            // LinksTableView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkTableLayoutPanel);
            Name = "LinksTableView";
            Size = new Size(1000, 150);
            linkTableLayoutPanel.ResumeLayout(false);
            linkTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)linksTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel linkTableLayoutPanel;
        private Label linkLabel;
        private Button addLinkButton;
        private DataGridView linksTable;
        private Button removeLinksButton;
        private Button analyzeButton;
        private Button saveLinksButton;
        private Button restoreLinksButton;
        private TextBox linkTextBox;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn LinkColumn;
        private DataGridViewTextBoxColumn MaturityColumn;
        private DataGridViewTextBoxColumn RealYieldPercentColumn;
    }
}
