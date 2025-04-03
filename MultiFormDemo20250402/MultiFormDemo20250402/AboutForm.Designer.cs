namespace MultiFormDemo20250402 {
    partial class AboutForm {
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
            lblAbout = new Label();
            btnClose = new Button();
            btnNoWay = new Button();
            SuspendLayout();
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAbout.Location = new Point(12, 28);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(725, 50);
            lblAbout.TabIndex = 0;
            lblAbout.Text = "This is all about the application";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(220, 338);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(136, 38);
            btnClose.TabIndex = 1;
            btnClose.Text = "OK";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnNoWay
            // 
            btnNoWay.Location = new Point(413, 338);
            btnNoWay.Name = "btnNoWay";
            btnNoWay.Size = new Size(114, 38);
            btnNoWay.TabIndex = 2;
            btnNoWay.Text = "No Way!";
            btnNoWay.UseVisualStyleBackColor = true;
            btnNoWay.Click += btnNoWay_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 409);
            Controls.Add(btnNoWay);
            Controls.Add(btnClose);
            Controls.Add(lblAbout);
            Name = "AboutForm";
            Text = "About this application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAbout;
        private Button btnClose;
        private Button btnNoWay;
    }
}