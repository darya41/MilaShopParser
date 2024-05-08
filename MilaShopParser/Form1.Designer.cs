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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            KolProducts = new TextBox();
            GoToParse = new Button();
            Clean = new Button();
            saveFileDialog1 = new SaveFileDialog();
            Save = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column15 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(32, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(2811, 1174);
            dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "№";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 86;
            // 
            // Column2
            // 
            Column2.HeaderText = "Название ";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Скидочная цена";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 171;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Полная цена ";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 137;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Бренд";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 107;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Поставщик";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 126;
            // 
            // Column7
            // 
            Column7.HeaderText = "Адрес поставщика";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            // 
            // Column15
            // 
            Column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column15.HeaderText = "Страна происхождения ";
            Column15.MinimumWidth = 10;
            Column15.Name = "Column15";
            Column15.Width = 193;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(463, 613);
            label3.Name = "label3";
            label3.Size = new Size(1988, 240);
            label3.TabIndex = 12;
            label3.Text = "Loging ..................";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2884, 1429);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(Save);
            Controls.Add(Clean);
            Controls.Add(GoToParse);
            Controls.Add(KolProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox KolProducts;
        private Button GoToParse;
        private Button Clean;
        private SaveFileDialog saveFileDialog1;
        private Button Save;
        private DataGridView dataGridView1;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column15;
    }
}
