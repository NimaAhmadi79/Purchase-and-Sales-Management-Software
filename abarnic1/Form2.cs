using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace abarnic1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void onvanProjeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void onvanProjeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                tedadBox.Focus();
            }
        }

        private void tedadBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                gheimatBox.Focus();
            }
        }

        private void gheimatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                daramadBox.Focus();
            }
        }

        private void daramadBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                vaziatBox.Focus();
            }


        }

        private void vaziatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                dollar1Box.Focus();
            }
        }

        private void dollar1Box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                dollar2Box.Focus();

            }
        }

        private void dollar2Box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                tarikh1Box.Focus();
            }
        }

        private void tarikh1Box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                tarikh2Box.Focus();
            }
        }

        private void tarikh2Box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                nahvePardakhtBox.Focus();
            }
        }

        private void nahvePardakhtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                shakhsBox.Focus();
            }
        }

        private void shakhsBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                phoneBox.Focus();
            }
        }

        private void phoneBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                /*string onvanproje = onvanProjeBox.Text;
                Program.Data.Add(onvanproje + " ,");
                string tedad = tedadBox.Text;
                Program.Data.Add(tedad + " ,");
                string gheimat = gheimatBox.Text;
                Program.Data.Add(gheimat + " ,");
                string daramad = daramadBox.Text;
                Program.Data.Add(daramad + " ,");
                string vaziat = vaziatBox.Text;
                Program.Data.Add(vaziat + " ,");
                string dollar1 = dollar1Box.Text;
                Program.Data.Add(dollar1 + " ,");
                string dollar2 = dollar2Box.Text;
                Program.Data.Add(dollar2 + " ,");
                string tarikh1 = tarikh1Box.Text;
                Program.Data.Add(tarikh1 + " ,");
                string tarikh2 = tarikh2Box.Text;
                Program.Data.Add(tarikh2 + " ,");
                string nahvepardakht = nahvePardakhtBox.Text;
                Program.Data.Add(nahvepardakht + " ,");
                string shakhs = shakhsBox.Text;
                Program.Data.Add(shakhs + " ,");
                string phone = phoneBox.Text;
                Program.Data.Add(phone + " ,");*/
                button1.Focus();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Program.Data.Add(onvanProjeBox.Text + " ,");
            
            Program.Data.Add(tedadBox.Text + " ,");
            
            Program.Data.Add(gheimatBox.Text + " ,");
            
            Program.Data.Add(daramadBox.Text + " ,");
            
            Program.Data.Add(vaziatBox.Text + " ,");
            
            Program.Data.Add(dollar1Box.Text + " ,");
            
            Program.Data.Add(dollar2Box.Text + " ,");
            
            Program.Data.Add(tarikh1Box.Text + " ,");
            
            Program.Data.Add(tarikh2Box.Text + " ,");
            
            Program.Data.Add(nahvePardakhtBox.Text + " ,");
            
            Program.Data.Add(shakhsBox.Text + " ,");
            
            Program.Data.Add(phoneBox.Text + " ,");


            string message = "Do you want to save?";
            string title = "alert";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                
                StringBuilder final = new StringBuilder();
                for (int i = Program.Data.Count - 1; i > -1; i--)
                {
                    final.Append(Program.Data[i]);

                }


                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string address = $"{path}/abarnic.csv";
                if (!File.Exists(address))
                {
                    using (StreamWriter writer = new StreamWriter(address, true, Encoding.UTF8))
                    {

                        writer.WriteLine("شماره تماس,شخص,نحوه پرداخت وجه,تاریخ تحویل,تاریخ سفارش,دلار زمان تحویل,دلار زمان سفارش,وضعیت,درآمد,قیمت,تعداد,عنوان پروژه");
                    }
                }
                using (StreamWriter writer = new StreamWriter(address, true, Encoding.UTF8))
                {

                    writer.WriteLine(final.ToString());
                }
                System.Environment.Exit(0);


            }


            if (result == DialogResult.No)
            {
                System.Environment.Exit(0);
            }



        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            string onvanproje = onvanProjeBox.Text;
            Program.Data.Add(onvanproje + " ,");
            string tedad = tedadBox.Text;
            Program.Data.Add(tedad + " ,");
            string gheimat = gheimatBox.Text;
            Program.Data.Add(gheimat + " ,");
            string daramad = daramadBox.Text;
            Program.Data.Add(daramad + " ,");
            string vaziat = vaziatBox.Text;
            Program.Data.Add(vaziat + " ,");
            string dollar1 = dollar1Box.Text;
            Program.Data.Add(dollar1 + " ,");
            string dollar2 = dollar2Box.Text;
            Program.Data.Add(dollar2 + " ,");
            string tarikh1 = tarikh1Box.Text;
            Program.Data.Add(tarikh1 + " ,");
            string tarikh2 = tarikh2Box.Text;
            Program.Data.Add(tarikh2 + " ,");
            string nahvepardakht = nahvePardakhtBox.Text;
            Program.Data.Add(nahvepardakht + " ,");
            string shakhs = shakhsBox.Text;
            Program.Data.Add(shakhs + " ,");
            string phone = phoneBox.Text;
            Program.Data.Add(phone + " ,");
            if (e.KeyData == Keys.Enter)
            {
                string message = "Do you want to save?";
                string title = "alert";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                        StringBuilder final = new StringBuilder();
                        for (int i = Program.Data.Count - 1; i > -1; i--)
                        {
                            final.Append(Program.Data[i]);

                        }


                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string address = $"{path}/abarnic.csv";
                        if (!File.Exists(address))
                        {
                            using (StreamWriter writer = new StreamWriter(address, true, Encoding.UTF8))
                            {

                                writer.WriteLine("");
                            }
                        }
                        using (StreamWriter writer = new StreamWriter(address, true, Encoding.UTF8))
                        {

                            writer.WriteLine(final.ToString());
                        }
                        System.Environment.Exit(0);


                }


                if (result == DialogResult.No)
                {
                    System.Environment.Exit(0);
                }

            }
        }






    }
}
