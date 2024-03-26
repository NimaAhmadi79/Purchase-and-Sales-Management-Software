using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abarnic1
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            if (form2.IsDisposed)
            {
                form2 = new Form2();
            }
            form2.Show();
            
        }
    }
}


        /*private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBoxButtons boxButtons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("do you want to save?", "alert", boxButtons);
            if (result == DialogResult.Yes)
            {

            }


        }*/


