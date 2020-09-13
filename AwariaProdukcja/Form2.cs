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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string TechnicianID { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                TechnicianID = textBox1.Text;
                Close();
            }
            
        }
    }
}
