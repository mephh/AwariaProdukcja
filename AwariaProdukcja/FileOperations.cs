using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace AwariaProdukcja
{
    class FileOperations
    {
        //LOAD CONFIGURATION -- APP CONFIG
        internal static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found"; //check if called setting name exists
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("brak zapisanej sciezki");
                return "Brak takiej sciezki";
            }
        }

        internal static void AddUpdateAppSetting(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings; //load settings from app.config
                if (settings[key] == null)
                {
                    settings.Add(key, value); //create new setting
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified); //save changes
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name); //update app.config
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error writing app settings");
            }
        }
        //END OF CONFIGURATION METHODS
        internal bool CheckIfFolderExists(string path)
        {
            if (Directory.Exists(path))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Sprawdz czy folder isnieje: " + path);
                return false;
            }
        }

        internal bool GenerateReport(string path, string logfile)
        {
            string filePath = path + "\\Raport.txt";
            string boxName = path.Substring(path.LastIndexOf('\\')+1);
            string shortedLogName = logfile.Substring(logfile.LastIndexOf('/')+1);
            string[] lines = { "Raport dla boxu nr " + boxName,
                "Raport został wygenerowany dnia: " + DateTime.Now.ToShortDateString() + " o godzinie: " + DateTime.Now.ToShortTimeString(),
                "LOG \t GODZINA TESTU"};
            if (!File.Exists(filePath))
            {
                try
                {
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Nie mozna utworzyc pliku z raportem. Kod bledu: " + e.ToString());
                    return false;
                }
            }
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                if (shortedLogName.Length != 0)
                {
                    sw.WriteLine(shortedLogName + " \t " + DateTime.Now.ToShortTimeString());
                }
            }
            return true;
        }
        
        internal string GetFileStatus(string filename, string ext)
        {
            try
            {
                var finfo = new FileInfo(filename);
                while (IsFileLocked(finfo))
                {
                    //wait until file can be accessed
                }
                string[] lines = File.ReadAllLines(filename);
                List<string> logList = new List<string>(lines);
                if (ext == ".txt")
                {
                    if (lines[lines.Length - 1].Contains("FAILED"))
                    {
                        return "FAIL";
                    }
                    else if (lines[lines.Length - 1].Contains("PASSED"))
                    {
                        return "PASS";
                    }
                }
                else if (ext == ".xml")
                {
                    for (int i = 0; i < logList.Count; i++)
                    {
                        if (logList[i].Contains("CriticalFailureStackEntry"))
                        {
                            int start = logList[i].IndexOf("stepName=") + 10;
                            int stop = logList[i].IndexOf("sequence") - 2;
                            int stepNameLength = stop - start;
                            string result = logList[i].Substring(start, stepNameLength);

                            return result;
                        }
                    }
                }
                return "No data";
            }
            catch (Exception e)
            {
                return "No data:" + e.ToString();
            }
        }

        internal bool IsFileLocked(FileInfo file) //check if file can be opened
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
    }
}
