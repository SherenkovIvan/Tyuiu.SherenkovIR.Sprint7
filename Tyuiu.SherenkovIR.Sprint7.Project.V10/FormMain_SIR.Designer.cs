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
            toolStripButtonRazrabothic_SIR = new ToolStripButton();
            panelElements_SIR = new Panel();
            groupBoxPanel_SIR = new GroupBox();
            groupBoxStatic_SIR = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder_SIR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOrder_SIR).BeginInit();
            toolStrip_SIR.SuspendLayout();
            panelElements_SIR.SuspendLayout();
            groupBoxPanel_SIR.SuspendLayout();
            groupBoxStatic_SIR.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOrder_SIR
            // 
            dataGridViewOrder_SIR.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewOrder_SIR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder_SIR.Dock = DockStyle.Fill;
            dataGridViewOrder_SIR.GridColor = Color.Black;
            dataGridViewOrder_SIR.Location = new Point(0, 0);
            dataGridViewOrder_SIR.Name = "dataGridViewOrder_SIR";
            dataGridViewOrder_SIR.RowHeadersWidth = 51;
            dataGridViewOrder_SIR.Size = new Size(1412, 603);
            dataGridViewOrder_SIR.TabIndex = 0;
            // 
            // buttonAddOrder_SIR
            // 
            buttonAddOrder_SIR.Anchor = AnchorStyles.Bottom;
            buttonAddOrder_SIR.BackColor = SystemColors.Control;
            buttonAddOrder_SIR.Image = (Image)resources.GetObject("buttonAddOrder_SIR.Image");
            buttonAddOrder_SIR.Location = new Point(0, 124);
            buttonAddOrder_SIR.Name = "buttonAddOrder_SIR";
            buttonAddOrder_SIR.Size = new Size(84, 42);
            buttonAddOrder_SIR.TabIndex = 1;
            toolTip_SIR.SetToolTip(buttonAddOrder_SIR, "Добавить заказ");
            buttonAddOrder_SIR.UseVisualStyleBackColor = true;
            buttonAddOrder_SIR.Click += ButtonAddOrder_SIR_Click;
            // 
            // buttonSaveOrder_SIR
            // 
            buttonSaveOrder_SIR.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSaveOrder_SIR.BackColor = SystemColors.Control;
            buttonSaveOrder_SIR.ForeColor = Color.Black;
            buttonSaveOrder_SIR.Image = (Image)resources.GetObject("buttonSaveOrder_SIR.Image");
            buttonSaveOrder_SIR.Location = new Point(389, 121);
            buttonSaveOrder_SIR.Name = "buttonSaveOrder_SIR";
            buttonSaveOrder_SIR.Size = new Size(42, 42);
            buttonSaveOrder_SIR.TabIndex = 2;
            toolTip_SIR.SetToolTip(buttonSaveOrder_SIR, "Сохранить данные");
            buttonSaveOrder_SIR.UseVisualStyleBackColor = false;
            buttonSaveOrder_SIR.Click += ButtonSaveOrder_SIR_Click;
            // 
            // buttonSearch_SIR
            // 
            buttonSearch_SIR.Anchor = AnchorStyles.Bottom;
            buttonSearch_SIR.BackColor = SystemColors.Control;
            buttonSearch_SIR.Image = (Image)resources.GetObject("buttonSearch_SIR.Image");
            buttonSearch_SIR.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearch_SIR.Location = new Point(90, 124);
            buttonSearch_SIR.Name = "buttonSearch_SIR";
            buttonSearch_SIR.Size = new Size(42, 42);
            buttonSearch_SIR.TabIndex = 3;
            toolTip_SIR.SetToolTip(buttonSearch_SIR, "Найти заказ по данным");
            buttonSearch_SIR.UseVisualStyleBackColor = true;
            buttonSearch_SIR.Click += ButtonSearch_SIR_Click;
            // 
            // buttonSortPrise_SIR
            // 
            buttonSortPrise_SIR.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSortPrise_SIR.Location = new Point(262, 28);
            buttonSortPrise_SIR.Name = "buttonSortPrise_SIR";
            buttonSortPrise_SIR.Size = new Size(169, 42);
            buttonSortPrise_SIR.TabIndex = 6;
            buttonSortPrise_SIR.Text = "Сортировать по цене";
            toolTip_SIR.SetToolTip(buttonSortPrise_SIR, "Сортировка по цене");
            buttonSortPrise_SIR.UseVisualStyleBackColor = true;
            buttonSortPrise_SIR.Click += buttonSortPrise_SIR_Click;
            // 
            // buttonFilterPrice_SIR
            // 
            buttonFilterPrice_SIR.Anchor = AnchorStyles.Bottom;
            buttonFilterPrice_SIR.Location = new Point(88, 28);
            buttonFilterPrice_SIR.Name = "buttonFilterPrice_SIR";
            buttonFilterPrice_SIR.Size = new Size(171, 42);
            buttonFilterPrice_SIR.TabIndex = 7;
            buttonFilterPrice_SIR.Text = "Фильтр цены";
            toolTip_SIR.SetToolTip(buttonFilterPrice_SIR, "Искать от заданной цены");
            buttonFilterPrice_SIR.UseVisualStyleBackColor = true;
            buttonFilterPrice_SIR.Click += buttonFilterPrice_SIR_Click;
            // 
            // buttonStatistic_SIR
            // 
            buttonStatistic_SIR.Anchor = AnchorStyles.Bottom;
            buttonStatistic_SIR.Image = (Image)resources.GetObject("buttonStatistic_SIR.Image");
            buttonStatistic_SIR.Location = new Point(0, 28);
            buttonStatistic_SIR.Name = "buttonStatistic_SIR";
            buttonStatistic_SIR.Size = new Size(82, 42);
            buttonStatistic_SIR.TabIndex = 10;
            toolTip_SIR.SetToolTip(buttonStatistic_SIR, "Статистика таблицы");
            buttonStatistic_SIR.UseVisualStyleBackColor = true;
            buttonStatistic_SIR.Click += buttonStatistic_SIR_Click;
            // 
            // buttonLoadCSV_SIR
            // 
            buttonLoadCSV_SIR.Anchor = AnchorStyles.Bottom;
            buttonLoadCSV_SIR.Image = (Image)resources.GetObject("buttonLoadCSV_SIR.Image");
            buttonLoadCSV_SIR.Location = new Point(0, 76);
            buttonLoadCSV_SIR.Name = "buttonLoadCSV_SIR";
            buttonLoadCSV_SIR.Size = new Size(82, 42);
            buttonLoadCSV_SIR.TabIndex = 12;
            toolTip_SIR.SetToolTip(buttonLoadCSV_SIR, "Выбрать файл и загрузить");
            buttonLoadCSV_SIR.UseVisualStyleBackColor = true;
            buttonLoadCSV_SIR.Click += buttonLoadCSV_SIR_Click;
            // 
            // buttonClose_SIR
            // 
            buttonClose_SIR.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose_SIR.Image = (Image)resources.GetObject("buttonClose_SIR.Image");
            buttonClose_SIR.Location = new Point(334, 121);
            buttonClose_SIR.Name = "buttonClose_SIR";
            buttonClose_SIR.Size = new Size(48, 42);
            buttonClose_SIR.TabIndex = 15;
            toolTip_SIR.SetToolTip(buttonClose_SIR, "Удалить заказ");
            buttonClose_SIR.UseVisualStyleBackColor = true;
            buttonClose_SIR.Click += buttonClose_SIR_Click;
            // 
            // buttonRemovePrise_SIR
            // 
            buttonRemovePrise_SIR.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRemovePrise_SIR.Location = new Point(262, 74);
            buttonRemovePrise_SIR.Name = "buttonRemovePrise_SIR";
            buttonRemovePrise_SIR.Size = new Size(169, 41);
            buttonRemovePrise_SIR.TabIndex = 16;
            buttonRemovePrise_SIR.Text = "Сбросить фильтр ";
            toolTip_SIR.SetToolTip(buttonRemovePrise_SIR, "Сбросить фльтр цены");
            buttonRemovePrise_SIR.UseVisualStyleBackColor = true;
            buttonRemovePrise_SIR.Click += buttonRemovePrise_SIR_Click;
            // 
            // buttonRemoveSearch_SIR
            // 
            buttonRemoveSearch_SIR.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRemoveSearch_SIR.Image = (Image)resources.GetObject("buttonRemoveSearch_SIR.Image");
            buttonRemoveSearch_SIR.Location = new Point(265, 121);
            buttonRemoveSearch_SIR.Name = "buttonRemoveSearch_SIR";
            buttonRemoveSearch_SIR.Size = new Size(63, 42);
            buttonRemoveSearch_SIR.TabIndex = 17;
            toolTip_SIR.SetToolTip(buttonRemoveSearch_SIR, "Сброс фильтра поиска");
            buttonRemoveSearch_SIR.UseVisualStyleBackColor = true;
            buttonRemoveSearch_SIR.Click += buttonRemoveSearch_SIR_Click;
            // 
            // textBoxSearch_SIR
            // 
            textBoxSearch_SIR.Anchor = AnchorStyles.Bottom;
            textBoxSearch_SIR.Location = new Point(138, 124);
            textBoxSearch_SIR.Multiline = true;
            textBoxSearch_SIR.Name = "textBoxSearch_SIR";
            textBoxSearch_SIR.Size = new Size(121, 42);
            textBoxSearch_SIR.TabIndex = 4;
            // 
            // textBoxMinPrice_SIR
            // 
            textBoxMinPrice_SIR.Anchor = AnchorStyles.Bottom;
            textBoxMinPrice_SIR.Location = new Point(88, 76);
            textBoxMinPrice_SIR.Multiline = true;
            textBoxMinPrice_SIR.Name = "textBoxMinPrice_SIR";
            textBoxMinPrice_SIR.Size = new Size(81, 41);
            textBoxMinPrice_SIR.TabIndex = 8;
            // 
            // textBoxMaxPrice_SIR
            // 
            textBoxMaxPrice_SIR.Anchor = AnchorStyles.Bottom;
            textBoxMaxPrice_SIR.Location = new Point(175, 76);
            textBoxMaxPrice_SIR.Multiline = true;
            textBoxMaxPrice_SIR.Name = "textBoxMaxPrice_SIR";
            textBoxMaxPrice_SIR.Size = new Size(84, 41);
            textBoxMaxPrice_SIR.TabIndex = 9;
            // 
            // labelStatistick_SIR
            // 
            labelStatistick_SIR.Anchor = AnchorStyles.Left;
            labelStatistick_SIR.AutoSize = true;
            labelStatistick_SIR.Location = new Point(-3, 10);
            labelStatistick_SIR.Name = "labelStatistick_SIR";
            labelStatistick_SIR.Size = new Size(225, 20);
            labelStatistick_SIR.TabIndex = 11;
            labelStatistick_SIR.Text = "Статистика расположена здесь";
            // 
            // chartOrder_SIR
            // 
            chartOrder_SIR.Anchor = AnchorStyles.Left;
            chartArea1.Name = "ChartArea1";
            chartOrder_SIR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartOrder_SIR.Legends.Add(legend1);
            chartOrder_SIR.Location = new Point(-3, 43);
            chartOrder_SIR.Name = "chartOrder_SIR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartOrder_SIR.Series.Add(series1);
            chartOrder_SIR.Size = new Size(642, 159);
            chartOrder_SIR.TabIndex = 13;
            chartOrder_SIR.Text = "chart1";
            // 
            // toolStrip_SIR
            // 
            toolStrip_SIR.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            toolStrip_SIR.Dock = DockStyle.None;
            toolStrip_SIR.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip_SIR.ImageScalingSize = new Size(20, 20);
            toolStrip_SIR.Items.AddRange(new ToolStripItem[] { toolStripButtonAboutProgramm_SIR, toolStripButtonRazrabothic_SIR });
            toolStrip_SIR.Location = new Point(325, 178);
            toolStrip_SIR.Name = "toolStrip_SIR";
            toolStrip_SIR.Size = new Size(61, 27);
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
            // toolStripButtonRazrabothic_SIR
            // 
            toolStripButtonRazrabothic_SIR.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRazrabothic_SIR.Image = (Image)resources.GetObject("toolStripButtonRazrabothic_SIR.Image");
            toolStripButtonRazrabothic_SIR.ImageTransparentColor = Color.Magenta;
            toolStripButtonRazrabothic_SIR.Name = "toolStripButtonRazrabothic_SIR";
            toolStripButtonRazrabothic_SIR.Size = new Size(29, 24);
            toolStripButtonRazrabothic_SIR.Text = "Информация для пользователя";
            toolStripButtonRazrabothic_SIR.ToolTipText = "О разработчике\r\n";
            toolStripButtonRazrabothic_SIR.Click += toolStripButtonUserGuide_SIR_Click;
            // 
            // panelElements_SIR
            // 
            panelElements_SIR.AutoSize = true;
            panelElements_SIR.Controls.Add(groupBoxPanel_SIR);
            panelElements_SIR.Dock = DockStyle.Bottom;
            panelElements_SIR.Location = new Point(0, 362);
            panelElements_SIR.MinimumSize = new Size(962, 241);
            panelElements_SIR.Name = "panelElements_SIR";
            panelElements_SIR.Size = new Size(1412, 241);
            panelElements_SIR.TabIndex = 18;
            // 
            // groupBoxPanel_SIR
            // 
            groupBoxPanel_SIR.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxPanel_SIR.Controls.Add(buttonFilterPrice_SIR);
            groupBoxPanel_SIR.Controls.Add(toolStrip_SIR);
            groupBoxPanel_SIR.Controls.Add(textBoxMaxPrice_SIR);
            groupBoxPanel_SIR.Controls.Add(buttonRemoveSearch_SIR);
            groupBoxPanel_SIR.Controls.Add(buttonStatistic_SIR);
            groupBoxPanel_SIR.Controls.Add(buttonAddOrder_SIR);
            groupBoxPanel_SIR.Controls.Add(textBoxMinPrice_SIR);
            groupBoxPanel_SIR.Controls.Add(buttonRemovePrise_SIR);
            groupBoxPanel_SIR.Controls.Add(buttonLoadCSV_SIR);
            groupBoxPanel_SIR.Controls.Add(buttonSaveOrder_SIR);
            groupBoxPanel_SIR.Controls.Add(buttonSortPrise_SIR);
            groupBoxPanel_SIR.Controls.Add(buttonClose_SIR);
            groupBoxPanel_SIR.Controls.Add(textBoxSearch_SIR);
            groupBoxPanel_SIR.Controls.Add(buttonSearch_SIR);
            groupBoxPanel_SIR.Location = new Point(978, 3);
            groupBoxPanel_SIR.MinimumSize = new Size(434, 208);
            groupBoxPanel_SIR.Name = "groupBoxPanel_SIR";
            groupBoxPanel_SIR.Size = new Size(434, 208);
            groupBoxPanel_SIR.TabIndex = 19;
            groupBoxPanel_SIR.TabStop = false;
            // 
            // groupBoxStatic_SIR
            // 
            groupBoxStatic_SIR.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxStatic_SIR.Controls.Add(chartOrder_SIR);
            groupBoxStatic_SIR.Controls.Add(labelStatistick_SIR);
            groupBoxStatic_SIR.Location = new Point(0, 365);
            groupBoxStatic_SIR.MinimumSize = new Size(494, 199);
            groupBoxStatic_SIR.Name = "groupBoxStatic_SIR";
            groupBoxStatic_SIR.Size = new Size(658, 212);
            groupBoxStatic_SIR.TabIndex = 19;
            groupBoxStatic_SIR.TabStop = false;
            // 
            // FormMain_SIR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1412, 603);
            Controls.Add(groupBoxStatic_SIR);
            Controls.Add(panelElements_SIR);
            Controls.Add(dataGridViewOrder_SIR);
            MinimumSize = new Size(1430, 650);
            Name = "FormMain_SIR";
            Text = "Приложение для заказов. Выполнил Шеренков И. Р. студент группы ИБКСБ-25-1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder_SIR).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOrder_SIR).EndInit();
            toolStrip_SIR.ResumeLayout(false);
            toolStrip_SIR.PerformLayout();
            panelElements_SIR.ResumeLayout(false);
            groupBoxPanel_SIR.ResumeLayout(false);
            groupBoxPanel_SIR.PerformLayout();
            groupBoxStatic_SIR.ResumeLayout(false);
            groupBoxStatic_SIR.PerformLayout();
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
        private ToolStripButton toolStripButtonRazrabothic_SIR;
        private Button buttonClose_SIR;
        private Button buttonRemovePrise_SIR;
        private Button buttonRemoveSearch_SIR;
        private Panel panelElements_SIR;
        private GroupBox groupBoxPanel_SIR;
        private GroupBox groupBoxStatic_SIR;
    }
}
