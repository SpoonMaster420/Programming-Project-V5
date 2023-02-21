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
        string CStr = DBSettings.CString;
        //OleDbConnection cn = DBSettings.connection;
        private Settings settings;
        public Customers()
        {
            InitializeComponent();

            CmBxCustID.DataSource = null;

            this.settings = SettingsManager.GetSettings();
            this.Font = this.settings.font;
            this.BackColor = this.settings.bcolor;
            this.ForeColor = this.settings.fcolor;

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
            string CustFirst = txtCustFirst.Text;
            string CustLast = txtCustLast.Text;
            string CustEmail = txtCustEmail.Text;
            string CustPhone = txtCustPhone.Text;

            Random random = new Random();
            int CustomerID = random.Next(10000, 99999);

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

            MessageBox.Show("Customer Details saved to Database!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCustFirst.Text = "";
            txtCustLast.Text = "";
            txtCustEmail.Text = "";
            txtCustPhone.Text = "";

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
            string selectedCustomerID = (string)CmBxCustID.SelectedValue;
            using(OleDbConnection connect = new OleDbConnection(CStr))
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM CustTable WHERE ID=@id", connect);
                command.Parameters.AddWithValue("@id", selectedCustomerID);
                
                OleDbDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txtSelectedID.Text = dr["ID"].ToString();
                    txtSelectedFirst.Text = dr["CustFirst"].ToString();
                    txtSelectedLast.Text = dr["CustLast"].ToString();
                    txtSelectedEmail.Text = dr["CustEmail"].ToString();
                    txtSelectedPhone.Text = dr["CustPhone"].ToString();
                }
                else
                {
                    MessageBox.Show("Unable to retrieve customer details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }
    }
}
