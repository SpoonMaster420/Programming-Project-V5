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
        private Settings settings;
        string Cstr = DBSettings.CString;

        public Games()
        {
            InitializeComponent();

            this.settings = SettingsManager.GetSettings();
            this.Font = this.settings.font;
            this.BackColor = this.settings.bcolor;
            this.ForeColor = this.settings.fcolor;

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
            string GameName = txtGameName.Text;
            string GameReleaseDate = txtGameReleaseDate.Text;
            string GameStock = txtGameStock.Text;
            string GameRating = txtGameRating.Text;
            string GamePlatform = txtGamePlatform.Text;

            Random random = new Random();
            int GameID = random.Next(1000, 9999);

            using (OleDbConnection connect = new OleDbConnection(Cstr))
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand("INSERT INTO GameTable (ID, GameName, GameReleaseDate, GameStock, GameRating, GamePlatform) VALUES (@id, @name, @date, @stock, @rating, @platform)");
                command.Parameters.AddWithValue("@id", GameID);
                command.Parameters.AddWithValue("@name", GameName);
                command.Parameters.AddWithValue("@date", GameReleaseDate);
                command.Parameters.AddWithValue("@stock", GameStock);
                command.Parameters.AddWithValue("@rating", GameRating);
                command.Parameters.AddWithValue("@platform", GamePlatform);
                command.Connection = connect;
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Game Details have been saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtGameName.Text = "";
            txtGameReleaseDate.Text = "";
            txtGameStock.Text = "";
            txtGameRating.Text = "";
            txtGamePlatform.Text = "";

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
            string selectedGameID = (string)CmBxGameID.SelectedValue;
            using (OleDbConnection connect = new OleDbConnection(Cstr))
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM GameTable WHERE ID=@id", connect);
                command.Parameters.AddWithValue("@id", selectedGameID);

                OleDbDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txtSelectedGameID.Text = dr["ID"].ToString();
                    txtSelectedGameName.Text = dr["GameName"].ToString();
                    txtSelectedGameReleaseDate.Text = dr["GameReleaseDate"].ToString();
                    txtSelectedGameStock.Text = dr["GameStock"].ToString();
                    txtSelectedGameRating.Text = dr["GameRating"].ToString();
                    txtSelectedGamePlatform.Text = dr["GamePlatform"].ToString();

                    
                }
                else
                {
                    MessageBox.Show("Unable to retrieve Game Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

    }
}
        

    







