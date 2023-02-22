using System;
using System.Data.OleDb;


namespace Programming_Project_V5
{
    public partial class Login : Form
    {
        string Connect = DBSettings.CString;
        OleDbConnection connect = DBSettings.connection;
        public Login()
        {
            InitializeComponent();
        }

        private void txtEmpFirst_Click(object sender, EventArgs e)
        {
            txtEmpFirst.Clear();
        }


        private void txtEmpID_Click(object sender, EventArgs e)
        {
            txtEmpID.Clear();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            //string CString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\carla\\Documents\\Computer Science\\NEA Progamming Project\\Programming Project V5\\DBofAll.mdb\"";

            string firstname, id;
            firstname = txtEmpFirst.Text;
            id = txtEmpID.Text;

            string query = "SELECT COUNT(*) FROM EmpTable WHERE EmpName = '" + firstname + "' AND ID = '" + id + "'";

            using(connect)
            { 
                OleDbCommand command = new OleDbCommand(query, connect);
                connect.Open();
                int count = (int)command.ExecuteScalar();

                if(count == 1)
                {
                    MessageBox.Show("Login Successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserSession.CurrentUser = txtEmpID.Text;
                    this.Hide();
                    Main_Form main = new Main_Form();
                    main.Show();   
                }
                else
                {
                    MessageBox.Show("Login Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmpFirst.Clear();
                    txtEmpID.Clear();
                }

            }





        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); 
            }
        }
    }
}