//using MultiFormDemo20250402.Properties;

namespace MultiFormDemo20250402
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
//            Text = Properties.Resources.Title; 
        }

        private void miExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void miAbout_Click(object sender, EventArgs e) {
            AboutForm af = new AboutForm(txtTextToShow.Text);
            //    af.Show(); // the about form can lose the focus - not exclusive
            if (af.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("You pressed OK on the about form.");
            }  else {
                MessageBox.Show("You pressed No Way on the about form.");
            }
        }
    }
}
