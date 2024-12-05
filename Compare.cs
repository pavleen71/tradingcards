using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class Compare : Form
    {
        private List<Player> players;

        public Compare(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
            BindPlayersToDropdowns();
        }

        private void BindPlayersToDropdowns()
        {
            var playerNames = players.Select(p => p.Name).ToList();
            cmbPlayer1.DataSource = new List<string>(playerNames);
            cmbPlayer2.DataSource = new List<string>(playerNames);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (cmbPlayer1.SelectedIndex == -1 || cmbPlayer2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select two players to compare.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPlayer1.SelectedItem.ToString() == cmbPlayer2.SelectedItem.ToString())
            {
                MessageBox.Show("Please select two different players.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var player1 = players.First(p => p.Name == cmbPlayer1.SelectedItem.ToString());
            var player2 = players.First(p => p.Name == cmbPlayer2.SelectedItem.ToString());

            string result = $"Comparison Result:\n\n" +
                            $"{player1.Name}: {player1.Goals} Goals, {player1.Assists} Assists, {player1.CleanSheets} Clean Sheets\n" +
                            $"{player2.Name}: {player2.Goals} Goals, {player2.Assists} Assists, {player2.CleanSheets} Clean Sheets\n\n";

            result += player1.Goals > player2.Goals
                ? $"{player1.Name} has more Goals."
                : player2.Goals > player1.Goals
                    ? $"{player2.Name} has more Goals."
                    : "Both players have the same number of Goals.";

            lblComparisonResult.Text = result; // Display the result in the label
        }
    }
}
