using Tyuiu.SherenkovIR.Sprint7.Project.V10.Properties;

namespace Tyuiu.SherenkovIR.Sprint7.Project.V10
{
    partial class FormAbout_SIR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SIR));
            buttonClose_SIR = new Button();
            textBoxAbout_SIR = new TextBox();
            pictureBoxImage_SIR = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage_SIR).BeginInit();
            SuspendLayout();
            // 
            // buttonClose_SIR
            // 
            buttonClose_SIR.BackColor = SystemColors.Control;
            buttonClose_SIR.ForeColor = SystemColors.ControlText;
            buttonClose_SIR.Location = new Point(238, 256);
            buttonClose_SIR.Margin = new Padding(3, 4, 3, 4);
            buttonClose_SIR.Name = "buttonClose_SIR";
            buttonClose_SIR.Size = new Size(76, 35);
            buttonClose_SIR.TabIndex = 0;
            buttonClose_SIR.Text = "Ок";
            buttonClose_SIR.UseVisualStyleBackColor = false;
            buttonClose_SIR.Click += buttonClose_SIR_Click;
            // 
            // textBoxAbout_SIR
            // 
            textBoxAbout_SIR.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAbout_SIR.Location = new Point(54, 12);
            textBoxAbout_SIR.Multiline = true;
            textBoxAbout_SIR.Name = "textBoxAbout_SIR";
            textBoxAbout_SIR.ReadOnly = true;
            textBoxAbout_SIR.Size = new Size(465, 218);
            textBoxAbout_SIR.TabIndex = 1;
            textBoxAbout_SIR.Text = resources.GetString("textBoxAbout_SIR.Text");
            // 
            // pictureBoxImage_SIR
            // 
            pictureBoxImage_SIR.BackColor = SystemColors.Control;
            pictureBoxImage_SIR.Image = (Image)resources.GetObject("pictureBoxImage_SIR.Image");
            pictureBoxImage_SIR.Location = new Point(12, 23);
            pictureBoxImage_SIR.Name = "pictureBoxImage_SIR";
            pictureBoxImage_SIR.Size = new Size(36, 33);
            pictureBoxImage_SIR.TabIndex = 2;
            pictureBoxImage_SIR.TabStop = false;
            // 
            // FormAbout_SIR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(531, 310);
            Controls.Add(pictureBoxImage_SIR);
            Controls.Add(textBoxAbout_SIR);
            Controls.Add(buttonClose_SIR);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_SIR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage_SIR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose_SIR;
        private TextBox textBoxAbout_SIR;
        private PictureBox pictureBoxImage_SIR;
    }
}