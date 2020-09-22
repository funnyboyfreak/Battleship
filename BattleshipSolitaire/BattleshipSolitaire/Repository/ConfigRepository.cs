using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipSolitaire.Repository
{
    public class ConfigRepository
    {
        public static string[] ConfigArray = new string[6];
        public static void ReadFromFile()
        {
            string configFile = "C:\\Temp\\config.txt";
            if (File.Exists(configFile))
            {
                using (StreamReader reader = new StreamReader(configFile))
                {
                    ConfigArray[0] = reader.ReadLine();
                    ConfigArray[1] = reader.ReadLine();
                    ConfigArray[2] = reader.ReadLine();
                    ConfigArray[3] = reader.ReadLine();
                    ConfigArray[4] = reader.ReadLine();
                    ConfigArray[5] = reader.ReadLine();
                }
            }
        }
    }
}
