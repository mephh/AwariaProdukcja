using SQLiteLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AwariaProdukcja
{
    public partial class Form1 : Form
    {
        public object txtResult { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
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
                const string mbTitle = "Kto zamyka interwencje";
                const string mbMessage = "Wpisz swoj numer indentyfikatora";



                ProblemModel pm = new ProblemModel();
                pm.Tester = textBox1.Text;
                pm.Tester = System.Environment.MachineName;
                pm.Start = label4.Text;
                pm.InterventionStart = label6.Text;
                pm.Stop = DateTime.Now.ToString();
                pm.TypeOfIssue = comboBox1.Text;
                pm.RootCause = textBox2.Text;
                
                SqliteDataAccess.SaveProblem(pm);
                ResetControls();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //var form2 = new Form2();
            //form2.Show();
            //ShowMyDialogBox();
        }

        public void ShowMyDialogBox()
        {
            Form2 testDialog = new Form2();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                //this.txtResult.Text = testDialog.TextBox1.Text;
            }
            else
            {
                //this.txtResult.Text = "Cancelled";
            }
            testDialog.Dispose();
        }
    }
}
