using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFormDemo20250402 {
    public partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();
            lblAbout.Text = "This is the default text.";
        }
        public AboutForm(string textToShow) {
            InitializeComponent();
            lblAbout.Text = textToShow;
        }
        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnNoWay_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
