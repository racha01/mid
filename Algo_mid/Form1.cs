using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algo_mid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("นาย");
            comboBox1.Items.Add("นาง");
            comboBox1.Items.Add("นางสาว");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            string f_name;
            f_name = comboBox1.Text;

            MessageBox.Show(f_name + " " +name + " " + lastname);
        }

    }

}
