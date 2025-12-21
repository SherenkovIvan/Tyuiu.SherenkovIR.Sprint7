namespace Tyuiu.SherenkovIR.Sprint7.Project.V10
{
    partial class FormMain_SIR
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
            components = new System.ComponentModel.Container();
            dataGridViewOrder_SIR = new DataGridView();
            buttonAddOrder_SIR = new Button();
            toolTip1 = new ToolTip(components);
            buttonSaveOrder_SIR = new Button();
            buttonSearch_SIR = new Button();
            buttonSortByDate_SIR = new Button();
            buttonSortPrise_SIR = new Button();
            buttonFilterPrice_SIR = new Button();
            buttonStatistic_SIR = new Button();
            buttonLoadCSV_SIR = new Button();
            textBoxSearch_SIR = new TextBox();
            textBoxMinPrice_SIR = new TextBox();
            textBoxMaxPrice_SIR = new TextBox();
            labelStatistick_SIR = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder_SIR).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOrder_SIR
            // 
            dataGridViewOrder_SIR.BackgroundColor = Color.Gray;
            dataGridViewOrder_SIR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder_SIR.Dock = DockStyle.Fill;
            dataGridViewOrder_SIR.GridColor = Color.Black;
            dataGridViewOrder_SIR.Location = new Point(0, 0);
            dataGridViewOrder_SIR.Name = "dataGridViewOrder_SIR";
            dataGridViewOrder_SIR.RowHeadersWidth = 51;
            dataGridViewOrder_SIR.Size = new Size(982, 553);
            dataGridViewOrder_SIR.TabIndex = 0;
            // 
            // buttonAddOrder_SIR
            // 
            buttonAddOrder_SIR.BackColor = SystemColors.Control;
            buttonAddOrder_SIR.Location = new Point(0, 0);
            buttonAddOrder_SIR.Name = "buttonAddOrder_SIR";
            buttonAddOrder_SIR.Size = new Size(134, 29);
            buttonAddOrder_SIR.TabIndex = 1;
            buttonAddOrder_SIR.Text = "Добавить заказ";
            toolTip1.SetToolTip(buttonAddOrder_SIR, "Добавить файл в приложении");
            buttonAddOrder_SIR.UseVisualStyleBackColor = true;
            buttonAddOrder_SIR.Click += ButtonAddOrder_SIR_Click;
            // 
            // buttonSaveOrder_SIR
            // 
            buttonSaveOrder_SIR.BackColor = Color.Lime;
            buttonSaveOrder_SIR.ForeColor = Color.Black;
            buttonSaveOrder_SIR.Location = new Point(888, 524);
            buttonSaveOrder_SIR.Name = "buttonSaveOrder_SIR";
            buttonSaveOrder_SIR.Size = new Size(94, 29);
            buttonSaveOrder_SIR.TabIndex = 2;
            buttonSaveOrder_SIR.Text = "Сохранить";
            toolTip1.SetToolTip(buttonSaveOrder_SIR, "Сохранить данные");
            buttonSaveOrder_SIR.UseVisualStyleBackColor = false;
            buttonSaveOrder_SIR.Click += ButtonSaveOrder_SIR_Click;
            // 
            // buttonSearch_SIR
            // 
            buttonSearch_SIR.BackColor = SystemColors.Control;
            buttonSearch_SIR.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearch_SIR.Location = new Point(411, 366);
            buttonSearch_SIR.Name = "buttonSearch_SIR";
            buttonSearch_SIR.Size = new Size(83, 29);
            buttonSearch_SIR.TabIndex = 3;
            buttonSearch_SIR.Text = "Найти";
            toolTip1.SetToolTip(buttonSearch_SIR, "Найти заказ по данным");
            buttonSearch_SIR.UseVisualStyleBackColor = true;
            buttonSearch_SIR.Click += ButtonSearch_SIR_Click;
            // 
            // buttonSortByDate_SIR
            // 
            buttonSortByDate_SIR.Location = new Point(500, 365);
            buttonSortByDate_SIR.Name = "buttonSortByDate_SIR";
            buttonSortByDate_SIR.Size = new Size(110, 62);
            buttonSortByDate_SIR.TabIndex = 5;
            buttonSortByDate_SIR.Text = "Сортировать по дате";
            toolTip1.SetToolTip(buttonSortByDate_SIR, "Сортировка по дате ");
            buttonSortByDate_SIR.UseVisualStyleBackColor = true;
            buttonSortByDate_SIR.Click += buttonSortByDate_SIR_Click;
            // 
            // buttonSortPrise_SIR
            // 
            buttonSortPrise_SIR.Location = new Point(616, 365);
            buttonSortPrise_SIR.Name = "buttonSortPrise_SIR";
            buttonSortPrise_SIR.Size = new Size(128, 62);
            buttonSortPrise_SIR.TabIndex = 6;
            buttonSortPrise_SIR.Text = "Сортировать по цене";
            toolTip1.SetToolTip(buttonSortPrise_SIR, "Сортировка по цене");
            buttonSortPrise_SIR.UseVisualStyleBackColor = true;
            buttonSortPrise_SIR.Click += buttonSortPrise_SIR_Click;
            // 
            // buttonFilterPrice_SIR
            // 
            buttonFilterPrice_SIR.Location = new Point(750, 366);
            buttonFilterPrice_SIR.Name = "buttonFilterPrice_SIR";
            buttonFilterPrice_SIR.Size = new Size(94, 29);
            buttonFilterPrice_SIR.TabIndex = 7;
            buttonFilterPrice_SIR.Text = "Фильтр цены";
            toolTip1.SetToolTip(buttonFilterPrice_SIR, "Искать от заданной цены");
            buttonFilterPrice_SIR.UseVisualStyleBackColor = true;
            buttonFilterPrice_SIR.Click += buttonFilterPrice_SIR_Click;
            // 
            // buttonStatistic_SIR
            // 
            buttonStatistic_SIR.Location = new Point(850, 366);
            buttonStatistic_SIR.Name = "buttonStatistic_SIR";
            buttonStatistic_SIR.Size = new Size(94, 29);
            buttonStatistic_SIR.TabIndex = 10;
            buttonStatistic_SIR.Text = "Статистика";
            toolTip1.SetToolTip(buttonStatistic_SIR, "Статистика таблицы");
            buttonStatistic_SIR.UseVisualStyleBackColor = true;
            buttonStatistic_SIR.Click += buttonStatistic_SIR_Click;
            // 
            // buttonLoadCSV_SIR
            // 
            buttonLoadCSV_SIR.Location = new Point(888, 0);
            buttonLoadCSV_SIR.Name = "buttonLoadCSV_SIR";
            buttonLoadCSV_SIR.Size = new Size(94, 29);
            buttonLoadCSV_SIR.TabIndex = 12;
            buttonLoadCSV_SIR.Text = "Загрузить файл";
            toolTip1.SetToolTip(buttonLoadCSV_SIR, "Выбрать файл и загрузить");
            buttonLoadCSV_SIR.UseVisualStyleBackColor = true;
            buttonLoadCSV_SIR.Click += buttonLoadCSV_SIR_Click;
            // 
            // textBoxSearch_SIR
            // 
            textBoxSearch_SIR.Location = new Point(406, 400);
            textBoxSearch_SIR.Multiline = true;
            textBoxSearch_SIR.Name = "textBoxSearch_SIR";
            textBoxSearch_SIR.Size = new Size(88, 27);
            textBoxSearch_SIR.TabIndex = 4;
            // 
            // textBoxMinPrice_SIR
            // 
            textBoxMinPrice_SIR.Location = new Point(750, 401);
            textBoxMinPrice_SIR.Name = "textBoxMinPrice_SIR";
            textBoxMinPrice_SIR.Size = new Size(41, 27);
            textBoxMinPrice_SIR.TabIndex = 8;
            // 
            // textBoxMaxPrice_SIR
            // 
            textBoxMaxPrice_SIR.Location = new Point(803, 401);
            textBoxMaxPrice_SIR.Name = "textBoxMaxPrice_SIR";
            textBoxMaxPrice_SIR.Size = new Size(41, 27);
            textBoxMaxPrice_SIR.TabIndex = 9;
            // 
            // labelStatistick_SIR
            // 
            labelStatistick_SIR.AutoSize = true;
            labelStatistick_SIR.Location = new Point(0, 365);
            labelStatistick_SIR.Name = "labelStatistick_SIR";
            labelStatistick_SIR.Size = new Size(225, 20);
            labelStatistick_SIR.TabIndex = 11;
            labelStatistick_SIR.Text = "Статистика расположена здесь";
            // 
            // FormMain_SIR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(buttonLoadCSV_SIR);
            Controls.Add(labelStatistick_SIR);
            Controls.Add(buttonStatistic_SIR);
            Controls.Add(textBoxMaxPrice_SIR);
            Controls.Add(textBoxMinPrice_SIR);
            Controls.Add(buttonFilterPrice_SIR);
            Controls.Add(buttonSortPrise_SIR);
            Controls.Add(buttonSortByDate_SIR);
            Controls.Add(textBoxSearch_SIR);
            Controls.Add(buttonSearch_SIR);
            Controls.Add(buttonSaveOrder_SIR);
            Controls.Add(buttonAddOrder_SIR);
            Controls.Add(dataGridViewOrder_SIR);
            Name = "FormMain_SIR";
            Text = "Приложение по заказам. Выполнил Шеренков И. Р. студент группы ИБКСБ-25-1";
            Load += FormMain_SIR_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder_SIR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOrder_SIR;
        private Button buttonAddOrder_SIR;
        private ToolTip toolTip1;
        private Button buttonSaveOrder_SIR;
        private Button buttonSearch_SIR;
        private TextBox textBoxSearch_SIR;
        private Button buttonSortByDate_SIR;
        private Button buttonSortPrise_SIR;
        private Button buttonFilterPrice_SIR;
        private TextBox textBoxMinPrice_SIR;
        private TextBox textBoxMaxPrice_SIR;
        private Button buttonStatistic_SIR;
        private Label labelStatistick_SIR;
        private Button buttonLoadCSV_SIR;
    }
}
