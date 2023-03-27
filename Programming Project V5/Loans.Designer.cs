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
            this.tabSelectGames = new System.Windows.Forms.TabPage();
            this.btnNextPg1 = new System.Windows.Forms.Button();
            this.tabSelectCustomer = new System.Windows.Forms.TabPage();
            this.btnNextPg2 = new System.Windows.Forms.Button();
            this.btnBackPg2 = new System.Windows.Forms.Button();
            this.lbCustomers = new System.Windows.Forms.ListBox();
            this.tabRentalSummary = new System.Windows.Forms.TabPage();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackPg3 = new System.Windows.Forms.Button();
            this.btnSaveRental = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lbRentalSummary = new System.Windows.Forms.ListBox();
            this.tabOngoingRentals = new System.Windows.Forms.TabPage();
            this.dgvOngoingRentals = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabSelectGames.SuspendLayout();
            this.tabSelectCustomer.SuspendLayout();
            this.tabRentalSummary.SuspendLayout();
            this.tabOngoingRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOngoingRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackPg1
            // 
            this.btnBackPg1.Location = new System.Drawing.Point(8, 511);
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
            this.btnRemove.Location = new System.Drawing.Point(506, 275);
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
            this.lbAvailableGames.Size = new System.Drawing.Size(318, 304);
            this.lbAvailableGames.TabIndex = 7;
            // 
            // lbRentedGames
            // 
            this.lbRentedGames.FormattingEnabled = true;
            this.lbRentedGames.ItemHeight = 15;
            this.lbRentedGames.Location = new System.Drawing.Point(587, 6);
            this.lbRentedGames.Name = "lbRentedGames";
            this.lbRentedGames.Size = new System.Drawing.Size(330, 304);
            this.lbRentedGames.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSelectGames);
            this.tabControl1.Controls.Add(this.tabSelectCustomer);
            this.tabControl1.Controls.Add(this.tabRentalSummary);
            this.tabControl1.Controls.Add(this.tabOngoingRentals);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 582);
            this.tabControl1.TabIndex = 9;
            // 
            // tabSelectGames
            // 
            this.tabSelectGames.Controls.Add(this.btnNextPg1);
            this.tabSelectGames.Controls.Add(this.lbAvailableGames);
            this.tabSelectGames.Controls.Add(this.lbRentedGames);
            this.tabSelectGames.Controls.Add(this.btnRemove);
            this.tabSelectGames.Controls.Add(this.btnBackPg1);
            this.tabSelectGames.Controls.Add(this.btnAdd);
            this.tabSelectGames.Location = new System.Drawing.Point(4, 24);
            this.tabSelectGames.Name = "tabSelectGames";
            this.tabSelectGames.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectGames.Size = new System.Drawing.Size(925, 554);
            this.tabSelectGames.TabIndex = 0;
            this.tabSelectGames.Text = "Select Games";
            this.tabSelectGames.UseVisualStyleBackColor = true;
            // 
            // btnNextPg1
            // 
            this.btnNextPg1.Location = new System.Drawing.Point(847, 511);
            this.btnNextPg1.Name = "btnNextPg1";
            this.btnNextPg1.Size = new System.Drawing.Size(75, 35);
            this.btnNextPg1.TabIndex = 9;
            this.btnNextPg1.Text = "Next >";
            this.btnNextPg1.UseVisualStyleBackColor = true;
            this.btnNextPg1.Click += new System.EventHandler(this.btnNextPg1_Click);
            // 
            // tabSelectCustomer
            // 
            this.tabSelectCustomer.Controls.Add(this.btnNextPg2);
            this.tabSelectCustomer.Controls.Add(this.btnBackPg2);
            this.tabSelectCustomer.Controls.Add(this.lbCustomers);
            this.tabSelectCustomer.Location = new System.Drawing.Point(4, 24);
            this.tabSelectCustomer.Name = "tabSelectCustomer";
            this.tabSelectCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectCustomer.Size = new System.Drawing.Size(925, 554);
            this.tabSelectCustomer.TabIndex = 1;
            this.tabSelectCustomer.Text = "Select Customer";
            this.tabSelectCustomer.UseVisualStyleBackColor = true;
            // 
            // btnNextPg2
            // 
            this.btnNextPg2.Location = new System.Drawing.Point(844, 511);
            this.btnNextPg2.Name = "btnNextPg2";
            this.btnNextPg2.Size = new System.Drawing.Size(75, 35);
            this.btnNextPg2.TabIndex = 7;
            this.btnNextPg2.Text = "Next >";
            this.btnNextPg2.UseVisualStyleBackColor = true;
            this.btnNextPg2.Click += new System.EventHandler(this.btnNextPg2_Click);
            // 
            // btnBackPg2
            // 
            this.btnBackPg2.Location = new System.Drawing.Point(8, 511);
            this.btnBackPg2.Name = "btnBackPg2";
            this.btnBackPg2.Size = new System.Drawing.Size(75, 35);
            this.btnBackPg2.TabIndex = 6;
            this.btnBackPg2.Text = "< Back";
            this.btnBackPg2.UseVisualStyleBackColor = true;
            this.btnBackPg2.Click += new System.EventHandler(this.btnBackPg2_Click);
            // 
            // lbCustomers
            // 
            this.lbCustomers.FormattingEnabled = true;
            this.lbCustomers.ItemHeight = 15;
            this.lbCustomers.Location = new System.Drawing.Point(92, 6);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(748, 499);
            this.lbCustomers.TabIndex = 0;
            this.lbCustomers.SelectedIndexChanged += new System.EventHandler(this.lbCustomers_SelectedIndexChanged);
            // 
            // tabRentalSummary
            // 
            this.tabRentalSummary.Controls.Add(this.txtCustomerID);
            this.tabRentalSummary.Controls.Add(this.txtCustomerName);
            this.tabRentalSummary.Controls.Add(this.label2);
            this.tabRentalSummary.Controls.Add(this.label1);
            this.tabRentalSummary.Controls.Add(this.btnBackPg3);
            this.tabRentalSummary.Controls.Add(this.btnSaveRental);
            this.tabRentalSummary.Controls.Add(this.txtTotalPrice);
            this.tabRentalSummary.Controls.Add(this.lbRentalSummary);
            this.tabRentalSummary.Location = new System.Drawing.Point(4, 24);
            this.tabRentalSummary.Name = "tabRentalSummary";
            this.tabRentalSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabRentalSummary.Size = new System.Drawing.Size(925, 554);
            this.tabRentalSummary.TabIndex = 2;
            this.tabRentalSummary.Text = "                                                                                 " +
    "                                                                   ";
            this.tabRentalSummary.UseVisualStyleBackColor = true;
            this.tabRentalSummary.Click += new System.EventHandler(this.tabRentalSummary_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(747, 98);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(172, 23);
            this.txtCustomerID.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(747, 44);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(172, 23);
            this.txtCustomerName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Name";
            // 
            // btnBackPg3
            // 
            this.btnBackPg3.Location = new System.Drawing.Point(8, 511);
            this.btnBackPg3.Name = "btnBackPg3";
            this.btnBackPg3.Size = new System.Drawing.Size(75, 35);
            this.btnBackPg3.TabIndex = 6;
            this.btnBackPg3.Text = "< Back";
            this.btnBackPg3.UseVisualStyleBackColor = true;
            this.btnBackPg3.Click += new System.EventHandler(this.btnBackPg3_Click);
            // 
            // btnSaveRental
            // 
            this.btnSaveRental.Location = new System.Drawing.Point(734, 521);
            this.btnSaveRental.Name = "btnSaveRental";
            this.btnSaveRental.Size = new System.Drawing.Size(183, 23);
            this.btnSaveRental.TabIndex = 2;
            this.btnSaveRental.Text = "Save and Start Rental";
            this.btnSaveRental.UseVisualStyleBackColor = true;
            this.btnSaveRental.Click += new System.EventHandler(this.btnSaveRental_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(734, 492);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(183, 23);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // lbRentalSummary
            // 
            this.lbRentalSummary.FormattingEnabled = true;
            this.lbRentalSummary.ItemHeight = 15;
            this.lbRentalSummary.Location = new System.Drawing.Point(8, 5);
            this.lbRentalSummary.Name = "lbRentalSummary";
            this.lbRentalSummary.Size = new System.Drawing.Size(566, 364);
            this.lbRentalSummary.TabIndex = 0;
            // 
            // tabOngoingRentals
            // 
            this.tabOngoingRentals.Controls.Add(this.dgvOngoingRentals);
            this.tabOngoingRentals.Location = new System.Drawing.Point(4, 24);
            this.tabOngoingRentals.Name = "tabOngoingRentals";
            this.tabOngoingRentals.Padding = new System.Windows.Forms.Padding(3);
            this.tabOngoingRentals.Size = new System.Drawing.Size(925, 554);
            this.tabOngoingRentals.TabIndex = 3;
            this.tabOngoingRentals.Text = "Ongoing Rentals";
            this.tabOngoingRentals.UseVisualStyleBackColor = true;
            // 
            // dgvOngoingRentals
            // 
            this.dgvOngoingRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOngoingRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOngoingRentals.Location = new System.Drawing.Point(3, 3);
            this.dgvOngoingRentals.Name = "dgvOngoingRentals";
            this.dgvOngoingRentals.ReadOnly = true;
            this.dgvOngoingRentals.RowTemplate.Height = 25;
            this.dgvOngoingRentals.Size = new System.Drawing.Size(919, 548);
            this.dgvOngoingRentals.TabIndex = 0;
            // 
            // Loans
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(933, 582);
            this.Controls.Add(this.tabControl1);
            this.Name = "Loans";
            this.Text = "Loans";
            this.Load += new System.EventHandler(this.Loans_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSelectGames.ResumeLayout(false);
            this.tabSelectCustomer.ResumeLayout(false);
            this.tabRentalSummary.ResumeLayout(false);
            this.tabRentalSummary.PerformLayout();
            this.tabOngoingRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOngoingRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnBackPg1;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox lbAvailableGames;
        private ListBox lbRentedGames;
        private TabControl tabControl1;
        private TabPage tabSelectGames;
        private TabPage tabSelectCustomer;
        private TabPage tabRentalSummary;
        private ListBox lbCustomers;
        private Button btnSaveRental;
        private TextBox txtTotalPrice;
        private ListBox lbRentalSummary;
        private Button btnNextPg1;
        private Button btnNextPg2;
        private Button btnBackPg2;
        private TextBox txtCustomerID;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label1;
        private Button btnBackPg3;
        private TabPage tabOngoingRentals;
        private DataGridView dgvOngoingRentals;
    }
}