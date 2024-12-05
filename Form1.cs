using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class Form1 : Form
    {
        private List<Player> players; // List to store player data
        private Dictionary<string, Color> teamColors; // Team color mapping

        public Form1()
        {
            InitializeComponent();
            teamColors = InitializeTeamColors(); // Initialize team colors
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlayers();      // Load initial player data
            BindPlayerList();   // Bind player names to the ListBox
        }

        /// <summary>
        /// Loads the initial set of football players into the list.
        /// </summary>
        private void LoadPlayers()
        {
            players = new List<Player>
            {
                new Player { Name = "Lionel Messi", Team = "PSG", Photo = "lionelmessi.jpeg", Goals = 805, Assists = 350, CleanSheets = 0, Matches = 1012 },
                new Player { Name = "Cristiano Ronaldo", Team = "Al-Nassr", Photo = "cristianoronaldo.jpeg", Goals = 820, Assists = 230, CleanSheets = 0, Matches = 1140 },
                new Player { Name = "Kevin De Bruyne", Team = "Manchester City", Photo = "kevindebruyne.jpeg", Goals = 90, Assists = 250, CleanSheets = 0, Matches = 450 },
                new Player { Name = "Kylian Mbappé", Team = "PSG", Photo = "kylianmbappe.jpeg", Goals = 250, Assists = 130, CleanSheets = 0, Matches = 320 },
                new Player { Name = "Erling Haaland", Team = "Manchester City", Photo = "erlinghaaland.jpeg", Goals = 150, Assists = 50, CleanSheets = 0, Matches = 200 },
                new Player { Name = "Virgil van Dijk", Team = "Liverpool", Photo = "virgilvandijk.jpeg", Goals = 30, Assists = 20, CleanSheets = 220, Matches = 350 },
                new Player { Name = "Mohamed Salah", Team = "Liverpool", Photo = "mohamedsalah.jpeg", Goals = 200, Assists = 100, CleanSheets = 0, Matches = 420 },
                new Player { Name = "Robert Lewandowski", Team = "Barcelona", Photo = "robertlewandowski.jpeg", Goals = 610, Assists = 120, CleanSheets = 0, Matches = 850 },
                new Player { Name = "Alisson Becker", Team = "Liverpool", Photo = "alissonbecker.jpeg", Goals = 1, Assists = 5, CleanSheets = 150, Matches = 250 },
                new Player { Name = "Neymar Jr", Team = "PSG", Photo = "neymarjr.jpeg", Goals = 250, Assists = 150, CleanSheets = 0, Matches = 450 }
            };
        }

        /// <summary>
        /// Binds the player names to the ListBox.
        /// </summary>
        private void BindPlayerList()
        {
            lstPlayers.DataSource = null; // Reset data source
            lstPlayers.DataSource = players.Select(p => p.Name).ToList(); // Bind names to ListBox
        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex == -1) return;

            var selectedPlayer = players.FirstOrDefault(p => p.Name == lstPlayers.SelectedItem.ToString());
            if (selectedPlayer == null) return;

            lblName.Text = $"Name: {selectedPlayer.Name}";
            lblTeam.Text = $"Team: {selectedPlayer.Team}";
            picPlayer.ImageLocation = System.IO.File.Exists(selectedPlayer.Photo) ? selectedPlayer.Photo : "default.jpeg";
            pnlCardView.BackColor = teamColors.TryGetValue(selectedPlayer.Team, out var color) ? color : Color.White;

            // Update stats with red/green text
            rtbStats.Clear();
            AppendStat("Goals", selectedPlayer.Goals, 200);          // Threshold: 200
            AppendStat("Assists", selectedPlayer.Assists, 100);      // Threshold: 100
            AppendStat("Clean Sheets", selectedPlayer.CleanSheets, 50); // Threshold: 50
            AppendStat("Matches", selectedPlayer.Matches, 300);     // Threshold: 300
        }

        /// <summary>
        /// Appends a stat to the RichTextBox with red or green color based on the value.
        /// </summary>
        /// <param name="statName">Name of the stat (e.g., Goals).</param>
        /// <param name="value">Value of the stat.</param>
        /// <param name="threshold">Threshold for determining high or low.</param>
        private void AppendStat(string statName, int value, int threshold)
        {
            rtbStats.SelectionStart = rtbStats.TextLength;
            rtbStats.SelectionLength = 0;

            // Set text color based on the threshold
            rtbStats.SelectionColor = value > threshold ? Color.Green : Color.Red;
            rtbStats.AppendText($"{statName}: {value}\n");

            rtbStats.SelectionColor = rtbStats.ForeColor; // Reset color
        }
        private void btnOpenComparison_Click(object sender, EventArgs e)
        {
            Compare comparisonForm = new Compare(players);
            comparisonForm.ShowDialog();
        }

        /// <summary>
        /// Displays the top-performing player based on points.
        /// </summary>
        private void btnTopPerformer_Click(object sender, EventArgs e)
        {
            var topPerformer = players.OrderByDescending(p => p.Goals).FirstOrDefault();
            if (topPerformer != null)
            {
                MessageBox.Show($"{topPerformer.Name} is the top performer with {topPerformer.Goals} Goals!", "Top Performer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayer addPlayerForm = new AddPlayer();
            if (addPlayerForm.ShowDialog() == DialogResult.OK)
            {
                // Add the new player to the list
                players.Add(addPlayerForm.NewPlayer);

                // Check if the team already has a color, assign a random color if it doesn't
                if (!teamColors.ContainsKey(addPlayerForm.NewPlayer.Team))
                {
                    Random random = new Random();
                    Color randomColor = Color.FromArgb(random.Next(100, 256), random.Next(100, 256), random.Next(100, 256));
                    teamColors.Add(addPlayerForm.NewPlayer.Team, randomColor);
                }

                // Refresh the ListBox
                BindPlayerList();
            }
        }
        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a player to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPlayer = players.FirstOrDefault(p => p.Name == lstPlayers.SelectedItem.ToString());
            if (selectedPlayer != null)
            {
                players.Remove(selectedPlayer); // Remove the player
                BindPlayerList(); // Refresh the ListBox
            }
        }



        /// <summary>
        /// Initializes team-specific background colors.
        /// </summary>
        /// <returns>A dictionary of team names and their colors.</returns>
        private Dictionary<string, Color> InitializeTeamColors()
        {
            return new Dictionary<string, Color>
            {
                { "PSG", Color.FromArgb(0, 0, 128) },
                { "Liverpool", Color.FromArgb(255, 0, 0) },
                { "Manchester City", Color.FromArgb(0, 128, 255) },
                { "Barcelona", Color.FromArgb(128, 0, 128) },
                { "Al-Nassr", Color.FromArgb(255, 223, 0) }
            };
        }
    }

    /// <summary>
    /// Represents a football player with all relevant details.
    /// </summary>
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string Photo { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int CleanSheets { get; set; }
        public int Matches { get; set; }
    }
}
