namespace TradingCards
{
    partial class AddPlayer
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
            txtName = new TextBox();
            txtTeam = new TextBox();
            txtPoints = new TextBox();
            txtAssists = new TextBox();
            txtRebounds = new TextBox();
            txtMatches = new TextBox();
            btnAdd = new Button();
            txtImage = new TextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(69, 30);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Player Name";
            txtName.Size = new Size(200, 31);
            txtName.TabIndex = 0;
            // 
            // txtTeam
            // 
            txtTeam.Location = new Point(69, 67);
            txtTeam.Name = "txtTeam";
            txtTeam.PlaceholderText = "Team";
            txtTeam.Size = new Size(200, 31);
            txtTeam.TabIndex = 1;
            // 
            // txtPoints
            // 
            txtPoints.Location = new Point(69, 107);
            txtPoints.Name = "txtPoints";
            txtPoints.PlaceholderText = "Goals";
            txtPoints.Size = new Size(200, 31);
            txtPoints.TabIndex = 2;
            // 
            // txtAssists
            // 
            txtAssists.Location = new Point(69, 150);
            txtAssists.Name = "txtAssists";
            txtAssists.PlaceholderText = "Assists";
            txtAssists.Size = new Size(200, 31);
            txtAssists.TabIndex = 3;
            // 
            // txtRebounds
            // 
            txtRebounds.Location = new Point(69, 187);
            txtRebounds.Name = "txtRebounds";
            txtRebounds.PlaceholderText = "Clean Sheets";
            txtRebounds.Size = new Size(200, 31);
            txtRebounds.TabIndex = 4;
            // 
            // txtMatches
            // 
            txtMatches.Location = new Point(69, 227);
            txtMatches.Name = "txtMatches";
            txtMatches.PlaceholderText = "Matches";
            txtMatches.Size = new Size(200, 31);
            txtMatches.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(107, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(69, 267);
            txtImage.Name = "txtImage";
            txtImage.PlaceholderText = "Image ";
            txtImage.Size = new Size(200, 31);
            txtImage.TabIndex = 7;
            // 
            // AddPlayer
            // 
            ClientSize = new Size(327, 382);
            Controls.Add(txtImage);
            Controls.Add(btnAdd);
            Controls.Add(txtMatches);
            Controls.Add(txtRebounds);
            Controls.Add(txtAssists);
            Controls.Add(txtPoints);
            Controls.Add(txtTeam);
            Controls.Add(txtName);
            Name = "AddPlayer";
            Text = "Add Player";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TextBox txtAssists;
        private System.Windows.Forms.TextBox txtRebounds;
        private System.Windows.Forms.TextBox txtMatches;
        private System.Windows.Forms.Button btnAdd;
        private TextBox txtImage;
    }
}
