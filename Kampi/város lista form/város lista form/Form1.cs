using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace város_lista_form
{

    public partial class Form1 : Form
    {
        List<string> towns = new List<string> { "Dóc", "Baks", "Felgyő", "Csanytelek", "Csongrád", "Tiszakécske", "Nádudvar", };

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //towns_combo.Items.Add(a város)
            foreach (var item in towns)
            {
                string városok = item;
                Combobox1.Items.Add(városok);
            }
        }
    }
}
