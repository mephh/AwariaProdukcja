using SQLiteLib;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace AwariaProdukcja
{
    public partial class Form1 : Form
    {
        public string _tID { get; private set; }
        public static DateTime _start { get; set; }
        public string errorFilePath { get { return @"\\kit-grd-fs01\backtst\Install\AwariaProd\errors.txt"; } }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetControls();
            CheckIfFilesExist();
            Debug.Assert(File.Exists(@"X:\Install\AwariaProd\Awaria.db"));
        }

        private void CheckIfFilesExist()
        {
            if (!File.Exists(errorFilePath))
            {
                try
                {
                    File.Create(errorFilePath);
                }
                catch
                {
                    MessageBox.Show("BRAK UPRAWNIEN DO UTWORZENIA PLIKU W FOLDERZE: " + errorFilePath);
                }
            }
            if (!File.Exists(@"X:\Install\AwariaProd\Awaria.db"))
            {
                MessageBox.Show(@"ZMAPUJ FOLDER \\kit-grd-fs01\backtst\ JAKO X:\");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _start = DateTime.Now;
            label4.Text = _start.ToString();
            label4.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
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
        {
            if (textBox2.Text != "" && comboBox1.Text != "")
            {
                AskForID();
                Debug.Assert(_tID != null);
                if( _tID != null)
                {
                    
                    ProblemModel pm = new ProblemModel();
                    pm.Tester = textBox1.Text;
                    pm.Tester = Environment.MachineName;
                    pm.Start = label4.Text;
                    pm.InterventionStart = label6.Text;
                    pm.Stop = DateTime.Now.ToString();
                    pm.Downtime = DateTime.Now.Subtract(_start);
                    pm.TypeOfIssue = comboBox1.Text;
                    pm.RootCause = textBox2.Text;
                    pm.technicianID = _tID;
                    try
                    {
                        SqliteDataAccess.SaveProblem(pm);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("BRAK POLACZENIA Z BAZA DANYCH. SPRAWDZ CZY PLIK ISTNIEJE");
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
            using(StreamWriter sw = new StreamWriter(errorFile, true))
            {
                sw.WriteLine(sb);
            }
        }
    }
}
