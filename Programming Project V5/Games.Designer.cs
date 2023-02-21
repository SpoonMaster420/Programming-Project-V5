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
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(522, 40);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(73, 15);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Game Name";
            // 
            // lblGameReleaseDate
            // 
            this.lblGameReleaseDate.AutoSize = true;
            this.lblGameReleaseDate.Location = new System.Drawing.Point(488, 69);
            this.lblGameReleaseDate.Name = "lblGameReleaseDate";
            this.lblGameReleaseDate.Size = new System.Drawing.Size(107, 15);
            this.lblGameReleaseDate.TabIndex = 1;
            this.lblGameReleaseDate.Text = "Game Release Date";
            // 
            // lblGameStock
            // 
            this.lblGameStock.AutoSize = true;
            this.lblGameStock.Location = new System.Drawing.Point(525, 97);
            this.lblGameStock.Name = "lblGameStock";
            this.lblGameStock.Size = new System.Drawing.Size(70, 15);
            this.lblGameStock.TabIndex = 2;
            this.lblGameStock.Text = "Game Stock";
            // 
            // lblGameRating
            // 
            this.lblGameRating.AutoSize = true;
            this.lblGameRating.Location = new System.Drawing.Point(520, 126);
            this.lblGameRating.Name = "lblGameRating";
            this.lblGameRating.Size = new System.Drawing.Size(75, 15);
            this.lblGameRating.TabIndex = 3;
            this.lblGameRating.Text = "Game Rating";
            // 
            // lblGamePlatform
            // 
            this.lblGamePlatform.AutoSize = true;
            this.lblGamePlatform.Location = new System.Drawing.Point(508, 155);
            this.lblGamePlatform.Name = "lblGamePlatform";
            this.lblGamePlatform.Size = new System.Drawing.Size(87, 15);
            this.lblGamePlatform.TabIndex = 4;
            this.lblGamePlatform.Text = "Game Platform";
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(601, 32);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(187, 23);
            this.txtGameName.TabIndex = 5;
            // 
            // txtGameReleaseDate
            // 
            this.txtGameReleaseDate.Location = new System.Drawing.Point(601, 61);
            this.txtGameReleaseDate.Name = "txtGameReleaseDate";
            this.txtGameReleaseDate.Size = new System.Drawing.Size(187, 23);
            this.txtGameReleaseDate.TabIndex = 6;
            // 
            // txtGameStock
            // 
            this.txtGameStock.Location = new System.Drawing.Point(601, 94);
            this.txtGameStock.Name = "txtGameStock";
            this.txtGameStock.Size = new System.Drawing.Size(187, 23);
            this.txtGameStock.TabIndex = 7;
            // 
            // txtGameRating
            // 
            this.txtGameRating.Location = new System.Drawing.Point(601, 123);
            this.txtGameRating.Name = "txtGameRating";
            this.txtGameRating.Size = new System.Drawing.Size(187, 23);
            this.txtGameRating.TabIndex = 8;
            // 
            // txtGamePlatform
            // 
            this.txtGamePlatform.Location = new System.Drawing.Point(601, 152);
            this.txtGamePlatform.Name = "txtGamePlatform";
            this.txtGamePlatform.Size = new System.Drawing.Size(187, 23);
            this.txtGamePlatform.TabIndex = 9;
            // 
            // btnSaveGameDetails
            // 
            this.btnSaveGameDetails.Location = new System.Drawing.Point(601, 181);
            this.btnSaveGameDetails.Name = "btnSaveGameDetails";
            this.btnSaveGameDetails.Size = new System.Drawing.Size(187, 42);
            this.btnSaveGameDetails.TabIndex = 10;
            this.btnSaveGameDetails.Text = "Save Game Details";
            this.btnSaveGameDetails.UseVisualStyleBackColor = true;
            this.btnSaveGameDetails.Click += new System.EventHandler(this.btnSaveGameDetails_Click);
            // 
            // Games
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}