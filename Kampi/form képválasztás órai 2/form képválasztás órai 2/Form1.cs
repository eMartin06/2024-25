using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_képválasztás_órai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void képválasztó_FileOk(object sender, CancelEventArgs e)
        {
        
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            kép.Load(lista.SelectedItem.ToString());
        }

        private void gomb_Click(object sender, EventArgs e)
        {
            képválasztó.ShowDialog();
            kép.Load(képválasztó.FileName);
            lista.Items.Add(képválasztó.FileName);
        }
    }
}
