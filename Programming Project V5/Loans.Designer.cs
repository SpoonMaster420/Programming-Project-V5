namespace Programming_Project_V5
{
    partial class Loans
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
            this.rbtnRentToCust = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbAvailableGames = new System.Windows.Forms.ListBox();
            this.lbRentedGames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rbtnRentToCust
            // 
            this.rbtnRentToCust.AutoSize = true;
            this.rbtnRentToCust.Location = new System.Drawing.Point(43, 55);
            this.rbtnRentToCust.Name = "rbtnRentToCust";
            this.rbtnRentToCust.Size = new System.Drawing.Size(162, 19);
            this.rbtnRentToCust.TabIndex = 0;
            this.rbtnRentToCust.TabStop = true;
            this.rbtnRentToCust.Text = "Rent Games to Customers";
            this.rbtnRentToCust.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(248, 431);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(329, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(410, 431);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 35);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(491, 431);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 35);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lbAvailableGames
            // 
            this.lbAvailableGames.FormattingEnabled = true;
            this.lbAvailableGames.ItemHeight = 15;
            this.lbAvailableGames.Location = new System.Drawing.Point(12, 121);
            this.lbAvailableGames.Name = "lbAvailableGames";
            this.lbAvailableGames.Size = new System.Drawing.Size(252, 304);
            this.lbAvailableGames.TabIndex = 7;
            // 
            // lbRentedGames
            // 
            this.lbRentedGames.FormattingEnabled = true;
            this.lbRentedGames.ItemHeight = 15;
            this.lbRentedGames.Location = new System.Drawing.Point(570, 121);
            this.lbRentedGames.Name = "lbRentedGames";
            this.lbRentedGames.Size = new System.Drawing.Size(252, 304);
            this.lbRentedGames.TabIndex = 8;
            // 
            // Loans
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(834, 501);
            this.Controls.Add(this.lbRentedGames);
            this.Controls.Add(this.lbAvailableGames);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbtnRentToCust);
            this.Name = "Loans";
            this.Text = "Loans";
            this.Load += new System.EventHandler(this.Loans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbtnRentToCust;
        private Button btnBack;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnNext;
        private ListBox lbAvailableGames;
        private ListBox lbRentedGames;
    }
}