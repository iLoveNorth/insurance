using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gi1
{
    public partial class Form3 : Form
    {
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private Form1 m_parent;

        public Form3(Form1 frm1)
        {
            InitializeComponent();
            m_parent = frm1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 tempDialog = new Form4(this);
            tempDialog.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}