using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Index : Form
    {

        public Index()
        {
            InitializeComponent();
        }
        private void Index_Load(object sender, EventArgs e)
        {
            cmbPartita.Items.Add("3 figure");//inserisco nella combobox per la scelta del gioco
            cmbPartita.Items.Add("4 figure");//inserisco nella combobox per la scelta del gioco
            cmbPartita.Items.Add("14 figure");//inserisco nella combobox per la scelta del gioco
        }

        private void btAccetta_Click(object sender, EventArgs e)
        {
            if (cmbPartita.SelectedItem.ToString() == "3 figure")
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();//mostra la form 1 (3 immagini)
                System.Windows.Forms.Application.ExitThread();//quando schiacci la x chiude tutte le form aperte
            }
            else if (cmbPartita.SelectedItem.ToString() == "4 figure")
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();//mostra la form 2 (4 immagini)
                System.Windows.Forms.Application.ExitThread();//quando schiacci la x chiude tutte le form aperte
            }
            else if (cmbPartita.SelectedItem.ToString() == "14 figure")
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();//mostra la form 3 (14 immagini)
                System.Windows.Forms.Application.ExitThread();//quando schiacci la x chiude tutte le form aperte
            }
        }
    }
}
