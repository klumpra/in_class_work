using GuitarWorld.Controllers;
namespace GuitarWorld.Views
{
    public partial class GuitarWorldForm : Form
    {
        private GuitarController controller;
        public GuitarWorldForm(GuitarController gc)
        {
            InitializeComponent();
            controller = gc;
        }
        public void FillGuitarNamesComboBox()
        {
            List<string> names = controller.GetGuitarNames();
            List<string> items = new List<string>();
            items.Add(string.Empty);
            items.AddRange(names);
            cmbGuitars.DataSource = items;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (controller.ValidateEntries(txtName.Text, txtManufacturer.Text, txtModel.Text, int.Parse(udYear.Text)))
            {
                controller.AddGuitar(txtName.Text, txtManufacturer.Text, txtModel.Text, int.Parse(udYear.Text));
                List<string> descriptions = controller.GetTextOfAllGuitars();
                rtbGuitarDescriptions.Lines = descriptions.ToArray();
                ClearEntries();
                FillGuitarNamesComboBox();
            } else
            {
                MessageBox.Show("You entered incorrect values.", "Error");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ClearEntries()
        {
            txtName.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            txtModel.Text = string.Empty;
            udYear.Value = DateTime.Now.Year;
        }

        private void FillControls(Dictionary<string, string> settings)
        {
            txtName.Text = settings["name"];
            txtManufacturer.Text = settings["manufacturer"];
            txtModel.Text = settings["model"];
            udYear.Value = int.Parse(settings["year"]);
        }
        private void cmbGuitars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> details = controller.GetGuitarDetails(cmbGuitars.SelectedValue as string);
            if (details != null)
            {
                FillControls(details);
            }
        }
    }
}
