using System;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class AddPlayer : Form
    {
        public Player NewPlayer { get; private set; }

        public AddPlayer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtTeam.Text) ||
                !int.TryParse(txtPoints.Text, out int goals) ||
                !int.TryParse(txtAssists.Text, out int assists) ||
                !int.TryParse(txtRebounds.Text, out int CleanSheets) ||
                !int.TryParse(txtMatches.Text, out int matches)
                ||
                string.IsNullOrWhiteSpace(txtImage.Text))
            {
                MessageBox.Show("Please fill out all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewPlayer = new Player
            {
                Name = txtName.Text,
                Team = txtTeam.Text,
                Goals = goals,
                Assists = assists,
                CleanSheets = CleanSheets,
                Matches = matches,
                Photo = txtImage.Text // Default photo
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
