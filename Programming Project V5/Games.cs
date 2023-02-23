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
using System.IO;
using System.Drawing.Imaging;

namespace Programming_Project_V5
{
    public partial class Games : Form
    {
        //Declare a Settings object and a connection string variable
        private Settings settings;
        string Cstr = DBSettings.CString;

        public Games()
        {
            InitializeComponent();

            //Gets the User's font, background and foreground color settings and applies them to the form
            this.settings = SettingsManager.GetSettings();
            this.Font = this.settings.font;
            this.BackColor = this.settings.bcolor;
            this.ForeColor = this.settings.fcolor;

            //Creats a connection to the database and populates the ComboBox with all the Game IDs
            using (OleDbConnection connect = new OleDbConnection(Cstr))
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand("SELECT ID FROM GameTable", connect);
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable table = new DataTable();
                da.Fill(table);
                CmBxGameID.DisplayMember = "ID";
                CmBxGameID.ValueMember = "ID";
                CmBxGameID.DataSource = table;
            }

        }

        private void btnSaveGameDetails_Click(object sender, EventArgs e)
        {
            //Get the values of the game details from the text boxes
            string GameName = txtGameName.Text;
            string GameReleaseDate = txtGameReleaseDate.Text;
            string GameStock = txtGameStock.Text;
            string GameRating = txtGameRating.Text;
            string GamePlatform = txtGamePlatform.Text;
            string GameRentPrice = txtGameRentPrice.Text;


            //This generates a random Game ID for the new game 
            Random random = new Random();
            int GameID = random.Next(1000, 9999);

            //Establishes a connection to the database and inserts the new Game and its details into the GameTable Table in the database
            using (OleDbConnection connect = new OleDbConnection(Cstr))
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand("INSERT INTO GameTable (ID, GameName, GameReleaseDate, GameStock, GameRating, GamePlatform, GameRentPrice) VALUES (@id, @name, @date, @stock, @rating, @platform, @price)");
                command.Parameters.AddWithValue("@id", GameID);
                command.Parameters.AddWithValue("@name", GameName);
                command.Parameters.AddWithValue("@date", GameReleaseDate);
                command.Parameters.AddWithValue("@stock", GameStock);
                command.Parameters.AddWithValue("@rating", GameRating);
                command.Parameters.AddWithValue("@platform", GamePlatform);
                command.Parameters.AddWithValue("@price", GameRentPrice);
                command.Connection = connect;
                command.ExecuteNonQuery();
            }
            //Displays a MessageBox to confirm the Game has been saved and clears the contents of the text boxes
            MessageBox.Show("Game Details have been saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtGameName.Text = "";
            txtGameReleaseDate.Text = "";
            txtGameStock.Text = "";
            txtGameRating.Text = "";
            txtGamePlatform.Text = "";

            //Refreshes the ComboBox to show any new games added 
            using (OleDbConnection Refresh = new OleDbConnection(Cstr))
            {
                OleDbCommand refr = new OleDbCommand("SELECT ID FROM GameTable", Refresh);
                OleDbDataAdapter adapter = new OleDbDataAdapter(refr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                CmBxGameID.DisplayMember = "ID";
                CmBxGameID.ValueMember = "ID";
                CmBxGameID.DataSource = table;
            }
        }

        private void CmBxGameID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGameID = (string)CmBxGameID.SelectedValue;  //Gets the Game ID from the ComboBox
            using (OleDbConnection connect = new OleDbConnection(Cstr))
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM GameTable WHERE ID=@id", connect); //Query the database to get all the data linked to the selected Game ID
                command.Parameters.AddWithValue("@id", selectedGameID);

                OleDbDataReader dr = command.ExecuteReader(); //Executes the query and reads the results 
                if (dr.Read())
                {
                    //Displays all the games data in the appropriate text boxes
                    txtSelectedGameID.Text = dr["ID"].ToString();
                    txtSelectedGameName.Text = dr["GameName"].ToString();
                    txtSelectedGameReleaseDate.Text = dr["GameReleaseDate"].ToString();
                    txtSelectedGameStock.Text = dr["GameStock"].ToString();
                    txtSelectedGameRating.Text = dr["GameRating"].ToString();
                    txtSelectedGamePlatform.Text = dr["GamePlatform"].ToString();
                    txtSelectedGameRentPrice.Text = dr["GameRentPrice"].ToString();

                    
                }
                else
                {
                    MessageBox.Show("Unable to retrieve Game Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //A message box that will show if the form is unable to retrieve the game data from the database
                }
            }
        }

        

    }
}
        

    







