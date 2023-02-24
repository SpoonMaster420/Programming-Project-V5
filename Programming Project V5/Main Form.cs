using System;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Programming_Project_V5
{
    public partial class Main_Form : Form
    {
        //Declare private fields for settings and timer
        private Settings settings;
        private System.Windows.Forms.Timer timer;
        public Main_Form()
        {
            InitializeComponent();
            updateUserNameLabel();  //Updates the user Label with the currently logged in user 

            this.settings = SettingsManager.GetSettings();  //Retrieves settings from the settings manager 

            //Initialise and starts the timer for the time and date 
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; //One Second Interval
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDateandTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");  //Updates the date and time label with the current date and time every second
        }
        

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) //Checks to see if the user closed the Form
            {
                Application.Exit(); //Closes the application
            }



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();    
            login.Show();  //Creates a new login form and shows it while hiding this form
        }

        private void updateUserNameLabel()
        {
            string name = UserSession.EmployeeName;  //Takes the value stored in EmployeeName taken from the Login Screen 

            lblUserLoggedIn.Text = "Logged in as: " + name;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();  //Creates a font dialog box and updates the font settings based on the user's selection
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                

                //Font font = fontDialog.Font;
                //Color color = fontDialog.Color;

                //Settings options = new Settings();

                this.settings.font = fontDialog.Font;

                //Updates the font of this form and other UI elements
                this.Font = this.settings.font;
                preferencesToolStripMenuitem.Font = this.settings.font;

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Creates a color dialog and updates the foreground color settings based on what the user chooses 
            var colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.AnyColor = true;
            

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                //Settings options = new Settings();

                this.settings.fcolor = colorDialog.Color;

                //Updates the foreground color of the main form and other UI elements 
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
            var colorDialog = new ColorDialog();  //Creats a color dialog and updates the background color settings based on the user's choice 
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                //Settings options = new Settings();

                this.settings.bcolor = colorDialog.Color;
                
                //Updates the background color of the main form and other UI elements 
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
            Customers cust = new Customers(); //New Instance of the Customers Form
            cust.Show();  //Shows the Customers Form
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            Loans loans = new Loans();  //New Instance of the Loans Form
            loans.Show();  //Shows the Loans Form
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            Games games = new Games();  //New Instance of the Games Form    
            games.Show(); //Shows the Games Form
        }

    }

    }

