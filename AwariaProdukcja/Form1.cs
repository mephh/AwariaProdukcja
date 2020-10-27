using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Microsoft.Win32;
using SQLLib;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AwariaProdukcja
{
    public partial class Form1 : Form
    {
        //used in form 2 and 3
        public string _tID { get; private set; }
        private List<string> technicians = new List<string>(){
            "123", "1234", "1015"
        };
        //used for calcualting downtime
        public static DateTime _start { get; set; }

        public string errorFilePath { get { return @"C:\Users\Public\Documents\AwariaProd_Errors.txt"; } }
        private string datetimeFormat = "yyyy-MM-dd HH:mm:ss"; //must be done cause of different date formats on stations

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetControls();
            CheckIfFilesExist();
            //make sure app is added to autostart
            RunAtStartUp();
            lblTester.Text += Environment.MachineName;
            lblUser.Text += Environment.UserName;

        }

        private void RunAtStartUp()
        {
            //ADD to AUTOSTART
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rkApp.GetValue("AwariaProdukcja") == null)
            {
                rkApp.SetValue("AwariaProdukcja", Application.ExecutablePath);
            }
        }

        private void CheckIfFilesExist()
        {   //try to create error file, in future will be exchanged for email send method
            if (!File.Exists(errorFilePath))
            {
                try
                {
                    File.Create(errorFilePath);
                }
                catch
                {
                    MessageBox.Show("BRAK UPRAWNIEN DO UTWORZENIA PLIKU ERRORS W FOLDERZE Z PROGRAMEM");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Start AWARIA
            _start = DateTime.Now;
            label4.Text = _start.ToString(datetimeFormat);
            label4.Visible = true;
            button1.Visible = false; //hide awaria button so others are visible
        }

        private void button2_Click(object sender, EventArgs e)
        {   //ANULUJ
            ResetControls();
        }

        private void button3_Click(object sender, EventArgs e)
        {   //ROZPOCZNIJ INTERWENCJE
            label6.Text = DateTime.Now.ToString(datetimeFormat);
            label6.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;
            comboBox1.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //nuffin
        }

        private void ResetControls()
        {
            button1.Visible = true;
            button1.BringToFront();
            label4.Text = "";
            label6.Text = "";
            label4.Visible = false;
            label6.Visible = false;
            textBox2.Text = "";
            textBox2.Visible = false;
            button4.Visible = false;
            comboBox1.ResetText();
            comboBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {   //ZAMKNIJ INTERWENCJE
            if (textBox2.Text != "" && comboBox1.Text != "")
            {
                while (!technicians.Contains(_tID)){
                    AskForID(); //ASK FOR TECHNICIAN ID
                }
                Debug.Assert(_tID != null);
                if (_tID != null)
                {
                    //build sql query 
                    ProblemModel pm = new ProblemModel();
                    pm.Tester = lblTester.Text.Substring(lblTester.Text.IndexOf(':'));
                    pm.Start = label4.Text; //conv string
                    pm.InterventionStart = label6.Text; //conv string
                    pm.Stop = DateTime.Now.ToString(datetimeFormat); //conv string
                    pm.Downtime = DateTime.Now.Subtract(_start);
                    pm.TypeOfIssue = comboBox1.Text;
                    pm.RootCause = textBox2.Text;
                    pm.technicianID = _tID;
                    pm.LoggedOperator = Environment.UserName;
                    try
                    {
                        SqlDataAccess.SaveProblemSQL(pm);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("BRAK POLACZENIA Z BAZA DANYCH. SPRAWDZ CZY MASZ POLACZENIE Z SERWEREM.");
                        Error2txt(errorFilePath, exc.ToString());
                    }
                    ResetControls();
                }
            }
        }

        public void AskForID()
        {
            Form2 testDialog = new Form2();
            testDialog.StartPosition = FormStartPosition.CenterParent;
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog() == DialogResult.OK)
            {
                _tID = Form2.UserID;
            }
            else
            {
                _tID = null;
            }
            testDialog.Dispose();
        }

        public void Error2txt(string errorFile, string errorCode)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Tester: " + Environment.MachineName + ", Czas wystapienia:" + DateTime.Now + ", Blad wykonywania funkcji" + this.ToString() + ", Kod bledu: " + errorCode);
            using (StreamWriter sw = new StreamWriter(errorFile, true))
            {
                sw.WriteLine(sb);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
