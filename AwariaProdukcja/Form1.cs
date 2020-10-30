using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Microsoft.Win32;
using SQLLib;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

//TODO
//displaying pareto of problems
//setup timer on filewatcher
//check if pc name in database, if no ask to add new row in db
//on first log update status to working
//if timer >x time => check if buttonCloseInterv is visible, if not => update status to lack of prod, otherwise update to broken/not working
//Open File to check if its pass/fail
//Update FPY
//Store error code
//Update listview


namespace AwariaProdukcja
{
    public partial class Form1 : Form
    {
        //INITIALIZE WATCHER FOR LOGFILES DIRECTORY
        private string FolderToMonitor { get; set; }
        private string Ext { get; set; }
        private string StationName { get; set; }
        FileSystemWatcher fwatcher = new FileSystemWatcher();
        FileOperations fo = new FileOperations();
        //used in form 2 and 3
        public string _tID { get; private set; }
        private List<string> technicians = new List<string>(){
            "123", "1234", "1015"
        };
        //used for calcualting downtime
        public static DateTime _start { get; set; }

        public string errorFilePath { get { return @"C:\Users\Public\Documents\AwariaProd_Errors.txt"; } }
        private string datetimeFormat = "yyyy-MM-dd HH:mm:ss"; //must be done cause of different date formats on stations
        private bool timerEnabled;
        private Timer timer;

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
            FolderToMonitor = FileOperations.ReadSetting("PathToMonitor");
            StationName = FileOperations.ReadSetting("StationName");
            while (FolderToMonitor == null || StationName == null)
            {
                btnSettings.PerformClick();
                FolderToMonitor = FileOperations.ReadSetting("PathToMonitor");
                Ext = FileOperations.ReadSetting("LogFormat");
                StationName = FileOperations.ReadSetting("StationName");
            }
            MonitorFiles();
            StartTimer();
            StatusModel sm = new StatusModel() { PC = Environment.MachineName, Name = StationName, Status = "Nie pracuje" };
            SqlDataAccess.UpdateRowSQL(sm);
            //update db nie pracuje
            
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

        private void HideButtons()
        {
            foreach (Control control in panelButtons.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.Visible = false;
                }
            }
        }

        private void ResetControls()
        {
            HideButtons();
            buttonRegisterIssue.Visible = true;
            //buttonRegisterIssue.BringToFront();
            lblStartTime.Text = "";
            lblStartInterv.Text = "";
            lblStartTime.Visible = false;
            lblStartInterv.Visible = false;
            tboxDescr.Text = "";
            tboxDescr.Visible = false;
            //buttonCloseInterv.Visible = false;
            cboxProblemType.ResetText();
            cboxProblemType.Visible = false;
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

        private void MonitorFiles()
        {
            fwatcher.Filter = Ext;
            fwatcher.Path = FolderToMonitor;
            fwatcher.NotifyFilter = NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.FileName
                                 | NotifyFilters.DirectoryName;
            fwatcher.Created += OnChanged;
            fwatcher.EnableRaisingEvents = true;
        }

        //EVENTS
        private void button1_Click(object sender, EventArgs e)
        {
            //Start AWARIA
            HideButtons();
            buttonCancel.Visible = true;
            buttonIntervention.Visible = true;
            _start = DateTime.Now;
            lblStartTime.Text = _start.ToString(datetimeFormat);
            lblStartTime.Visible = true;
            //buttonRegisterIssue.Visible = false; //hide awaria button so others are visible
        }

        private void button2_Click(object sender, EventArgs e)
        {   //ANULUJ
            ResetControls();
        }

        private void button3_Click(object sender, EventArgs e)
        {   //ROZPOCZNIJ INTERWENCJE
            HideButtons();
            lblStartInterv.Text = DateTime.Now.ToString(datetimeFormat);
            lblStartInterv.Visible = true;
            tboxDescr.Visible = true;
            buttonCloseInterv.Visible = true;
            cboxProblemType.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {   //ZAMKNIJ INTERWENCJE
            if (tboxDescr.Text != "" && cboxProblemType.Text != "")
            {
                while (!technicians.Contains(_tID))
                {
                    AskForID(); //ASK FOR TECHNICIAN ID
                }
                Debug.Assert(_tID != null);
                if (_tID != null)
                {
                    //build sql query 
                    ProblemModel pm = new ProblemModel();
                    pm.Tester = lblTester.Text.Substring(lblTester.Text.IndexOf(':'));
                    pm.Start = lblStartTime.Text; //conv string
                    pm.InterventionStart = lblStartInterv.Text; //conv string
                    pm.Stop = DateTime.Now.ToString(datetimeFormat); //conv string
                    pm.Downtime = DateTime.Now.Subtract(_start);
                    pm.TypeOfIssue = cboxProblemType.Text;
                    pm.RootCause = tboxDescr.Text;
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

        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            StopTimer();
            StartTimer();
            // Specify what is done when a file is changed, created, or deleted.

            //if (fo.CheckIfFolderExists(FolderToMonitor))
            //{
            //    string status = fo.GetFileStatus(e.FullPath, Ext);
            //    //MessageBox.Show($"File: {e.FullPath} {e.ChangeType}");
            //}
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.StartPosition = FormStartPosition.Manual;
            settingsForm.Show();
        }

        //TIMERS
        void Timer_Tick(object sender, EventArgs e)
        {
            StopTimer();
        }

        public void StartTimer()
        {
            if (!timerEnabled)
            {
                timer = new Timer();
                timer.Interval = 6000;
                timer.Tick += Timer_Tick;
                timer.Start();
                timerEnabled = true;
            }
        }

        public void StopTimer()
        {
            timer.Stop();
            timerEnabled = false;
            if (!buttonRegisterIssue.Visible)
            {
                //updatedb awaria
            }
            else
            {
                //updatedb pracuje
            }
        }
    }
}
