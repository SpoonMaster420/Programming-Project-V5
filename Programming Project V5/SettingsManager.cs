using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project_V5
{
    public class SettingsManager
    {
        private static Settings settings; //Holds the settings object

        public static Settings GetSettings() //Gets the current application settings
        {
            if(settings == null) //If the settings object has not been created, create a new object
            {
                settings = new Settings();
            }
            return settings; //return the settings object
        
        }
    }
}
