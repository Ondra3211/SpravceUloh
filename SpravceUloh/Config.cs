using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpravceUloh
{
    internal class Config
    {
        private static string dataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SpravceUloh";
        private static string configFile = dataFolder + @"\config.txt";
        public static bool autoUpdate = false;
        public static bool killProcess = false;

        public static void readConfig()
        {
           if (checkConfig())
           {
                foreach (string option in File.ReadAllLines(configFile))
                {
                    option.Trim();
                    string[] options = option.Split(":");
                    if (options[0] == "autoUpdate")
                    {
                        autoUpdate = bool.Parse(options[1]);
                    }
                    if (options[0] == "killProcess")
                    {
                        killProcess = bool.Parse(options[1]);
                    }
                }
           } else
           {
                makeConfig();
           }
        }

        public static void makeConfig()
        {
            Directory.CreateDirectory(dataFolder);
            string configTxt = "autoUpdate:" + autoUpdate.ToString() + "\n";
            configTxt += "killProcess:" + killProcess.ToString();
            File.WriteAllText(configFile, configTxt);
        }

        private static bool checkConfig()
        {
            if (File.Exists(configFile))
            {
                return true;
            }
            
            return false;
        }
    }
}
