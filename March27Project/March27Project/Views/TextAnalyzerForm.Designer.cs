namespace March27Project.Views {
    partial class TextAnalyzerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            miOpen = new ToolStripMenuItem();
            miSave = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            miAbout = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            rtbStory = new RichTextBox();
            cmnuStory = new ContextMenuStrip(components);
            cmiUpper = new ToolStripMenuItem();
            cmiLower = new ToolStripMenuItem();
            btnAnalyze = new Button();
            dgWordCounts = new DataGridView();
            cmnuDataGrid = new ContextMenuStrip(components);
            cmiSaveResults = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            cmnuStory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgWordCounts).BeginInit();
            cmnuDataGrid.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { miOpen, miSave, miExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // miOpen
            // 
            miOpen.Name = "miOpen";
            miOpen.Size = new Size(128, 26);
            miOpen.Text = "Open";
            miOpen.Click += miOpen_Click;
            // 
            // miSave
            // 
            miSave.Name = "miSave";
            miSave.Size = new Size(128, 26);
            miSave.Text = "Save";
            miSave.Click += miSave_Click;
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new Size(128, 26);
            miExit.Text = "Exit";
            miExit.Click += miExit_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { miAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(55, 24);
            mnuHelp.Text = "Help";
            // 
            // miAbout
            // 
            miAbout.Name = "miAbout";
            miAbout.Size = new Size(133, 26);
            miAbout.Text = "About";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgWordCounts);
            splitContainer1.Size = new Size(800, 422);
            splitContainer1.SplitterDistance = 469;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(rtbStory);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnAnalyze);
            splitContainer2.Size = new Size(469, 422);
            splitContainer2.SplitterDistance = 320;
            splitContainer2.TabIndex = 0;
            // 
            // rtbStory
            // 
            rtbStory.ContextMenuStrip = cmnuStory;
            rtbStory.Dock = DockStyle.Fill;
            rtbStory.Location = new Point(0, 0);
            rtbStory.Name = "rtbStory";
            rtbStory.Size = new Size(469, 320);
            rtbStory.TabIndex = 0;
            rtbStory.Text = "";
            // 
            // cmnuStory
            // 
            cmnuStory.ImageScalingSize = new Size(20, 20);
            cmnuStory.Items.AddRange(new ToolStripItem[] { cmiUpper, cmiLower });
            cmnuStory.Name = "cmnuStory";
            cmnuStory.Size = new Size(171, 52);
            // 
            // cmiUpper
            // 
            cmiUpper.Name = "cmiUpper";
            cmiUpper.Size = new Size(170, 24);
            cmiUpper.Text = "To upper case";
            cmiUpper.Click += cmiUpper_Click;
            // 
            // cmiLower
            // 
            cmiLower.Name = "cmiLower";
            cmiLower.Size = new Size(170, 24);
            cmiLower.Text = "To lower case";
            cmiLower.Click += cmiLower_Click;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(194, 41);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(94, 29);
            btnAnalyze.TabIndex = 0;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // dgWordCounts
            // 
            dgWordCounts.AllowUserToAddRows = false;
            dgWordCounts.AllowUserToDeleteRows = false;
            dgWordCounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWordCounts.ContextMenuStrip = cmnuDataGrid;
            dgWordCounts.Dock = DockStyle.Fill;
            dgWordCounts.Location = new Point(0, 0);
            dgWordCounts.Name = "dgWordCounts";
            dgWordCounts.ReadOnly = true;
            dgWordCounts.RowHeadersWidth = 51;
            dgWordCounts.Size = new Size(327, 422);
            dgWordCounts.TabIndex = 0;
            dgWordCounts.ColumnHeaderMouseClick += dgWordCounts_ColumnHeaderMouseClick;
            // 
            // cmnuDataGrid
            // 
            cmnuDataGrid.ImageScalingSize = new Size(20, 20);
            cmnuDataGrid.Items.AddRange(new ToolStripItem[] { cmiSaveResults });
            cmnuDataGrid.Name = "cmnuDataGrid";
            cmnuDataGrid.Size = new Size(156, 28);
            // 
            // cmiSaveResults
            // 
            cmiSaveResults.Name = "cmiSaveResults";
            cmiSaveResults.Size = new Size(210, 24);
            cmiSaveResults.Text = "Save results";
            cmiSaveResults.Click += cmiSaveResults_Click;
            // 
            // TextAnalyzerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TextAnalyzerForm";
            Text = "TextAnalyzerForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            cmnuStory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgWordCounts).EndInit();
            cmnuDataGrid.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem miOpen;
        private ToolStripMenuItem miSave;
        private ToolStripMenuItem miExit;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem miAbout;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private RichTextBox rtbStory;
        private Button btnAnalyze;
        private DataGridView dgWordCounts;
        private ContextMenuStrip cmnuStory;
        private ToolStripMenuItem cmiUpper;
        private ToolStripMenuItem cmiLower;
        private ContextMenuStrip cmnuDataGrid;
        private ToolStripMenuItem cmiSaveResults;
    }
}