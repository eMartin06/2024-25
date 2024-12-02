using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_számológép
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            float a_value = float.Parse(a.Text);
            float b_value = float.Parse(b.Text);
            int melyikmuv = muvelet.SelectedIndex;
            if (melyikmuv == -1)
                MessageBox.Show("Válassz műveletet!");
            else
            {
                string muv = muvelet.Items[melyikmuv].ToString();
                // muv változóban * / - + valamelyike lesz
                switch (muv)
                {
                    case "*":
                        result.Text = (a_value * b_value).ToString();
                        break;
                    case "/":
                        result.Text = (a_value / b_value).ToString();
                        break;
                    case "+":
                        result.Text = (a_value + b_value).ToString();
                        break;
                    case "-":
                        result.Text = (a_value - b_value).ToString();
                        break;
                }
            }


        }

        private void a_TextChanged(object sender, EventArgs e)
        {
        }

        private void b_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
