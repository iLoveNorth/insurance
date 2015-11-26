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
    public partial class Form2 : Form
    {
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private Form1 m_parent;

        public Form2(Form1 frm1)
        {
            InitializeComponent();
            m_parent = frm1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin")&&(textBox2.Text == "pass"))
            {
                MessageBox.Show("Пароль верен!");
                Hide();
                Form5 tempDialog = new Form5(this);
                tempDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пароль не верен!");
                Close();
            }
        }

      
    }
}