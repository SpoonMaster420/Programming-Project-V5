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
            this.btnBackPg1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbAvailableGames = new System.Windows.Forms.ListBox();
            this.lbRentedGames = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbCustomers = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSaveRental = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbRentalSummary = new System.Windows.Forms.ListBox();
            this.btnNextPg1 = new System.Windows.Forms.Button();
            this.btnBackPg2 = new System.Windows.Forms.Button();
            this.btnNextPg2 = new System.Windows.Forms.Button();
            this.btnBackPg3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackPg1
            // 
            this.btnBackPg1.Location = new System.Drawing.Point(6, 408);
            this.btnBackPg1.Name = "btnBackPg1";
            this.btnBackPg1.Size = new System.Drawing.Size(75, 35);
            this.btnBackPg1.TabIndex = 3;
            this.btnBackPg1.Text = "< Back";
            this.btnBackPg1.UseVisualStyleBackColor = true;
            this.btnBackPg1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(411, 275);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 35);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbAvailableGames
            // 
            this.lbAvailableGames.FormattingEnabled = true;
            this.lbAvailableGames.ItemHeight = 15;
            this.lbAvailableGames.Location = new System.Drawing.Point(6, 6);
            this.lbAvailableGames.Name = "lbAvailableGames";
            this.lbAvailableGames.Size = new System.Drawing.Size(252, 304);
            this.lbAvailableGames.TabIndex = 7;
            // 
            // lbRentedGames
            // 
            this.lbRentedGames.FormattingEnabled = true;
            this.lbRentedGames.ItemHeight = 15;
            this.lbRentedGames.Location = new System.Drawing.Point(544, 6);
            this.lbRentedGames.Name = "lbRentedGames";
            this.lbRentedGames.Size = new System.Drawing.Size(252, 304);
            this.lbRentedGames.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 477);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNextPg1);
            this.tabPage1.Controls.Add(this.lbAvailableGames);
            this.tabPage1.Controls.Add(this.lbRentedGames);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.btnBackPg1);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Games";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnNextPg2);
            this.tabPage2.Controls.Add(this.btnBackPg2);
            this.tabPage2.Controls.Add(this.lbCustomers);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Select Customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbCustomers
            // 
            this.lbCustomers.FormattingEnabled = true;
            this.lbCustomers.ItemHeight = 15;
            this.lbCustomers.Location = new System.Drawing.Point(129, 6);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(574, 394);
            this.lbCustomers.TabIndex = 0;
            this.lbCustomers.SelectedIndexChanged += new System.EventHandler(this.lbCustomers_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtCustomerID);
            this.tabPage3.Controls.Add(this.txtCustomerName);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnBackPg3);
            this.tabPage3.Controls.Add(this.btnSaveRental);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.lbRentalSummary);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(802, 449);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rental Summary";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSaveRental
            // 
            this.btnSaveRental.Location = new System.Drawing.Point(613, 420);
            this.btnSaveRental.Name = "btnSaveRental";
            this.btnSaveRental.Size = new System.Drawing.Size(183, 23);
            this.btnSaveRental.TabIndex = 2;
            this.btnSaveRental.Text = "Save and Start Rental";
            this.btnSaveRental.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(685, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lbRentalSummary
            // 
            this.lbRentalSummary.FormattingEnabled = true;
            this.lbRentalSummary.ItemHeight = 15;
            this.lbRentalSummary.Location = new System.Drawing.Point(6, 6);
            this.lbRentalSummary.Name = "lbRentalSummary";
            this.lbRentalSummary.Size = new System.Drawing.Size(566, 364);
            this.lbRentalSummary.TabIndex = 0;
            // 
            // btnNextPg1
            // 
            this.btnNextPg1.Location = new System.Drawing.Point(721, 408);
            this.btnNextPg1.Name = "btnNextPg1";
            this.btnNextPg1.Size = new System.Drawing.Size(75, 35);
            this.btnNextPg1.TabIndex = 9;
            this.btnNextPg1.Text = "Next >";
            this.btnNextPg1.UseVisualStyleBackColor = true;
            // 
            // btnBackPg2
            // 
            this.btnBackPg2.Location = new System.Drawing.Point(6, 408);
            this.btnBackPg2.Name = "btnBackPg2";
            this.btnBackPg2.Size = new System.Drawing.Size(75, 35);
            this.btnBackPg2.TabIndex = 6;
            this.btnBackPg2.Text = "< Back";
            this.btnBackPg2.UseVisualStyleBackColor = true;
            // 
            // btnNextPg2
            // 
            this.btnNextPg2.Location = new System.Drawing.Point(721, 408);
            this.btnNextPg2.Name = "btnNextPg2";
            this.btnNextPg2.Size = new System.Drawing.Size(75, 35);
            this.btnNextPg2.TabIndex = 7;
            this.btnNextPg2.Text = "Next >";
            this.btnNextPg2.UseVisualStyleBackColor = true;
            // 
            // btnBackPg3
            // 
            this.btnBackPg3.Location = new System.Drawing.Point(6, 408);
            this.btnBackPg3.Name = "btnBackPg3";
            this.btnBackPg3.Size = new System.Drawing.Size(75, 35);
            this.btnBackPg3.TabIndex = 6;
            this.btnBackPg3.Text = "< Back";
            this.btnBackPg3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer ID";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(578, 37);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(172, 23);
            this.txtCustomerName.TabIndex = 9;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(578, 91);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(172, 23);
            this.txtCustomerID.TabIndex = 10;
            // 
            // Loans
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(834, 501);
            this.Controls.Add(this.tabControl1);
            this.Name = "Loans";
            this.Text = "Loans";
            this.Load += new System.EventHandler(this.Loans_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnBackPg1;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox lbAvailableGames;
        private ListBox lbRentedGames;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListBox lbCustomers;
        private Button btnSaveRental;
        private TextBox textBox1;
        private ListBox lbRentalSummary;
        private Button btnNextPg1;
        private Button btnNextPg2;
        private Button btnBackPg2;
        private TextBox txtCustomerID;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label1;
        private Button btnBackPg3;
    }
}