using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwariaProdukcja
{
    public partial class Form3 : Form
    {
        public static string OperatorID { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text.Length == 4)
                {
                    var isNumeric = int.TryParse(textBox1.Text, out int n);
                    if (isNumeric)
                    {
                        OperatorID = textBox1.Text;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("NIEWŁAŚCIWY NUMER IDENTYFIKATORA");

                    }
                }
                else
                {
                    MessageBox.Show("NIEWŁAŚCIWY NUMER IDENTYFIKATORA");
                    textBox1.Text = "";
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
