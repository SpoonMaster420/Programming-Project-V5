using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project_V5
{
    public class Settings
    {
        public Color fcolor { get; set; } //Holds the Foreground color of the app
        public Font? font { get; set; } //Holds the Font of the App (can be null)
        public Color bcolor { get; set; } //Holds the Background color of the app
    }
}
