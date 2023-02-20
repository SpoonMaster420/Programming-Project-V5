namespace Programming_Project_V5
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserLoggedIn = new System.Windows.Forms.Label();
            this.lblDateandTime = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnLoans = new System.Windows.Forms.Button();
            this.preferencesToolStripMenuitem = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.preferencesToolStripMenuitem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Location = new System.Drawing.Point(12, 415);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 25);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserLoggedIn
            // 
            this.lblUserLoggedIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUserLoggedIn.Location = new System.Drawing.Point(119, 415);
            this.lblUserLoggedIn.Name = "lblUserLoggedIn";
            this.lblUserLoggedIn.Size = new System.Drawing.Size(184, 19);
            this.lblUserLoggedIn.TabIndex = 1;
            this.lblUserLoggedIn.Text = "name";
            // 
            // lblDateandTime
            // 
            this.lblDateandTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDateandTime.Location = new System.Drawing.Point(309, 415);
            this.lblDateandTime.Name = "lblDateandTime";
            this.lblDateandTime.Size = new System.Drawing.Size(185, 19);
            this.lblDateandTime.TabIndex = 2;
            this.lblDateandTime.Text = "date";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(119, 139);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(100, 80);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnLoans
            // 
            this.btnLoans.Location = new System.Drawing.Point(565, 139);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(100, 80);
            this.btnLoans.TabIndex = 4;
            this.btnLoans.Text = "Loans";
            this.btnLoans.UseVisualStyleBackColor = true;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // preferencesToolStripMenuitem
            // 
            this.preferencesToolStripMenuitem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.preferencesToolStripMenuitem.Location = new System.Drawing.Point(0, 0);
            this.preferencesToolStripMenuitem.Name = "preferencesToolStripMenuitem";
            this.preferencesToolStripMenuitem.Size = new System.Drawing.Size(800, 25);
            this.preferencesToolStripMenuitem.TabIndex = 6;
            this.preferencesToolStripMenuitem.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton1.Text = "Font Settings";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(157, 22);
            this.toolStripButton2.Text = "Foreground Colour Settings";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(159, 22);
            this.toolStripButton3.Text = "Background Colour Settings";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.preferencesToolStripMenuitem);
            this.Controls.Add(this.btnLoans);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.lblDateandTime);
            this.Controls.Add(this.lblUserLoggedIn);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "Main Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.preferencesToolStripMenuitem.ResumeLayout(false);
            this.preferencesToolStripMenuitem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogout;
        private Label lblUserLoggedIn;
        private Label lblDateandTime;
        private Button btnCustomer;
        private Button btnLoans;
        private ToolStrip preferencesToolStripMenuitem;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ColorDialog colorDialog1;
    }
}