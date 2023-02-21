namespace Programming_Project_V5
{
    partial class Customers
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
            this.txtCustFirst = new System.Windows.Forms.TextBox();
            this.txtCustLast = new System.Windows.Forms.TextBox();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.lblCustFirst = new System.Windows.Forms.Label();
            this.lblCustLast = new System.Windows.Forms.Label();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.CmBxCustID = new System.Windows.Forms.ComboBox();
            this.txtSelectedID = new System.Windows.Forms.TextBox();
            this.txtSelectedFirst = new System.Windows.Forms.TextBox();
            this.txtSelectedLast = new System.Windows.Forms.TextBox();
            this.txtSelectedEmail = new System.Windows.Forms.TextBox();
            this.txtSelectedPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCustFirst
            // 
            this.txtCustFirst.Location = new System.Drawing.Point(580, 56);
            this.txtCustFirst.Multiline = true;
            this.txtCustFirst.Name = "txtCustFirst";
            this.txtCustFirst.Size = new System.Drawing.Size(208, 41);
            this.txtCustFirst.TabIndex = 0;
            // 
            // txtCustLast
            // 
            this.txtCustLast.Location = new System.Drawing.Point(580, 103);
            this.txtCustLast.Multiline = true;
            this.txtCustLast.Name = "txtCustLast";
            this.txtCustLast.Size = new System.Drawing.Size(208, 41);
            this.txtCustLast.TabIndex = 1;
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(580, 150);
            this.txtCustEmail.Multiline = true;
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(208, 41);
            this.txtCustEmail.TabIndex = 2;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(580, 197);
            this.txtCustPhone.Multiline = true;
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(208, 41);
            this.txtCustPhone.TabIndex = 3;
            // 
            // lblCustFirst
            // 
            this.lblCustFirst.AutoSize = true;
            this.lblCustFirst.Location = new System.Drawing.Point(431, 71);
            this.lblCustFirst.Name = "lblCustFirst";
            this.lblCustFirst.Size = new System.Drawing.Size(114, 15);
            this.lblCustFirst.TabIndex = 4;
            this.lblCustFirst.Text = "Customer Firstname";
            // 
            // lblCustLast
            // 
            this.lblCustLast.AutoSize = true;
            this.lblCustLast.Location = new System.Drawing.Point(431, 117);
            this.lblCustLast.Name = "lblCustLast";
            this.lblCustLast.Size = new System.Drawing.Size(113, 15);
            this.lblCustLast.TabIndex = 5;
            this.lblCustLast.Text = "Customer Lastname";
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.Location = new System.Drawing.Point(431, 164);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(91, 15);
            this.lblCustEmail.TabIndex = 6;
            this.lblCustEmail.Text = "Customer Email";
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(431, 211);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(143, 15);
            this.lblCustPhone.TabIndex = 7;
            this.lblCustPhone.Text = "Customer Phone Number";
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.Location = new System.Drawing.Point(679, 258);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(109, 23);
            this.btnSaveDetails.TabIndex = 8;
            this.btnSaveDetails.Text = "Save Details";
            this.btnSaveDetails.UseVisualStyleBackColor = true;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // CmBxCustID
            // 
            this.CmBxCustID.FormattingEnabled = true;
            this.CmBxCustID.Location = new System.Drawing.Point(45, 41);
            this.CmBxCustID.Name = "CmBxCustID";
            this.CmBxCustID.Size = new System.Drawing.Size(208, 23);
            this.CmBxCustID.TabIndex = 9;
            this.CmBxCustID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSelectedID
            // 
            this.txtSelectedID.Location = new System.Drawing.Point(45, 71);
            this.txtSelectedID.Multiline = true;
            this.txtSelectedID.Name = "txtSelectedID";
            this.txtSelectedID.Size = new System.Drawing.Size(208, 41);
            this.txtSelectedID.TabIndex = 10;
            // 
            // txtSelectedFirst
            // 
            this.txtSelectedFirst.Location = new System.Drawing.Point(45, 118);
            this.txtSelectedFirst.Multiline = true;
            this.txtSelectedFirst.Name = "txtSelectedFirst";
            this.txtSelectedFirst.Size = new System.Drawing.Size(208, 41);
            this.txtSelectedFirst.TabIndex = 11;
            // 
            // txtSelectedLast
            // 
            this.txtSelectedLast.Location = new System.Drawing.Point(45, 165);
            this.txtSelectedLast.Multiline = true;
            this.txtSelectedLast.Name = "txtSelectedLast";
            this.txtSelectedLast.Size = new System.Drawing.Size(208, 41);
            this.txtSelectedLast.TabIndex = 12;
            // 
            // txtSelectedEmail
            // 
            this.txtSelectedEmail.Location = new System.Drawing.Point(45, 212);
            this.txtSelectedEmail.Multiline = true;
            this.txtSelectedEmail.Name = "txtSelectedEmail";
            this.txtSelectedEmail.Size = new System.Drawing.Size(208, 41);
            this.txtSelectedEmail.TabIndex = 13;
            // 
            // txtSelectedPhone
            // 
            this.txtSelectedPhone.Location = new System.Drawing.Point(45, 259);
            this.txtSelectedPhone.Multiline = true;
            this.txtSelectedPhone.Name = "txtSelectedPhone";
            this.txtSelectedPhone.Size = new System.Drawing.Size(208, 41);
            this.txtSelectedPhone.TabIndex = 14;
            // 
            // Customers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSelectedPhone);
            this.Controls.Add(this.txtSelectedEmail);
            this.Controls.Add(this.txtSelectedLast);
            this.Controls.Add(this.txtSelectedFirst);
            this.Controls.Add(this.txtSelectedID);
            this.Controls.Add(this.CmBxCustID);
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(this.lblCustPhone);
            this.Controls.Add(this.lblCustEmail);
            this.Controls.Add(this.lblCustLast);
            this.Controls.Add(this.lblCustFirst);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustEmail);
            this.Controls.Add(this.txtCustLast);
            this.Controls.Add(this.txtCustFirst);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCustFirst;
        private TextBox txtCustLast;
        private TextBox txtCustEmail;
        private TextBox txtCustPhone;
        private Label lblCustFirst;
        private Label lblCustLast;
        private Label lblCustEmail;
        private Label lblCustPhone;
        private Button btnSaveDetails;
        private ComboBox CmBxCustID;
        private TextBox txtSelectedID;
        private TextBox txtSelectedFirst;
        private TextBox txtSelectedLast;
        private TextBox txtSelectedEmail;
        private TextBox txtSelectedPhone;
    }
}