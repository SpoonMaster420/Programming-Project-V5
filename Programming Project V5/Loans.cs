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
        }

        private void LoadGames()
        {
            using(OleDbConnection connect = new OleDbConnection(CStr))
            {
                connect.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT ID, GameName FROM GameTable", connect);
                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["ID"]);
                    string name = dr["GameName"].ToString();
                    Game game = new Game(id, name);
                    availableGames.Add(game);
                }
            }

            foreach(Game game in availableGames)
            {
                lbAvailableGames.Items.Add(game.id.ToString() + "\t" + game.name + "\n");
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
    }

    
}
