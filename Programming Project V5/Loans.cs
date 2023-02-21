using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_V5
{
    public partial class Loans : Form
    {
        private Settings settings;
        public Loans()
        {
            InitializeComponent();
            
            this.settings = SettingsManager.GetSettings();

            this.Font = this.settings.font;
            this.BackColor = this.settings.bcolor;
            this.ForeColor = this.settings.fcolor;
        }

        private void Loans_Load(object sender, EventArgs e)
        {

        }
    }
}
