namespace Programming_Project_V5
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtEmpFirst = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmpFirst
            // 
            this.txtEmpFirst.Location = new System.Drawing.Point(130, 125);
            this.txtEmpFirst.MaxLength = 16;
            this.txtEmpFirst.Name = "txtEmpFirst";
            this.txtEmpFirst.Size = new System.Drawing.Size(255, 23);
            this.txtEmpFirst.TabIndex = 0;
            this.txtEmpFirst.Text = "Employee Firstname";
            this.txtEmpFirst.Click += new System.EventHandler(this.txtEmpFirst_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(130, 180);
            this.txtEmpID.MaxLength = 6;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(255, 23);
            this.txtEmpID.TabIndex = 1;
            this.txtEmpID.Text = "Employee ID";
            this.txtEmpID.Click += new System.EventHandler(this.txtEmpID_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(222, 209);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(159, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(195, 96);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(523, 270);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtEmpFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmpFirst;
        private TextBox txtEmpID;
        private Button btnLogin;
        private Label lblLogin;
    }
}