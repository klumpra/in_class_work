
namespace GuitarWorld.Views
{
    partial class GuitarWorldForm
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
            panControls = new Panel();
            btnSave = new Button();
            udYear = new NumericUpDown();
            txtModel = new TextBox();
            txtManufacturer = new TextBox();
            txtName = new TextBox();
            lblYear = new Label();
            lblModel = new Label();
            lblManufacturer = new Label();
            lblName = new Label();
            lblSelect = new Label();
            cmbGuitars = new ComboBox();
            rtbGuitarDescriptions = new RichTextBox();
            btnExit = new Button();
            panControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udYear).BeginInit();
            SuspendLayout();
            // 
            // panControls
            // 
            panControls.Controls.Add(btnSave);
            panControls.Controls.Add(udYear);
            panControls.Controls.Add(txtModel);
            panControls.Controls.Add(txtManufacturer);
            panControls.Controls.Add(txtName);
            panControls.Controls.Add(lblYear);
            panControls.Controls.Add(lblModel);
            panControls.Controls.Add(lblManufacturer);
            panControls.Controls.Add(lblName);
            panControls.Location = new Point(102, 37);
            panControls.Name = "panControls";
            panControls.Size = new Size(307, 343);
            panControls.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(130, 298);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // udYear
            // 
            udYear.Location = new Point(196, 244);
            udYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            udYear.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            udYear.Name = "udYear";
            udYear.Size = new Size(77, 23);
            udYear.TabIndex = 7;
            udYear.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // txtModel
            // 
            txtModel.Location = new Point(173, 179);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(173, 108);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(100, 23);
            txtManufacturer.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(173, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(90, 252);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 3;
            lblYear.Text = "Year";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(78, 182);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(40, 111);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(79, 15);
            lblManufacturer.TabIndex = 1;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(80, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Location = new Point(490, 46);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(93, 15);
            lblSelect.TabIndex = 1;
            lblSelect.Text = "Select a guitar ...";
            // 
            // cmbGuitars
            // 
            cmbGuitars.FormattingEnabled = true;
            cmbGuitars.Items.AddRange(new object[] { "one", "two", "three" });
            cmbGuitars.Location = new Point(616, 45);
            cmbGuitars.Name = "cmbGuitars";
            cmbGuitars.Size = new Size(121, 23);
            cmbGuitars.TabIndex = 2;
            cmbGuitars.SelectedIndexChanged += cmbGuitars_SelectedIndexChanged;
            // 
            // rtbGuitarDescriptions
            // 
            rtbGuitarDescriptions.Location = new Point(488, 96);
            rtbGuitarDescriptions.Name = "rtbGuitarDescriptions";
            rtbGuitarDescriptions.Size = new Size(249, 284);
            rtbGuitarDescriptions.TabIndex = 3;
            rtbGuitarDescriptions.Text = "";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(389, 409);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // GuitarWorldForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(rtbGuitarDescriptions);
            Controls.Add(cmbGuitars);
            Controls.Add(lblSelect);
            Controls.Add(panControls);
            Name = "GuitarWorldForm";
            Text = "Guitar World";
            panControls.ResumeLayout(false);
            panControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panControls;
        private Label lblManufacturer;
        private Label lblName;
        private Button btnSave;
        private NumericUpDown udYear;
        private TextBox txtModel;
        private TextBox txtManufacturer;
        private TextBox txtName;
        private Label lblYear;
        private Label lblModel;
        private Label lblSelect;
        private ComboBox cmbGuitars;
        private RichTextBox rtbGuitarDescriptions;
        private Button btnExit;
    }
}
