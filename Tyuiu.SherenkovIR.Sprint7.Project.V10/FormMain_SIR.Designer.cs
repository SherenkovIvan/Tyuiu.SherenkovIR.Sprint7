using System.Resources;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SIR));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridViewOrder_SIR = new DataGridView();
            buttonAddOrder_SIR = new Button();
            toolTip_SIR = new ToolTip(components);
            buttonSaveOrder_SIR = new Button();
            buttonSearch_SIR = new Button();
            buttonSortPrise_SIR = new Button();
            buttonFilterPrice_SIR = new Button();
            buttonStatistic_SIR = new Button();
            buttonLoadCSV_SIR = new Button();
            buttonClose_SIR = new Button();
            buttonRemovePrise_SIR = new Button();
            buttonRemoveSearch_SIR = new Button();
            textBoxSearch_SIR = new TextBox();
            textBoxMinPrice_SIR = new TextBox();
            textBoxMaxPrice_SIR = new TextBox();
            labelStatistick_SIR = new Label();
            chartOrder_SIR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            toolStrip_SIR = new ToolStrip();
            toolStripButtonAboutProgramm_SIR = new ToolStripButton();
            toolStripButtonUserGuide_SIR = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder_SIR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOrder_SIR).BeginInit();
            toolStrip_SIR.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOrder_SIR
            // 
            dataGridViewOrder_SIR.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewOrder_SIR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder_SIR.GridColor = Color.Black;
            dataGridViewOrder_SIR.Location = new Point(0, 0);
            dataGridViewOrder_SIR.Name = "dataGridViewOrder_SIR";
            dataGridViewOrder_SIR.RowHeadersWidth = 51;
            dataGridViewOrder_SIR.Size = new Size(956, 367);
            dataGridViewOrder_SIR.TabIndex = 0;
            // 
            // buttonAddOrder_SIR
            // 
            buttonAddOrder_SIR.BackColor = SystemColors.Control;
            buttonAddOrder_SIR.Image = (Image)resources.GetObject("buttonAddOrder_SIR.Image");
            buttonAddOrder_SIR.Location = new Point(497, 500);
            buttonAddOrder_SIR.Name = "buttonAddOrder_SIR";
            buttonAddOrder_SIR.Size = new Size(84, 42);
            buttonAddOrder_SIR.TabIndex = 1;
            toolTip_SIR.SetToolTip(buttonAddOrder_SIR, "Добавить заказ");
            buttonAddOrder_SIR.UseVisualStyleBackColor = true;
            buttonAddOrder_SIR.Click += ButtonAddOrder_SIR_Click;
            // 
            // buttonSaveOrder_SIR
            // 
            buttonSaveOrder_SIR.BackColor = SystemColors.Control;
            buttonSaveOrder_SIR.ForeColor = Color.Black;
            buttonSaveOrder_SIR.Image = (Image)resources.GetObject("buttonSaveOrder_SIR.Image");
            buttonSaveOrder_SIR.Location = new Point(914, 497);
            buttonSaveOrder_SIR.Name = "buttonSaveOrder_SIR";
            buttonSaveOrder_SIR.Size = new Size(42, 42);
            buttonSaveOrder_SIR.TabIndex = 2;
            toolTip_SIR.SetToolTip(buttonSaveOrder_SIR, "Сохранить данные");
            buttonSaveOrder_SIR.UseVisualStyleBackColor = false;
            buttonSaveOrder_SIR.Click += ButtonSaveOrder_SIR_Click;
            // 
            // buttonSearch_SIR
            // 
            buttonSearch_SIR.BackColor = SystemColors.Control;
            buttonSearch_SIR.Image = (Image)resources.GetObject("buttonSearch_SIR.Image");
            buttonSearch_SIR.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearch_SIR.Location = new Point(587, 500);
            buttonSearch_SIR.Name = "buttonSearch_SIR";
            buttonSearch_SIR.Size = new Size(42, 42);
            buttonSearch_SIR.TabIndex = 3;
            toolTip_SIR.SetToolTip(buttonSearch_SIR, "Найти заказ по данным");
            buttonSearch_SIR.UseVisualStyleBackColor = true;
            buttonSearch_SIR.Click += ButtonSearch_SIR_Click;
            // 
            // buttonSortPrise_SIR
            // 
            buttonSortPrise_SIR.Location = new Point(787, 393);
            buttonSortPrise_SIR.Name = "buttonSortPrise_SIR";
            buttonSortPrise_SIR.Size = new Size(169, 48);
            buttonSortPrise_SIR.TabIndex = 6;
            buttonSortPrise_SIR.Text = "Сортировать по цене";
            toolTip_SIR.SetToolTip(buttonSortPrise_SIR, "Сортировка по цене");
            buttonSortPrise_SIR.UseVisualStyleBackColor = true;
            buttonSortPrise_SIR.Click += buttonSortPrise_SIR_Click;
            // 
            // buttonFilterPrice_SIR
            // 
            buttonFilterPrice_SIR.Location = new Point(585, 393);
            buttonFilterPrice_SIR.Name = "buttonFilterPrice_SIR";
            buttonFilterPrice_SIR.Size = new Size(171, 48);
            buttonFilterPrice_SIR.TabIndex = 7;
            buttonFilterPrice_SIR.Text = "Фильтр цены";
            toolTip_SIR.SetToolTip(buttonFilterPrice_SIR, "Искать от заданной цены");
            buttonFilterPrice_SIR.UseVisualStyleBackColor = true;
            buttonFilterPrice_SIR.Click += buttonFilterPrice_SIR_Click;
            // 
            // buttonStatistic_SIR
            // 
            buttonStatistic_SIR.Image = (Image)resources.GetObject("buttonStatistic_SIR.Image");
            buttonStatistic_SIR.Location = new Point(497, 408);
            buttonStatistic_SIR.Name = "buttonStatistic_SIR";
            buttonStatistic_SIR.Size = new Size(82, 38);
            buttonStatistic_SIR.TabIndex = 10;
            toolTip_SIR.SetToolTip(buttonStatistic_SIR, "Статистика таблицы");
            buttonStatistic_SIR.UseVisualStyleBackColor = true;
            buttonStatistic_SIR.Click += buttonStatistic_SIR_Click;
            // 
            // buttonLoadCSV_SIR
            // 
            buttonLoadCSV_SIR.Image = (Image)resources.GetObject("buttonLoadCSV_SIR.Image");
            buttonLoadCSV_SIR.Location = new Point(497, 452);
            buttonLoadCSV_SIR.Name = "buttonLoadCSV_SIR";
            buttonLoadCSV_SIR.Size = new Size(82, 42);
            buttonLoadCSV_SIR.TabIndex = 12;
            toolTip_SIR.SetToolTip(buttonLoadCSV_SIR, "Выбрать файл и загрузить");
            buttonLoadCSV_SIR.UseVisualStyleBackColor = true;
            buttonLoadCSV_SIR.Click += buttonLoadCSV_SIR_Click;
            // 
            // buttonClose_SIR
            // 
            buttonClose_SIR.Image = (Image)resources.GetObject("buttonClose_SIR.Image");
            buttonClose_SIR.Location = new Point(839, 497);
            buttonClose_SIR.Name = "buttonClose_SIR";
            buttonClose_SIR.Size = new Size(48, 42);
            buttonClose_SIR.TabIndex = 15;
            toolTip_SIR.SetToolTip(buttonClose_SIR, "Сбросить фильтр");
            buttonClose_SIR.UseVisualStyleBackColor = true;
            buttonClose_SIR.Click += buttonClose_SIR_Click;
            // 
            // buttonRemovePrise_SIR
            // 
            buttonRemovePrise_SIR.Location = new Point(787, 447);
            buttonRemovePrise_SIR.Name = "buttonRemovePrise_SIR";
            buttonRemovePrise_SIR.Size = new Size(169, 46);
            buttonRemovePrise_SIR.TabIndex = 16;
            buttonRemovePrise_SIR.Text = "Сбросить фильтр ";
            toolTip_SIR.SetToolTip(buttonRemovePrise_SIR, "Сбросить фльтр цены");
            buttonRemovePrise_SIR.UseVisualStyleBackColor = true;
            buttonRemovePrise_SIR.Click += buttonRemovePrise_SIR_Click;
            // 
            // buttonRemoveSearch_SIR
            // 
            buttonRemoveSearch_SIR.Image = (Image)resources.GetObject("buttonRemoveSearch_SIR.Image");
            buttonRemoveSearch_SIR.Location = new Point(770, 497);
            buttonRemoveSearch_SIR.Name = "buttonRemoveSearch_SIR";
            buttonRemoveSearch_SIR.Size = new Size(63, 42);
            buttonRemoveSearch_SIR.TabIndex = 17;
            toolTip_SIR.SetToolTip(buttonRemoveSearch_SIR, "Сброс фильтра поиска");
            buttonRemoveSearch_SIR.UseVisualStyleBackColor = true;
            buttonRemoveSearch_SIR.Click += buttonRemoveSearch_SIR_Click;
            // 
            // textBoxSearch_SIR
            // 
            textBoxSearch_SIR.Location = new Point(635, 500);
            textBoxSearch_SIR.Multiline = true;
            textBoxSearch_SIR.Name = "textBoxSearch_SIR";
            textBoxSearch_SIR.Size = new Size(121, 42);
            textBoxSearch_SIR.TabIndex = 4;
            // 
            // textBoxMinPrice_SIR
            // 
            textBoxMinPrice_SIR.Location = new Point(585, 447);
            textBoxMinPrice_SIR.Multiline = true;
            textBoxMinPrice_SIR.Name = "textBoxMinPrice_SIR";
            textBoxMinPrice_SIR.Size = new Size(81, 46);
            textBoxMinPrice_SIR.TabIndex = 8;
            // 
            // textBoxMaxPrice_SIR
            // 
            textBoxMaxPrice_SIR.Location = new Point(672, 447);
            textBoxMaxPrice_SIR.Multiline = true;
            textBoxMaxPrice_SIR.Name = "textBoxMaxPrice_SIR";
            textBoxMaxPrice_SIR.Size = new Size(84, 46);
            textBoxMaxPrice_SIR.TabIndex = 9;
            // 
            // labelStatistick_SIR
            // 
            labelStatistick_SIR.AutoSize = true;
            labelStatistick_SIR.Location = new Point(0, 370);
            labelStatistick_SIR.Name = "labelStatistick_SIR";
            labelStatistick_SIR.Size = new Size(225, 20);
            labelStatistick_SIR.TabIndex = 11;
            labelStatistick_SIR.Text = "Статистика расположена здесь";
            // 
            // chartOrder_SIR
            // 
            chartArea1.Name = "ChartArea1";
            chartOrder_SIR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartOrder_SIR.Legends.Add(legend1);
            chartOrder_SIR.Location = new Point(0, 393);
            chartOrder_SIR.Name = "chartOrder_SIR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartOrder_SIR.Series.Add(series1);
            chartOrder_SIR.Size = new Size(491, 159);
            chartOrder_SIR.TabIndex = 13;
            chartOrder_SIR.Text = "chart1";
            // 
            // toolStrip_SIR
            // 
            toolStrip_SIR.Dock = DockStyle.Bottom;
            toolStrip_SIR.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip_SIR.ImageScalingSize = new Size(20, 20);
            toolStrip_SIR.Items.AddRange(new ToolStripItem[] { toolStripButtonAboutProgramm_SIR, toolStripButtonUserGuide_SIR });
            toolStrip_SIR.Location = new Point(0, 553);
            toolStrip_SIR.Name = "toolStrip_SIR";
            toolStrip_SIR.Size = new Size(968, 27);
            toolStrip_SIR.TabIndex = 14;
            toolStrip_SIR.Text = "toolStrip1";
            // 
            // toolStripButtonAboutProgramm_SIR
            // 
            toolStripButtonAboutProgramm_SIR.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAboutProgramm_SIR.Image = (Image)resources.GetObject("toolStripButtonAboutProgramm_SIR.Image");
            toolStripButtonAboutProgramm_SIR.ImageTransparentColor = Color.Magenta;
            toolStripButtonAboutProgramm_SIR.Name = "toolStripButtonAboutProgramm_SIR";
            toolStripButtonAboutProgramm_SIR.Size = new Size(29, 24);
            toolStripButtonAboutProgramm_SIR.Text = "О программе";
            toolStripButtonAboutProgramm_SIR.ToolTipText = "О чем приложение";
            toolStripButtonAboutProgramm_SIR.Click += toolStripButtonAboutProgramm_SIR_Click;
            // 
            // toolStripButtonUserGuide_SIR
            // 
            toolStripButtonUserGuide_SIR.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUserGuide_SIR.Image = (Image)resources.GetObject("toolStripButtonUserGuide_SIR.Image");
            toolStripButtonUserGuide_SIR.ImageTransparentColor = Color.Magenta;
            toolStripButtonUserGuide_SIR.Name = "toolStripButtonUserGuide_SIR";
            toolStripButtonUserGuide_SIR.Size = new Size(29, 24);
            toolStripButtonUserGuide_SIR.Text = "Информация для пользователя";
            toolStripButtonUserGuide_SIR.ToolTipText = "Руководство пользователя";
            toolStripButtonUserGuide_SIR.Click += toolStripButtonUserGuide_SIR_Click;
            // 
            // FormMain_SIR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 580);
            Controls.Add(buttonRemoveSearch_SIR);
            Controls.Add(buttonRemovePrise_SIR);
            Controls.Add(buttonClose_SIR);
            Controls.Add(toolStrip_SIR);
            Controls.Add(chartOrder_SIR);
            Controls.Add(buttonLoadCSV_SIR);
            Controls.Add(labelStatistick_SIR);
            Controls.Add(buttonStatistic_SIR);
            Controls.Add(textBoxMaxPrice_SIR);
            Controls.Add(textBoxMinPrice_SIR);
            Controls.Add(buttonFilterPrice_SIR);
            Controls.Add(buttonSortPrise_SIR);
            Controls.Add(textBoxSearch_SIR);
            Controls.Add(buttonSearch_SIR);
            Controls.Add(buttonSaveOrder_SIR);
            Controls.Add(buttonAddOrder_SIR);
            Controls.Add(dataGridViewOrder_SIR);
            Name = "FormMain_SIR";
            Text = "Приложение для заказов. Выполнил Шеренков И. Р. студент группы ИБКСБ-25-1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder_SIR).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOrder_SIR).EndInit();
            toolStrip_SIR.ResumeLayout(false);
            toolStrip_SIR.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOrder_SIR;
        private Button buttonAddOrder_SIR;
        private ToolTip toolTip_SIR;
        private Button buttonSaveOrder_SIR;
        private Button buttonSearch_SIR;
        private TextBox textBoxSearch_SIR;
        private Button buttonSortPrise_SIR;
        private Button buttonFilterPrice_SIR;
        private TextBox textBoxMinPrice_SIR;
        private TextBox textBoxMaxPrice_SIR;
        private Button buttonStatistic_SIR;
        private Label labelStatistick_SIR;
        private Button buttonLoadCSV_SIR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrder_SIR;
        private ToolStrip toolStrip_SIR;
        private ToolStripButton toolStripButtonAboutProgramm_SIR;
        private ToolStripButton toolStripButtonUserGuide_SIR;
        private Button buttonClose_SIR;
        private Button buttonRemovePrise_SIR;
        private Button buttonRemoveSearch_SIR;
    }
}
