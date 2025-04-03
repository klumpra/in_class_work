namespace ResourcesAttempt
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
        private void InitializeComponent() {
            pbxGuitar = new PictureBox();
            rtbLabel = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pbxGuitar).BeginInit();
            SuspendLayout();
            // 
            // pbxGuitar
            // 
            pbxGuitar.Location = new Point(39, 41);
            pbxGuitar.Name = "pbxGuitar";
            pbxGuitar.Size = new Size(320, 382);
            pbxGuitar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxGuitar.TabIndex = 0;
            pbxGuitar.TabStop = false;
            // 
            // rtbLabel
            // 
            rtbLabel.Location = new Point(405, 64);
            rtbLabel.Name = "rtbLabel";
            rtbLabel.Size = new Size(349, 294);
            rtbLabel.TabIndex = 1;
            rtbLabel.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbLabel);
            Controls.Add(pbxGuitar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbxGuitar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxGuitar;
        private RichTextBox rtbLabel;
    }
}
