using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDB
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        public string address { get; private set; }
        public string username { get; private set; }
        public string password { get; private set; }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 0 || 
                textBox2.Text.Length < 0 || 
                textBox3.Text.Length < 0)
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                address = textBox1.Text;
                username = textBox2.Text;
                password = textBox3.Text;

                Close();
            }
        }

        private void InitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
