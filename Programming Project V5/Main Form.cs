using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Programming_Project_V5
{
    public partial class Main_Form : Form
    {
        private System.Windows.Forms.Timer timer;
        public Main_Form()
        {
            InitializeComponent();
            updateUserNameLabel();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDateandTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); 
            }



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();    
            login.Show();  
        }

        private void updateUserNameLabel()
        {
            string name = UserSession.CurrentUser;

            lblUserLoggedIn.Text = "Logged in as: " + name;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font font = fontDialog.Font;
                Color color = fontDialog.Color;

                this.Font = font;
                this.ForeColor = color;

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.AnyColor = true;
            

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnCustomer.ForeColor = colorDialog.Color;
                btnLoans.ForeColor = colorDialog.Color;
                btnLogout.ForeColor = colorDialog.Color;
                lblDateandTime.ForeColor = colorDialog.Color;
                lblUserLoggedIn.ForeColor = colorDialog.Color;
                preferencesToolStripMenuitem.ForeColor = colorDialog.Color;

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnCustomer.BackColor = colorDialog.Color;
                btnLoans.BackColor = colorDialog.Color;
                btnLogout.BackColor = colorDialog.Color;
                lblDateandTime.BackColor = colorDialog.Color;
                lblUserLoggedIn.BackColor = colorDialog.Color;
                this.BackColor = colorDialog.Color;
                preferencesToolStripMenuitem.BackColor = colorDialog.Color;
            }
        }
    }

    }

