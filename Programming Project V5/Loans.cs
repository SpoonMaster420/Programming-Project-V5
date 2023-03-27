using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.CodeAnalysis;
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
        //Declare private variables to be used in the form
        private Customer selectedCustomer;

        private List<Game> availableGames;
        private List<Game> rentedGames;
        private List<Game> summaryGames;

        string CStr = DBSettings.CString; //Store the connection string in a private variable

        private Settings settings;  //Declare a settings object to be used in the form
        public Loans()
        {
            InitializeComponent();
            
            this.settings = SettingsManager.GetSettings();  //Retrieves the settings from the settings manager
            //Sets the form's font, background and foreground color to the user's choice 
            this.Font = this.settings.font;
            this.BackColor = this.settings.bcolor;
            this.ForeColor = this.settings.fcolor;

            //Initialise the availableGames and rentedGames lists
            availableGames = new List<Game>();
            rentedGames = new List<Game>();
            summaryGames = new List<Game> ();

        }

        private void Loans_Load(object sender, EventArgs e)
        {
            //Loads the Games, Customers and ongoing rentals when the form loads
            LoadGames();
            LoadCustomers();
            LoadOngoingRentals();
            
        }

        private void LoadOngoingRentals()
        {
            OleDbConnection connect = new OleDbConnection(CStr); //Creates a new OleDbConnection using the connection string

            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM RentalTable", connect); //Creates a DataAdapter to retrieve the data from the RentalTable
            DataTable datagridtable = new DataTable();  //Creates a DataTable to store the data retrieved from the Query
            adapter.Fill(datagridtable); //Fills the DataTable with the data from the rentalTable

            dgvOngoingRentals.DataSource = datagridtable; //Sets the source of the data grid view to the DataTable
        }
        //Loads the games from the GameTable in the database and displays them in the list box
        private void LoadGames()
        {
            using(OleDbConnection connect = new OleDbConnection(CStr)) //New OleDbConnection using the connection string
            {
                connect.Open(); //Opens the connection

                OleDbCommand cmd = new OleDbCommand("SELECT * FROM GameTable", connect);  //Retrieves all the data from the GameTable
                OleDbDataReader dr = cmd.ExecuteReader(); //Uses OleDbDataReader to read the data from the GameTable
                lbAvailableGames.Items.Clear(); //Clears the items in the list box
                

                while (dr.Read()) //Loops through each row in the GameTable
                {
                    //Retrieves the values for the Game's ID, name, stock level and rent price from the row
                    int id = Convert.ToInt32(dr["ID"]);
                    string name = dr["GameName"].ToString();
                    int stock = (int)dr["GameStock"];
                    decimal GameRentPrice = (decimal)dr["GameRentPrice"];
                    
                    if(stock > 0) //If the game is in stock, add it to the available games list box
                    {
                        availableGames.Add(new Game(id, name, GameRentPrice, stock));
                        lbAvailableGames.Items.Add(name);
                    }
                }
            }

         


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(lbAvailableGames.Items.Count == 0) //Check if there are any games that are available to rent 
            {
                MessageBox.Show("There are no available games to add.");
                return;
            }

            int selectedIndex = lbAvailableGames.SelectedIndex; //Get the index of the selected game in the list box
            if(selectedIndex == -1) //If no game is selected, display an error message and return
            {
                MessageBox.Show("Please select a game to add.");
                return;
            }

            Game selectedGame = availableGames[selectedIndex]; //Get the selected game object from the available games list based on the index

            //Remove the selected game from the available games list and move it to the rented games list
            availableGames.Remove(selectedGame);
            rentedGames.Add(selectedGame);
            summaryGames.Add(selectedGame);

            updateListBoxes(); //Update the list boxes to show the changes

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbRentedGames.SelectedIndex; //Get the index of the selected game in the rented games list box and stores it
            if(selectedIndex == -1) //If there is no game selected, display an error message and return
            {
                MessageBox.Show("Please select a game to remove.");
                return;
            }

            Game selectedGame = rentedGames[selectedIndex]; //Get the selected game object from the rented games list based on the index

            //Remove the selected game from the rented games list and add it to the available games list
            rentedGames.Remove(selectedGame);
            availableGames.Add(selectedGame);
            summaryGames.Remove(selectedGame);

            updateListBoxes(); //Update the list boxes to show the changes 
           
        }

        private void updateListBoxes()
        {
            //Clear the items in both list boxes 
            lbAvailableGames.Items.Clear();
            lbRentedGames.Items.Clear();
            lbRentalSummary.Items.Clear();

            foreach(Game game in availableGames) //Add each available game to the available games list box, displaying the game id and name
            {
                lbAvailableGames.Items.Add(game.id.ToString() + "\t" + game.name + "\n");
            }

            foreach(Game game in rentedGames) //Add each rented game to the rented games list box, displaying the game id and name
            {
                lbRentedGames.Items.Add(game.id.ToString() + "\t" + game.name + "\n");
            }
            foreach(Game game in summaryGames)
            {
                lbRentalSummary.Items.Add(game.id.ToString() + "\t" + game.name + "\n");
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the form
        }

        private void LoadCustomers()
        {
            using(OleDbConnection connect = new OleDbConnection(CStr)) //Creates a new OleDbConnection using the connection string
            {
                connect.Open(); //Opens the connection 

                OleDbCommand cmd = new OleDbCommand("SELECT ID, CustFirst, CustLast, CustEmail, CustPhone FROM CustTable ", connect); //Creates a command to select all customers from the CustTable 
                OleDbDataReader dr = cmd.ExecuteReader(); //Execute the command and get a reader to loop through the results

                while (dr.Read()) //Loops through each customer record and creates a customer object 
                {
                    int id = Convert.ToInt32(dr["ID"]);
                    string fName = dr["CustFirst"].ToString();
                    string lName = dr["CustLast"].ToString();
                    string email = dr["CustEmail"].ToString();
                    string phone = dr["CustPhone"].ToString();

                    Customer customer = new Customer(id, fName, lName, email, phone);
                    lbCustomers.Items.Add(customer); //Add the customer object to the list box
                }
            }
        }

        private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = (Customer)lbCustomers.SelectedItem; //Get the selected Customer object from the list box
        }

        private void btnSaveRental_Click(object sender, EventArgs e)
        {
            SaveRental(); //Save the rental information
            MessageBox.Show("Rental Successfully saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information); //Display a message box to indicate that the rental has been saved

            //Clear the rental summary list box and text boxes
            lbRentalSummary.Items.Clear();
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtTotalPrice.Clear();

            LoadOngoingRentals(); //Load the ongoing rentals
        
        }


        private void btnNextPg2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRentalSummary; //Switch to the rental summary tab

            updateListBoxes();

            //Gets the customer's name and ID and displays them in the appropriate text boxes
            txtCustomerName.Text = selectedCustomer.FirstName + " " + selectedCustomer.LastName; 
            txtCustomerID.Text = selectedCustomer.ID.ToString();

            if (selectedCustomer == null) //Check if a customer has been selected
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            if (rentedGames.Count == 0) //Check if at least one game has been rented
            {
                MessageBox.Show("Please select at least one game to rent.");
                return;
            }

            decimal totalPrice = 0; //To calculate the total rental price

            using (OleDbConnection connect = new OleDbConnection(CStr)) //Creates a new OleDbConnection using the connection string
            {
                connect.Open(); //Opens the connection

                foreach (Game game in summaryGames) //Loops through each rented game
                {
                    //Retrieve the rental price for the current game in the database using its ID
                    OleDbCommand cmd = new OleDbCommand("SELECT GameRentPrice FROM GameTable WHERE ID=@ID", connect); 
                    cmd.Parameters.AddWithValue("@ID", game.id);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        decimal price = Convert.ToDecimal(dr["GameRentPrice"]);
                        totalPrice += price;
                    }
                    //Add the current game's name to the rental summary list box
                    //lbRentalSummary.Items.Add(game.name);
                }
            }
            //Displays the total rental price in the textbox
            txtTotalPrice.Text = "Total Price: £" + totalPrice.ToString() + ".00";
        }

        private void SaveRental()
        {
            using(OleDbConnection connect = new OleDbConnection(CStr)) //Creates a new OleDbConnection using the connection string
            {
                connect.Open(); //Opens the connection
                Customer customer = (Customer)lbCustomers.SelectedItem; //Get the selected customer from the list box

                decimal dbTotalPrice = 0; //Create a variable to hold the total rental price
                //Loop through each rented game and get its rental price from the database
                foreach(Game game in summaryGames)
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT GameRentPrice FROM GameTable WHERE ID=@ID", connect);
                    cmd.Parameters.AddWithValue("@ID", game.id);
                    dbTotalPrice += Convert.ToDecimal(cmd.ExecuteScalar());

                    //Update the GameTable to update the stock of the rented game
                    OleDbCommand UpdateStock = new OleDbCommand("UPDATE GameTable SET GameStock = GameStock - 1 WHERE ID=@id", connect);
                    UpdateStock.Parameters.AddWithValue("@id", game.id);
                    UpdateStock.ExecuteNonQuery();
                }

                //Generate a random LoanID for the rental 
                Random random = new Random();
                int LoanID = random.Next(10000000, 99999999);


                //Get the current date and due date for the rental
                DateTime dateOut = DateTime.Now.Date;
                DateTime dateDue = dateOut.AddDays(21).Date;

                //Insert the rental into the RentalTable in the database
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
            tabControl1.SelectedTab = tabSelectCustomer; //Move to the next tab
        }

        private void btnBackPg3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSelectCustomer; //Go to the previous tab
        }

        private void btnBackPg2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSelectGames; //Go to the previous tab
        }

        private void tabRentalSummary_Click(object sender, EventArgs e)
        {

        }
    }

    
}
