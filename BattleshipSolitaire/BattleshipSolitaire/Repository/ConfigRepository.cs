using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipSolitaire.Repository
{
    class ConfigRepository
    {
        public static void ReadFromFile()
        {
            string file1 = "C:\\Temp\\config.txt";
            if (!File.Exists(file1))
            {
                using (StreamWriter writer = new StreamWriter("C:\\Temp\\config.txt"))
                {
                    writer.WriteLine("0");
                    writer.WriteLine("0");
                    writer.WriteLine("0");
                    writer.WriteLine("0");
                    writer.WriteLine("0");
                    writer.WriteLine("0");
                }
            }


            using (StreamReader reader = new StreamReader("C:\\Temp\\config.txt"))
            {
                MainWindow.ConfigArray[0] = reader.ReadLine();
                MainWindow.ConfigArray[1] = reader.ReadLine();
                MainWindow.ConfigArray[2] = reader.ReadLine();
                MainWindow.ConfigArray[3] = reader.ReadLine();
                MainWindow.ConfigArray[4] = reader.ReadLine();
                MainWindow.ConfigArray[5] = reader.ReadLine();
            }
        }
    }
}
