namespace Programming_Project_V5
{
    partial class Games
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblGameReleaseDate = new System.Windows.Forms.Label();
            this.lblGameStock = new System.Windows.Forms.Label();
            this.lblGameRating = new System.Windows.Forms.Label();
            this.lblGamePlatform = new System.Windows.Forms.Label();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.txtGameReleaseDate = new System.Windows.Forms.TextBox();
            this.txtGameStock = new System.Windows.Forms.TextBox();
            this.txtGameRating = new System.Windows.Forms.TextBox();
            this.txtGamePlatform = new System.Windows.Forms.TextBox();
            this.btnSaveGameDetails = new System.Windows.Forms.Button();
            this.CmBxGameID = new System.Windows.Forms.ComboBox();
            this.txtSelectedGameID = new System.Windows.Forms.TextBox();
            this.txtSelectedGameName = new System.Windows.Forms.TextBox();
            this.txtSelectedGameReleaseDate = new System.Windows.Forms.TextBox();
            this.txtSelectedGameStock = new System.Windows.Forms.TextBox();
            this.txtSelectedGameRating = new System.Windows.Forms.TextBox();
            this.txtSelectedGamePlatform = new System.Windows.Forms.TextBox();
            this.txtGameRentPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedGameRentPrice = new System.Windows.Forms.TextBox();
            this.lblExistGame = new System.Windows.Forms.Label();
            this.lblNewGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(501, 65);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(73, 15);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Game Name";
            // 
            // lblGameReleaseDate
            // 
            this.lblGameReleaseDate.AutoSize = true;
            this.lblGameReleaseDate.Location = new System.Drawing.Point(467, 94);
            this.lblGameReleaseDate.Name = "lblGameReleaseDate";
            this.lblGameReleaseDate.Size = new System.Drawing.Size(107, 15);
            this.lblGameReleaseDate.TabIndex = 1;
            this.lblGameReleaseDate.Text = "Game Release Date";
            // 
            // lblGameStock
            // 
            this.lblGameStock.AutoSize = true;
            this.lblGameStock.Location = new System.Drawing.Point(504, 122);
            this.lblGameStock.Name = "lblGameStock";
            this.lblGameStock.Size = new System.Drawing.Size(70, 15);
            this.lblGameStock.TabIndex = 2;
            this.lblGameStock.Text = "Game Stock";
            // 
            // lblGameRating
            // 
            this.lblGameRating.AutoSize = true;
            this.lblGameRating.Location = new System.Drawing.Point(499, 151);
            this.lblGameRating.Name = "lblGameRating";
            this.lblGameRating.Size = new System.Drawing.Size(75, 15);
            this.lblGameRating.TabIndex = 3;
            this.lblGameRating.Text = "Game Rating";
            // 
            // lblGamePlatform
            // 
            this.lblGamePlatform.AutoSize = true;
            this.lblGamePlatform.Location = new System.Drawing.Point(487, 180);
            this.lblGamePlatform.Name = "lblGamePlatform";
            this.lblGamePlatform.Size = new System.Drawing.Size(87, 15);
            this.lblGamePlatform.TabIndex = 4;
            this.lblGamePlatform.Text = "Game Platform";
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(580, 62);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(208, 23);
            this.txtGameName.TabIndex = 5;
            // 
            // txtGameReleaseDate
            // 
            this.txtGameReleaseDate.Location = new System.Drawing.Point(580, 90);
            this.txtGameReleaseDate.Name = "txtGameReleaseDate";
            this.txtGameReleaseDate.Size = new System.Drawing.Size(208, 23);
            this.txtGameReleaseDate.TabIndex = 6;
            // 
            // txtGameStock
            // 
            this.txtGameStock.Location = new System.Drawing.Point(580, 119);
            this.txtGameStock.Name = "txtGameStock";
            this.txtGameStock.Size = new System.Drawing.Size(208, 23);
            this.txtGameStock.TabIndex = 7;
            // 
            // txtGameRating
            // 
            this.txtGameRating.Location = new System.Drawing.Point(580, 148);
            this.txtGameRating.Name = "txtGameRating";
            this.txtGameRating.Size = new System.Drawing.Size(208, 23);
            this.txtGameRating.TabIndex = 8;
            // 
            // txtGamePlatform
            // 
            this.txtGamePlatform.Location = new System.Drawing.Point(580, 177);
            this.txtGamePlatform.Name = "txtGamePlatform";
            this.txtGamePlatform.Size = new System.Drawing.Size(208, 23);
            this.txtGamePlatform.TabIndex = 9;
            // 
            // btnSaveGameDetails
            // 
            this.btnSaveGameDetails.Location = new System.Drawing.Point(580, 235);
            this.btnSaveGameDetails.Name = "btnSaveGameDetails";
            this.btnSaveGameDetails.Size = new System.Drawing.Size(208, 42);
            this.btnSaveGameDetails.TabIndex = 10;
            this.btnSaveGameDetails.Text = "Save Game Details";
            this.btnSaveGameDetails.UseVisualStyleBackColor = true;
            this.btnSaveGameDetails.Click += new System.EventHandler(this.btnSaveGameDetails_Click);
            // 
            // CmBxGameID
            // 
            this.CmBxGameID.FormattingEnabled = true;
            this.CmBxGameID.Location = new System.Drawing.Point(33, 61);
            this.CmBxGameID.Name = "CmBxGameID";
            this.CmBxGameID.Size = new System.Drawing.Size(236, 23);
            this.CmBxGameID.TabIndex = 11;
            this.CmBxGameID.SelectedIndexChanged += new System.EventHandler(this.CmBxGameID_SelectedIndexChanged);
            // 
            // txtSelectedGameID
            // 
            this.txtSelectedGameID.Location = new System.Drawing.Point(33, 90);
            this.txtSelectedGameID.Name = "txtSelectedGameID";
            this.txtSelectedGameID.ReadOnly = true;
            this.txtSelectedGameID.Size = new System.Drawing.Size(236, 23);
            this.txtSelectedGameID.TabIndex = 12;
            // 
            // txtSelectedGameName
            // 
            this.txtSelectedGameName.Location = new System.Drawing.Point(33, 119);
            this.txtSelectedGameName.Name = "txtSelectedGameName";
            this.txtSelectedGameName.ReadOnly = true;
            this.txtSelectedGameName.Size = new System.Drawing.Size(236, 23);
            this.txtSelectedGameName.TabIndex = 13;
            // 
            // txtSelectedGameReleaseDate
            // 
            this.txtSelectedGameReleaseDate.Location = new System.Drawing.Point(33, 148);
            this.txtSelectedGameReleaseDate.Name = "txtSelectedGameReleaseDate";
            this.txtSelectedGameReleaseDate.ReadOnly = true;
            this.txtSelectedGameReleaseDate.Size = new System.Drawing.Size(236, 23);
            this.txtSelectedGameReleaseDate.TabIndex = 14;
            // 
            // txtSelectedGameStock
            // 
            this.txtSelectedGameStock.Location = new System.Drawing.Point(33, 177);
            this.txtSelectedGameStock.Name = "txtSelectedGameStock";
            this.txtSelectedGameStock.ReadOnly = true;
            this.txtSelectedGameStock.Size = new System.Drawing.Size(236, 23);
            this.txtSelectedGameStock.TabIndex = 15;
            // 
            // txtSelectedGameRating
            // 
            this.txtSelectedGameRating.Location = new System.Drawing.Point(33, 206);
            this.txtSelectedGameRating.Name = "txtSelectedGameRating";
            this.txtSelectedGameRating.ReadOnly = true;
            this.txtSelectedGameRating.Size = new System.Drawing.Size(236, 23);
            this.txtSelectedGameRating.TabIndex = 16;
            // 
            // txtSelectedGamePlatform
            // 
            this.txtSelectedGamePlatform.Location = new System.Drawing.Point(33, 235);
            this.txtSelectedGamePlatform.Name = "txtSelectedGamePlatform";
            this.txtSelectedGamePlatform.ReadOnly = true;
            this.txtSelectedGamePlatform.Size = new System.Drawing.Size(236, 23);
            this.txtSelectedGamePlatform.TabIndex = 17;
            // 
            // txtGameRentPrice
            // 
            this.txtGameRentPrice.Location = new System.Drawing.Point(580, 206);
            this.txtGameRentPrice.Name = "txtGameRentPrice";
            this.txtGameRentPrice.Size = new System.Drawing.Size(208, 23);
            this.txtGameRentPrice.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Game Rent Price";
            // 
            // txtSelectedGameRentPrice
            // 
            this.txtSelectedGameRentPrice.Location = new System.Drawing.Point(33, 264);
            this.txtSelectedGameRentPrice.Name = "txtSelectedGameRentPrice";
            this.txtSelectedGameRentPrice.ReadOnly = true;
            this.txtSelectedGameRentPrice.Size = new System.Drawing.Size(236, 23);
            this.txtSelectedGameRentPrice.TabIndex = 20;
            // 
            // lblExistGame
            // 
            this.lblExistGame.AutoSize = true;
            this.lblExistGame.Location = new System.Drawing.Point(96, 43);
            this.lblExistGame.Name = "lblExistGame";
            this.lblExistGame.Size = new System.Drawing.Size(124, 15);
            this.lblExistGame.TabIndex = 21;
            this.lblExistGame.Text = "Find an Existing Game";
            // 
            // lblNewGame
            // 
            this.lblNewGame.AutoSize = true;
            this.lblNewGame.Location = new System.Drawing.Point(599, 43);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(180, 15);
            this.lblNewGame.TabIndex = 22;
            this.lblNewGame.Text = "Add a new game to the database";
            // 
            // Games
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNewGame);
            this.Controls.Add(this.lblExistGame);
            this.Controls.Add(this.txtSelectedGameRentPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGameRentPrice);
            this.Controls.Add(this.txtSelectedGamePlatform);
            this.Controls.Add(this.txtSelectedGameRating);
            this.Controls.Add(this.txtSelectedGameStock);
            this.Controls.Add(this.txtSelectedGameReleaseDate);
            this.Controls.Add(this.txtSelectedGameName);
            this.Controls.Add(this.txtSelectedGameID);
            this.Controls.Add(this.CmBxGameID);
            this.Controls.Add(this.btnSaveGameDetails);
            this.Controls.Add(this.txtGamePlatform);
            this.Controls.Add(this.txtGameRating);
            this.Controls.Add(this.txtGameStock);
            this.Controls.Add(this.txtGameReleaseDate);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.lblGamePlatform);
            this.Controls.Add(this.lblGameRating);
            this.Controls.Add(this.lblGameStock);
            this.Controls.Add(this.lblGameReleaseDate);
            this.Controls.Add(this.lblGameName);
            this.Name = "Games";
            this.Text = "Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGameName;
        private Label lblGameReleaseDate;
        private Label lblGameStock;
        private Label lblGameRating;
        private Label lblGamePlatform;
        private TextBox txtGameName;
        private TextBox txtGameReleaseDate;
        private TextBox txtGameStock;
        private TextBox txtGameRating;
        private TextBox txtGamePlatform;
        private Button btnSaveGameDetails;
        private ComboBox CmBxGameID;
        private TextBox txtSelectedGameID;
        private TextBox txtSelectedGameName;
        private TextBox txtSelectedGameReleaseDate;
        private TextBox txtSelectedGameStock;
        private TextBox txtSelectedGameRating;
        private TextBox txtSelectedGamePlatform;
        private TextBox txtGameRentPrice;
        private Label label1;
        private TextBox txtSelectedGameRentPrice;
        private Label lblExistGame;
        private Label lblNewGame;
    }
}