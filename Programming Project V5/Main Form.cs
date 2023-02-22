using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Programming_Project_V5
{
    public partial class Main_Form : Form
    {
        private Settings settings;
        private System.Windows.Forms.Timer timer;
        public Main_Form()
        {
            InitializeComponent();
            updateUserNameLabel();

            this.settings = SettingsManager.GetSettings();

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
            string name = UserSession.EmployeeName;

            lblUserLoggedIn.Text = "Logged in as: " + name;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                

                //Font font = fontDialog.Font;
                //Color color = fontDialog.Color;

                //Settings options = new Settings();

                this.settings.font = fontDialog.Font;

                this.Font = this.settings.font;
                preferencesToolStripMenuitem.Font = this.settings.font;

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.AnyColor = true;
            

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                //Settings options = new Settings();

                this.settings.fcolor = colorDialog.Color;

                
                this.ForeColor = this.settings.fcolor;
                preferencesToolStripMenuitem.ForeColor = this.settings.fcolor;
                btnCustomer.ForeColor = this.settings.fcolor;
                btnLoans.ForeColor = this.settings.fcolor;
                btnGames.ForeColor = this.settings.fcolor;
                btnLogout.ForeColor = this.settings.fcolor;

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                //Settings options = new Settings();

                this.settings.bcolor = colorDialog.Color;
                
                this.BackColor = this.settings.bcolor;
                preferencesToolStripMenuitem.BackColor = this.settings.bcolor;
                btnCustomer.BackColor = this.settings.bcolor;
                btnLoans.BackColor = this.settings.bcolor;
                btnGames.BackColor = this.settings.bcolor;
                btnLogout.BackColor = this.settings.bcolor;
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers();
            cust.Show();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            Loans loans = new Loans();
            loans.Show();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.Show();
        }
    }

    }

