using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using March27Project.Controllers;
using March27Project.Models;

namespace March27Project.Views {
    public partial class TextAnalyzerForm : Form {

        private TextAnalyzerController tac;
        public TextAnalyzerForm(TextAnalyzerController controller) {
            InitializeComponent();
            tac = controller;
        }

        private void miExit_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void miOpen_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"c:\temp";
            ofd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1; // sets text files as the default
            if (ofd.ShowDialog() == DialogResult.OK) {
                rtbStory.Text = tac.ReadStory(ofd.FileName);
            }
        }

        private void miSave_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"c:\temp";
            sfd.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1; // sets text files as the default
            if (sfd.ShowDialog() == DialogResult.OK) {
                if (tac.SaveStory(sfd.FileName, rtbStory.Text)) {
                    MessageBox.Show("Story was saved");
                }
                else {
                    MessageBox.Show("Story could not be saved.");
                }
            }
        }

        private void cmiUpper_Click(object sender, EventArgs e) {
            rtbStory.Text = rtbStory.Text.ToUpper();
        }

        private void cmiLower_Click(object sender, EventArgs e) {
            rtbStory.Text = rtbStory.Text.ToLower();
        }

        private void btnAnalyze_Click(object sender, EventArgs e) {
            List<WordCount> wordCounts = tac.AnalyzeText(rtbStory.Text);
            dgWordCounts.DataSource = wordCounts;
            dgWordCounts.Columns[1].HeaderText = "Frequency";
        }

        private void dgWordCounts_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            string colName = dgWordCounts.Columns[e.ColumnIndex].DataPropertyName;
            if (colName == "Word") {
                dgWordCounts.DataSource = tac.AnalyzeText(rtbStory.Text, "word");
            }
            else {
                dgWordCounts.DataSource = tac.AnalyzeText(rtbStory.Text, "count");
            }
        }

        private void cmiSaveResults_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|XML files (*.xml)|*.xml|JSON files (*.json)|*.json";
            sfd.FilterIndex = 1;
            sfd.InitialDirectory = @"c:\temp";
            if (sfd.ShowDialog() == DialogResult.OK) {
                tac.SaveAnalysis(sfd.FileName, dgWordCounts.DataSource as List<WordCount>);
            }
        }
    }
}
