using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project_V5
{
    public class SettingsManager
    {
        private static Settings settings;

        public static Settings GetSettings()
        {
            if(settings == null)
            {
                settings = new Settings();
            }
            return settings;
        
        }
    }
}
