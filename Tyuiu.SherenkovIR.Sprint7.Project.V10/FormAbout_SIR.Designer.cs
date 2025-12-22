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
            buttonClose_SIR = new Button();
            textBoxAbout_SIR = new TextBox();
            SuspendLayout();
            // 
            // buttonClose_SIR
            // 
            buttonClose_SIR.Margin = new Padding(3, 4, 3, 4);
            buttonClose_SIR.BackColor = Color.LawnGreen;
            buttonClose_SIR.ForeColor = SystemColors.ControlText;
            buttonClose_SIR.Location = new Point(146, 295);
            buttonClose_SIR.Name = "buttonClose_SIR";
            buttonClose_SIR.Size = new Size(76, 35);
            buttonClose_SIR.TabIndex = 0;
            buttonClose_SIR.Text = "Ок";
            buttonClose_SIR.UseVisualStyleBackColor = true;
            buttonClose_SIR.Click += buttonClose_SIR_Click;
            // 
            // textBoxAbout_SIR
            // 
            textBoxAbout_SIR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAbout_SIR.Location = new Point(12, 12);
            textBoxAbout_SIR.Multiline = true;
            textBoxAbout_SIR.Name = "textBoxAbout_SIR";
            textBoxAbout_SIR.Size = new Size(345, 253);
            textBoxAbout_SIR.TabIndex = 1;
            // 
            // FormAbout_SIR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 347);
            Controls.Add(textBoxAbout_SIR);
            Controls.Add(buttonClose_SIR);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_SIR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose_SIR;
        private TextBox textBoxAbout_SIR;
    }
}