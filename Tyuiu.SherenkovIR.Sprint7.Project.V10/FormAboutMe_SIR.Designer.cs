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
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SIR).BeginInit();
            SuspendLayout();
            // 
            // textBoxAboutMe_SIR
            // 
            textBoxAboutMe_SIR.Location = new Point(21, 12);
            textBoxAboutMe_SIR.Multiline = true;
            textBoxAboutMe_SIR.Name = "textBoxAboutMe_SIR";
            textBoxAboutMe_SIR.Size = new Size(322, 305);
            textBoxAboutMe_SIR.TabIndex = 0;
            textBoxAboutMe_SIR.Text = resources.GetString("textBoxAboutMe_SIR.Text");
            // 
            // pictureBoxAvatar_SIR
            // 
            pictureBoxAvatar_SIR.Location = new Point(369, 12);
            pictureBoxAvatar_SIR.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAvatar_SIR.Name = "pictureBoxAvatar_SIR";
            pictureBoxAvatar_SIR.Size = new Size(314, 192);
            pictureBoxAvatar_SIR.TabIndex = 1;
            pictureBoxAvatar_SIR.TabStop = false;
            // 
            // buttonClose_SIR
            // 
            buttonClose_SIR.Location = new Point(494, 293);
            buttonClose_SIR.Margin = new Padding(3, 4, 3, 4);
            buttonClose_SIR.Name = "buttonClose_SIR";
            buttonClose_SIR.Size = new Size(84, 43);
            buttonClose_SIR.TabIndex = 2;
            buttonClose_SIR.Text = "Ok";
            buttonClose_SIR.UseVisualStyleBackColor = true;
            buttonClose_SIR.Click += buttonClose_SIR_Click;
            // 
            // FormAboutMe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 361);
            Controls.Add(buttonClose_SIR);
            Controls.Add(pictureBoxAvatar_SIR);
            Controls.Add(textBoxAboutMe_SIR);
            MaximizeBox = false;
            MinimizeBox = false;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAboutMe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SIR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAboutMe_SIR;
        private PictureBox pictureBoxAvatar_SIR;
        private Button buttonClose_SIR;
    }
}