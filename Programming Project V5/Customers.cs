using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_V5
{
    public partial class Customers : Form
    {
        string CStr = DBSettings.CString; //Connection String to the database
        
        private Settings settings; //Settings object to store user settings
        public Customers()
        {
            InitializeComponent();

            //Loads user settings for font, background and foreground color and applies to the whole form
            this.settings = SettingsManager.GetSettings();
            this.Font = this.settings.font;
            this.BackColor = this.settings.bcolor;
            this.ForeColor = this.settings.fcolor;
            
            //Loads the customer IDs from the database into the ComboBox
            using(OleDbConnection connect = new OleDbConnection(CStr))
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand("SELECT ID FROM CustTable", connect);
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable table = new DataTable();
                da.Fill(table);
                CmBxCustID.DisplayMember = "ID";
                CmBxCustID.ValueMember = "ID";
                CmBxCustID.DataSource = table;
            }

        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {

            //Assigns the values from the textboxes to variables 
            string CustFirst = txtCustFirst.Text;
            string CustLast = txtCustLast.Text;
            string CustEmail = txtCustEmail.Text;
            string CustPhone = txtCustPhone.Text;


            //Generates a random Customer ID
            Random random = new Random();
            int CustomerID = random.Next(10000, 99999);


            //Inserts the customer details into the database
            using (OleDbConnection connect = new OleDbConnection(CStr))
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand("INSERT INTO CustTable (ID, CustFirst, CustLast, CustEmail, CustPhone) VALUES (@id, @first, @last, @email, @phone) ");
                command.Parameters.AddWithValue("@id", CustomerID);
                command.Parameters.AddWithValue("@first", CustFirst);
                command.Parameters.AddWithValue("@last", CustLast);
                command.Parameters.AddWithValue("@email", CustEmail);
                command.Parameters.AddWithValue("@phone", CustPhone);
                command.Connection = connect;
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Customer Details saved to Database!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information); //Displays a success message to say the details have been saved

            //Clears the text boxes
            txtCustFirst.Text = "";
            txtCustLast.Text = "";
            txtCustEmail.Text = "";
            txtCustPhone.Text = "";


            //Refreshes the ComboBox to show any new customers added 
            using(OleDbConnection Refresh = new OleDbConnection(CStr))
            {
                OleDbCommand refresh = new OleDbCommand("SELECT ID FROM CustTable", Refresh);
                OleDbDataAdapter adapter = new OleDbDataAdapter(refresh);
                DataTable table = new DataTable();
                adapter.Fill(table);
                CmBxCustID.DisplayMember = "ID";
                CmBxCustID.ValueMember= "ID";
                CmBxCustID.DataSource = table;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCustomerID = (string)CmBxCustID.SelectedValue; //Get the selected Customer ID from the ComboBox 
            using(OleDbConnection connect = new OleDbConnection(CStr))
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM CustTable WHERE ID=@id", connect); //Query the database with the selected Customer ID to get all the customer details
                command.Parameters.AddWithValue("@id", selectedCustomerID); //Execute the query and reads the results 
                
                OleDbDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    //Displays the customer details in the appropriate text boxes
                    txtSelectedID.Text = dr["ID"].ToString();
                    txtSelectedFirst.Text = dr["CustFirst"].ToString();
                    txtSelectedLast.Text = dr["CustLast"].ToString();
                    txtSelectedEmail.Text = dr["CustEmail"].ToString();
                    txtSelectedPhone.Text = dr["CustPhone"].ToString();
                }
                else
                {
                    MessageBox.Show("Unable to retrieve customer details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message that will say that it can't retrieve the customer data
                }
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }
    }
}
