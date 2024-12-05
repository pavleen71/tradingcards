namespace TradingCards
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstPlayers = new ListBox();
            pnlCardView = new Panel();
            rtbStats = new RichTextBox();
            picPlayer = new PictureBox();
            lblName = new Label();
            lblTeam = new Label();
            btnOpenComparison = new Button();
            btnTopPerformer = new Button();
            btnAddPlayer = new Button();
            btnRemovePlayer = new Button();
            pnlCardView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            SuspendLayout();
            // 
            // lstPlayers
            // 
            lstPlayers.Font = new Font("Segoe UI", 12F);
            lstPlayers.FormattingEnabled = true;
            lstPlayers.ItemHeight = 32;
            lstPlayers.Location = new Point(610, 0);
            lstPlayers.Name = "lstPlayers";
            lstPlayers.Size = new Size(225, 452);
            lstPlayers.TabIndex = 0;
            lstPlayers.SelectedIndexChanged += lstPlayers_SelectedIndexChanged;
            // 
            // pnlCardView
            // 
            pnlCardView.BackColor = Color.White;
            pnlCardView.BorderStyle = BorderStyle.FixedSingle;
            pnlCardView.Controls.Add(rtbStats);
            pnlCardView.Controls.Add(picPlayer);
            pnlCardView.Controls.Add(lblName);
            pnlCardView.Controls.Add(lblTeam);
            pnlCardView.Location = new Point(10, 12);
            pnlCardView.Name = "pnlCardView";
            pnlCardView.Size = new Size(594, 440);
            pnlCardView.TabIndex = 1;
            // 
            // rtbStats
            // 
            rtbStats.BackColor = Color.White;
            rtbStats.BorderStyle = BorderStyle.None;
            rtbStats.Font = new Font("Segoe UI", 12F);
            rtbStats.Location = new Point(24, 160);
            rtbStats.Name = "rtbStats";
            rtbStats.ReadOnly = true;
            rtbStats.Size = new Size(261, 165);
            rtbStats.TabIndex = 3;
            rtbStats.Text = "";
            // 
            // picPlayer
            // 
            picPlayer.BorderStyle = BorderStyle.FixedSingle;
            picPlayer.Location = new Point(357, 18);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(214, 207);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 0;
            picPlayer.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblName.Location = new Point(36, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(192, 38);
            lblName.TabIndex = 1;
            lblName.Text = "Name: Player";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Font = new Font("Segoe UI", 14F);
            lblTeam.Location = new Point(48, 80);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(161, 38);
            lblTeam.TabIndex = 2;
            lblTeam.Text = "Team: Team";
            lblTeam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOpenComparison
            // 
            btnOpenComparison.Font = new Font("Segoe UI", 12F);
            btnOpenComparison.Location = new Point(858, 149);
            btnOpenComparison.Name = "btnOpenComparison";
            btnOpenComparison.Size = new Size(150, 40);
            btnOpenComparison.TabIndex = 4;
            btnOpenComparison.Text = "Compare Players";
            btnOpenComparison.UseVisualStyleBackColor = true;
            btnOpenComparison.Click += btnOpenComparison_Click;
            // 
            // btnTopPerformer
            // 
            btnTopPerformer.Font = new Font("Segoe UI", 12F);
            btnTopPerformer.Location = new Point(858, 41);
            btnTopPerformer.Name = "btnTopPerformer";
            btnTopPerformer.Size = new Size(150, 40);
            btnTopPerformer.TabIndex = 5;
            btnTopPerformer.Text = "Top Performer";
            btnTopPerformer.UseVisualStyleBackColor = true;
            btnTopPerformer.Click += btnTopPerformer_Click;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Font = new Font("Segoe UI", 12F);
            btnAddPlayer.Location = new Point(888, 257);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(120, 40);
            btnAddPlayer.TabIndex = 6;
            btnAddPlayer.Text = "Add Player";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // btnRemovePlayer
            // 
            btnRemovePlayer.Font = new Font("Segoe UI", 12F);
            btnRemovePlayer.Location = new Point(888, 377);
            btnRemovePlayer.Name = "btnRemovePlayer";
            btnRemovePlayer.Size = new Size(120, 40);
            btnRemovePlayer.TabIndex = 7;
            btnRemovePlayer.Text = "Remove Player";
            btnRemovePlayer.UseVisualStyleBackColor = true;
            btnRemovePlayer.Click += btnRemovePlayer_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1098, 450);
            Controls.Add(btnRemovePlayer);
            Controls.Add(btnAddPlayer);
            Controls.Add(btnTopPerformer);
            Controls.Add(btnOpenComparison);
            Controls.Add(pnlCardView);
            Controls.Add(lstPlayers);
            Name = "Form1";
            Text = "Trading cards - Football Players";
            Load += Form1_Load;
            pnlCardView.ResumeLayout(false);
            pnlCardView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Panel pnlCardView;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.RichTextBox rtbStats; 

        //   private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnOpenComparison;
        private System.Windows.Forms.Button btnTopPerformer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnRemovePlayer;

    }
}
