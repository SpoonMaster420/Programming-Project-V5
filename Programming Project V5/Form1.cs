using System;
using System.Data.OleDb; //Importing the OleDb database Library for access database


namespace Programming_Project_V5
{
    public partial class Login : Form
    {
        string Connect = DBSettings.CString; //Assigning the connection string to the "Connect" Variable
        OleDbConnection connect = DBSettings.connection; //Creating a new instance of the OleDbConnection class using the connection string
        public Login()
        {
            InitializeComponent();
        }
        //Event Handler for when the text box is clicked 
        private void txtEmpFirst_Click(object sender, EventArgs e)
        {
            txtEmpFirst.Clear(); //Clears the contents of the textbox when the textbox is clicked
        }

        //Event Handler for when the text box is clicked
        private void txtEmpID_Click(object sender, EventArgs e)
        {
            txtEmpID.Clear(); //Clears the contents of the textbox when the textbox is clicked
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            //Gets the values of the inputted data in the two text boxes and assignes them to two variables
            string firstname, id;
            firstname = txtEmpFirst.Text;
            id = txtEmpID.Text;

            //A SQL query to check if the employee actually exists in the database
            string query = "SELECT COUNT(*) FROM EmpTable WHERE EmpName = '" + firstname + "' AND ID = '" + id + "'";

            //New instance of OleDbConnection class using the Connect connection string
            using (OleDbConnection connect = new OleDbConnection(Connect))
            { 
                OleDbCommand command = new OleDbCommand(query, connect);  //New Instance of the OleDbCommand using the SQL query and the connect Object
                connect.Open();  //Opens the connection to the database
                int count = (int)command.ExecuteScalar();  //Executes the SQL query 

                if(count == 1)  //The check to see if the employee exists in the database
                {
                    MessageBox.Show("Login Successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); //Displays a success message
                    UserSession.EmployeeName = txtEmpFirst.Text;
                    UserSession.EmployeeID = txtEmpID.Text; //Set the EmployeeName and EmployeeID properties of the UserSession Class
                    this.Hide(); //Hides the Login form
                    Main_Form main = new Main_Form(); 
                    main.Show();   //Creates a new instance of the Main_Form and displays it
                }
                else
                {
                    MessageBox.Show("Login Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Displays an Error message 
                    txtEmpFirst.Clear();
                    txtEmpID.Clear();  //Clears the contents of the two Text boxes
                }

            }





        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)  //Checks if the form was closed by the user
            {
                Application.Exit(); //Exists the application
            }
        }
    }
}