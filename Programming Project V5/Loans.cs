using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_V5
{
    public partial class Loans : Form
    {
        private Customer selectedCustomer;

        private List<Game> availableGames;
        private List<Game> rentedGames;

        string CStr = DBSettings.CString;

        private Settings settings;
        public Loans()
        {
            InitializeComponent();
            
            this.settings = SettingsManager.GetSettings();

            this.Font = this.settings.font;
            this.BackColor = this.settings.bcolor;
            this.ForeColor = this.settings.fcolor;


            availableGames = new List<Game>();
            rentedGames = new List<Game>();

        }

        private void Loans_Load(object sender, EventArgs e)
        {
            LoadGames();
            LoadCustomers();
            LoadOngoingRentals();
            
        }

        private void LoadOngoingRentals()
        {
            OleDbConnection connect = new OleDbConnection(CStr);

            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM RentalTable", connect);
            DataTable datagridtable = new DataTable();
            adapter.Fill(datagridtable);

            dgvOngoingRentals.DataSource = datagridtable;
        }
        private void LoadGames()
        {
            using(OleDbConnection connect = new OleDbConnection(CStr))
            {
                connect.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT * FROM GameTable", connect);
                OleDbDataReader dr = cmd.ExecuteReader();
                lbAvailableGames.Items.Clear();
                

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["ID"]);
                    string name = dr["GameName"].ToString();
                    int stock = (int)dr["GameStock"];
                    decimal GameRentPrice = (decimal)dr["GameRentPrice"];
                    
                    if(stock > 0)
                    {
                        availableGames.Add(new Game(id, name, GameRentPrice, stock));
                        lbAvailableGames.Items.Add(name);
                    }
                }
            }

         


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(lbAvailableGames.Items.Count == 0)
            {
                MessageBox.Show("There are no available games to add.");
                return;
            }

            int selectedIndex = lbAvailableGames.SelectedIndex;
            if(selectedIndex == -1)
            {
                MessageBox.Show("Please select a game to add.");
                return;
            }

            Game selectedGame = availableGames[selectedIndex];

            availableGames.Remove(selectedGame);
            rentedGames.Add(selectedGame);

            updateListBoxes();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbRentedGames.SelectedIndex;
            if(selectedIndex == -1)
            {
                MessageBox.Show("Please select a game to remove.");
                return;
            }

            Game selectedGame = rentedGames[selectedIndex];

            rentedGames.Remove(selectedGame);
            availableGames.Add(selectedGame);

            updateListBoxes();
           
        }

        private void updateListBoxes()
        {
            lbAvailableGames.Items.Clear();
            lbRentedGames.Items.Clear();

            foreach(Game game in availableGames)
            {
                lbAvailableGames.Items.Add(game.id.ToString() + "\t" + game.name + "\n");
            }

            foreach(Game game in rentedGames)
            {
                lbRentedGames.Items.Add(game.id.ToString() + "\t" + game.name + "\n");
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCustomers()
        {
            using(OleDbConnection connect = new OleDbConnection(CStr))
            {
                connect.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT ID, CustFirst, CustLast, CustEmail, CustPhone FROM CustTable ", connect);
                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["ID"]);
                    string fName = dr["CustFirst"].ToString();
                    string lName = dr["CustLast"].ToString();
                    string email = dr["CustEmail"].ToString();
                    string phone = dr["CustPhone"].ToString();

                    Customer customer = new Customer(id, fName, lName, email, phone);
                    lbCustomers.Items.Add(customer);
                }
            }
        }

        private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = (Customer)lbCustomers.SelectedItem;
        }

        private void btnSaveRental_Click(object sender, EventArgs e)
        {
            SaveRental();
            MessageBox.Show("Renal Successfully saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            lbRentalSummary.Items.Clear();
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtTotalPrice.Clear();

            LoadOngoingRentals();
        
        }


        private void btnNextPg2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRentalSummary;

            txtCustomerName.Text = selectedCustomer.FirstName + " " + selectedCustomer.LastName;
            txtCustomerID.Text = selectedCustomer.ID.ToString();

            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            if (rentedGames.Count == 0)
            {
                MessageBox.Show("Please select at least one game to rent.");
                return;
            }

            decimal totalPrice = 0;

            using (OleDbConnection connect = new OleDbConnection(CStr))
            {
                connect.Open();

                foreach (Game game in rentedGames)
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT GameRentPrice FROM GameTable WHERE ID=@ID", connect);
                    cmd.Parameters.AddWithValue("@ID", game.id);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        decimal price = Convert.ToDecimal(dr["GameRentPrice"]);
                        totalPrice += price;
                    }
                    lbRentalSummary.Items.Add(game.name);
                }
            }
            txtTotalPrice.Text = "Total Price: £" + totalPrice.ToString() + ".00";
        }

        private void SaveRental()
        {
            using(OleDbConnection connect = new OleDbConnection(CStr))
            {
                connect.Open();
                Customer customer = (Customer)lbCustomers.SelectedItem;

                decimal dbTotalPrice = 0;
                foreach(Game game in rentedGames)
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT GameRentPrice FROM GameTable WHERE ID=@ID", connect);
                    cmd.Parameters.AddWithValue("@ID", game.id);
                    dbTotalPrice += Convert.ToDecimal(cmd.ExecuteScalar());

                    OleDbCommand UpdateStock = new OleDbCommand("UPDATE GameTable SET GameStock = GameStock - 1 WHERE ID=@id", connect);
                    UpdateStock.Parameters.AddWithValue("@id", game.id);
                    UpdateStock.ExecuteNonQuery();
                }

                Random random = new Random();
                int LoanID = random.Next(10000000, 99999999);

                DateTime dateOut = DateTime.Now.Date;
                DateTime dateDue = dateOut.AddDays(21).Date;

                OleDbCommand command = new OleDbCommand("INSERT INTO RentalTable (ID, CustomerName, CustomerPhone, EmployeeID, TotalPrice, DateOut, DateDue) VALUES (@ID, @name, @phone, @empid, @price, @dateout, @datedue)", connect);
                command.Parameters.AddWithValue("@ID", LoanID);
                command.Parameters.AddWithValue("@name", txtCustomerName.Text);
                command.Parameters.AddWithValue("@phone", customer.Phone);
                command.Parameters.AddWithValue("@empid", UserSession.EmployeeID);
                command.Parameters.AddWithValue("@price", dbTotalPrice);
                command.Parameters.AddWithValue("@dateout", dateOut);
                command.Parameters.AddWithValue("@datedue", dateDue);
                command.ExecuteNonQuery();




            }
        }

        private void btnNextPg1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSelectCustomer;
        }

        private void btnBackPg3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSelectCustomer;
        }

        private void btnBackPg2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSelectGames;
        }
    }

    
}
