namespace MultiFormDemo20250402
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            miAbout = new ToolStripMenuItem();
            lblTextToDisplay = new Label();
            txtTextToShow = new TextBox();
            pbxPicture = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPicture).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.ShortcutKeys = Keys.Control | Keys.X;
            miExit.Size = new Size(167, 26);
            miExit.Text = "Exit";
            miExit.Click += miExit_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miAbout });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // miAbout
            // 
            miAbout.Name = "miAbout";
            miAbout.Size = new Size(133, 26);
            miAbout.Text = "About";
            miAbout.Click += miAbout_Click;
            // 
            // lblTextToDisplay
            // 
            lblTextToDisplay.AutoSize = true;
            lblTextToDisplay.Location = new Point(317, 80);
            lblTextToDisplay.Name = "lblTextToDisplay";
            lblTextToDisplay.Size = new Size(100, 20);
            lblTextToDisplay.TabIndex = 1;
            lblTextToDisplay.Text = "Enter the text:";
            // 
            // txtTextToShow
            // 
            txtTextToShow.Location = new Point(438, 77);
            txtTextToShow.Name = "txtTextToShow";
            txtTextToShow.Size = new Size(339, 27);
            txtTextToShow.TabIndex = 2;
            // 
            // pbxPicture
            // 
            pbxPicture.InitialImage = (Image)resources.GetObject("pbxPicture.InitialImage");
            pbxPicture.Location = new Point(22, 59);
            pbxPicture.Name = "pbxPicture";
            pbxPicture.Size = new Size(270, 352);
            pbxPicture.TabIndex = 3;
            pbxPicture.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbxPicture);
            Controls.Add(txtTextToShow);
            Controls.Add(lblTextToDisplay);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem miExit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem miAbout;
        private Label lblTextToDisplay;
        private TextBox txtTextToShow;
        private PictureBox pbxPicture;
    }
}
