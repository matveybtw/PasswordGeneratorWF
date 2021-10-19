using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            if (cb1.Checked==false&& cb2.Checked == false&&cb3.Checked == false&& cb4.Checked == false)
            {
                MessageBox.Show("None of the options selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numUpDown.Value==0)
            {
                MessageBox.Show("Length is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string letters = "qwertyuiopasdfghjklzxcvbnm";
                string capitalletters = "QWERTYUIOPASDFGHJKLZXCVBNM";
                string nums = "0123456789";
                string symbols = "`~!@#$%^&*()_+-={[}]:;\"\'<,>.?/№|";
                Random r = new Random();
                int v;
                bool valid;
                string pass = "";
                for (int i = 0; i < numUpDown.Value; i++)
                {

                    do
                    {
                        valid = true;
                        v = r.Next(1, 5);
                        switch (v)
                        {
                            case 1:
                                if (cb1.Checked)
                                {
                                    pass += letters[r.Next(0, letters.Length - 1)];
                                }
                                else
                                {
                                    valid = false;
                                }
                                break;
                            case 2:
                                if (cb2.Checked)
                                {
                                    pass += capitalletters[r.Next(0, capitalletters.Length - 1)];
                                }
                                else
                                {
                                    valid = false;
                                }
                                break;
                            case 3:
                                if (cb3.Checked)
                                {
                                    pass += nums[r.Next(0, nums.Length - 1)];
                                }
                                else
                                {
                                    valid = false;
                                }
                                break;
                            case 4:
                                if (cb4.Checked)
                                {
                                    pass += symbols[r.Next(0, symbols.Length - 1)];
                                }
                                else
                                {
                                    valid = false;
                                }
                                break;
                        }
                    } while (!valid);
                }
                textBox1.Text = pass;
            }
            
        }

        private void buffer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                Clipboard.SetText(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Password is empty","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
    
}
