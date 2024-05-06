namespace MilaShopParser
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            KolProducts = new TextBox();
            GoToParse = new Button();
            dataGridView2 = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Поставщик = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            Clean = new Button();
            saveFileDialog1 = new SaveFileDialog();
            Save = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Trebuchet MS", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "wow-цены", "Лицо", "Уход за телом", "Гигиена", "Волосы", "Макияж и парфимерия ", "Для детей и мам", "Для мужчин", "Стирка и уборка", "Дом и отдых", "Мода и украшение", "Колготки и носки ", "Кэшбек за покупки" });
            comboBox1.Location = new Point(1183, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(509, 62);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(1145, 51);
            label1.TabIndex = 2;
            label1.Text = "Выберите с какой категории вы хотите собрать данные";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1698, 22);
            label2.Name = "label2";
            label2.Size = new Size(606, 51);
            label2.TabIndex = 3;
            label2.Text = "Какое количество продуктов";
            // 
            // KolProducts
            // 
            KolProducts.Font = new Font("Trebuchet MS", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KolProducts.Location = new Point(2320, 21);
            KolProducts.Name = "KolProducts";
            KolProducts.Size = new Size(131, 57);
            KolProducts.TabIndex = 4;
            // 
            // GoToParse
            // 
            GoToParse.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GoToParse.Location = new Point(2535, 12);
            GoToParse.Name = "GoToParse";
            GoToParse.Size = new Size(293, 73);
            GoToParse.TabIndex = 5;
            GoToParse.Text = "Начать ";
            GoToParse.UseVisualStyleBackColor = true;
            GoToParse.Click += GoToParse_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column8, Column9, Column10, Column11, Column12, Поставщик, Column13, Column14 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Location = new Point(49, 103);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(2794, 1186);
            dataGridView2.TabIndex = 7;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.FillWeight = 441.025635F;
            Column8.HeaderText = "№";
            Column8.MaxInputLength = 32769;
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 86;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.FillWeight = 51.2820549F;
            Column9.HeaderText = "Название";
            Column9.MinimumWidth = 10;
            Column9.Name = "Column9";
            Column9.Width = 116;
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column10.FillWeight = 51.2820549F;
            Column10.HeaderText = "скидочная цена";
            Column10.MinimumWidth = 10;
            Column10.Name = "Column10";
            Column10.Width = 151;
            // 
            // Column11
            // 
            Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column11.FillWeight = 51.2820549F;
            Column11.HeaderText = "полная цена ";
            Column11.MinimumWidth = 10;
            Column11.Name = "Column11";
            Column11.Width = 135;
            // 
            // Column12
            // 
            Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column12.FillWeight = 51.2820549F;
            Column12.HeaderText = "Бренд";
            Column12.MinimumWidth = 10;
            Column12.Name = "Column12";
            Column12.Width = 107;
            // 
            // Поставщик
            // 
            Поставщик.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Поставщик.FillWeight = 51.2820549F;
            Поставщик.HeaderText = "Поставщик";
            Поставщик.MinimumWidth = 10;
            Поставщик.Name = "Поставщик";
            Поставщик.Width = 126;
            // 
            // Column13
            // 
            Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column13.FillWeight = 51.2820549F;
            Column13.HeaderText = "Адрес поставщика";
            Column13.MinimumWidth = 10;
            Column13.Name = "Column13";
            Column13.Width = 167;
            // 
            // Column14
            // 
            Column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column14.FillWeight = 51.2820549F;
            Column14.HeaderText = "Страна происхождения ";
            Column14.MinimumWidth = 10;
            Column14.Name = "Column14";
            Column14.Width = 193;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(753, 681);
            label3.Name = "label3";
            label3.Size = new Size(778, 170);
            label3.TabIndex = 8;
            label3.Text = "loging...........";
            // 
            // Clean
            // 
            Clean.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clean.Location = new Point(2550, 1321);
            Clean.Name = "Clean";
            Clean.Size = new Size(293, 73);
            Clean.TabIndex = 9;
            Clean.Text = "Очистить";
            Clean.UseVisualStyleBackColor = true;
            Clean.Click += Clean_Click;
            // 
            // Save
            // 
            Save.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save.Location = new Point(2228, 1321);
            Save.Name = "Save";
            Save.Size = new Size(293, 73);
            Save.TabIndex = 10;
            Save.Text = "Сохранить ";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2884, 1429);
            Controls.Add(Save);
            Controls.Add(Clean);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(GoToParse);
            Controls.Add(KolProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox KolProducts;
        private Button GoToParse;
        private DataGridView dataGridView2;
        private Label label3;
        private Button Clean;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Поставщик;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private SaveFileDialog saveFileDialog1;
        private Button Save;
    }
}
