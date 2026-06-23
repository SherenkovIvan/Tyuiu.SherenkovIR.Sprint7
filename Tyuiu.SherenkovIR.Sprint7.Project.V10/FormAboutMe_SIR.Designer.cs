using System.Windows.Forms;

namespace Tyuiu.SherenkovIR.Sprint7.Project.V10
{
    partial class FormAboutMe_SIR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutMe_SIR));
            textBoxAboutMe_SIR = new TextBox();
            pictureBoxAvatar_SIR = new PictureBox();
            buttonClose_SIR = new Button();
            pictureBoxAvatar_SSA = new PictureBox();
            textBoxSherenkovInit_SSA = new TextBox();
            textBoxShakirovInit_SSA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SIR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SSA).BeginInit();
            SuspendLayout();
            // 
            // textBoxAboutMe_SIR
            // 
            textBoxAboutMe_SIR.Location = new Point(1, 12);
            textBoxAboutMe_SIR.Multiline = true;
            textBoxAboutMe_SIR.Name = "textBoxAboutMe_SIR";
            textBoxAboutMe_SIR.ReadOnly = true;
            textBoxAboutMe_SIR.Size = new Size(401, 297);
            textBoxAboutMe_SIR.TabIndex = 0;
            textBoxAboutMe_SIR.Text = resources.GetString("textBoxAboutMe_SIR.Text");
            textBoxAboutMe_SIR.TextChanged += textBoxAboutMe_SIR_TextChanged;
            // 
            // pictureBoxAvatar_SIR
            // 
            pictureBoxAvatar_SIR.Image = (Image)resources.GetObject("pictureBoxAvatar_SIR.Image");
            pictureBoxAvatar_SIR.Location = new Point(419, 12);
            pictureBoxAvatar_SIR.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAvatar_SIR.Name = "pictureBoxAvatar_SIR";
            pictureBoxAvatar_SIR.Size = new Size(204, 222);
            pictureBoxAvatar_SIR.TabIndex = 1;
            pictureBoxAvatar_SIR.TabStop = false;
            // 
            // buttonClose_SIR
            // 
            buttonClose_SIR.BackColor = SystemColors.Control;
            buttonClose_SIR.Location = new Point(606, 258);
            buttonClose_SIR.Margin = new Padding(3, 4, 3, 4);
            buttonClose_SIR.Name = "buttonClose_SIR";
            buttonClose_SIR.Size = new Size(122, 43);
            buttonClose_SIR.TabIndex = 2;
            buttonClose_SIR.Text = "Ok";
            buttonClose_SIR.UseVisualStyleBackColor = false;
            buttonClose_SIR.Click += buttonClose_SIR_Click;
            // 
            // pictureBoxAvatar_SSA
            // 
            pictureBoxAvatar_SSA.Image = Properties.Resources.photo_2025_12_23_23_20_57;
            pictureBoxAvatar_SSA.Location = new Point(671, 12);
            pictureBoxAvatar_SSA.Name = "pictureBoxAvatar_SSA";
            pictureBoxAvatar_SSA.Size = new Size(271, 222);
            pictureBoxAvatar_SSA.TabIndex = 3;
            pictureBoxAvatar_SSA.TabStop = false;
            // 
            // textBoxSherenkovInit_SSA
            // 
            textBoxSherenkovInit_SSA.Location = new Point(419, 266);
            textBoxSherenkovInit_SSA.Name = "textBoxSherenkovInit_SSA";
            textBoxSherenkovInit_SSA.Size = new Size(125, 27);
            textBoxSherenkovInit_SSA.TabIndex = 4;
            textBoxSherenkovInit_SSA.Text = "Шеренков И.Р.";
            // 
            // textBoxShakirovInit_SSA
            // 
            textBoxShakirovInit_SSA.Location = new Point(765, 266);
            textBoxShakirovInit_SSA.Name = "textBoxShakirovInit_SSA";
            textBoxShakirovInit_SSA.Size = new Size(177, 27);
            textBoxShakirovInit_SSA.TabIndex = 5;
            textBoxShakirovInit_SSA.Text = "Шакиров С.А. (Qasqader)";
            // 
            // FormAboutMe_SIR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 321);
            Controls.Add(textBoxShakirovInit_SSA);
            Controls.Add(textBoxSherenkovInit_SSA);
            Controls.Add(pictureBoxAvatar_SSA);
            Controls.Add(buttonClose_SIR);
            Controls.Add(pictureBoxAvatar_SIR);
            Controls.Add(textBoxAboutMe_SIR);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAboutMe_SIR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SIR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SSA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAboutMe_SIR;
        private PictureBox pictureBoxAvatar_SIR;
        private Button buttonClose_SIR;
        private PictureBox pictureBoxAvatar_SSA;
        private TextBox textBoxSherenkovInit_SSA;
        private TextBox textBoxShakirovInit_SSA;
    }
}