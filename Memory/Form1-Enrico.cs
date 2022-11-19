using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace Memory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image[,] arrimmagine = new Image[2,3];//da 6 perchè le immagini sono 2
        Image Orange = Image.FromFile(@"immagini/arancio.png");//per "azzerare" la casella
        Random rd = new Random();
        int count = 2;//per il conto alla rovescia(dura 2 secondi)

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            int numerox1 = rd.Next(0, 2);
            int numerox2 = rd.Next(0, 2);
            int numeroy1 = rd.Next(0, 3);
            int numeroy2 = rd.Next(0, 3);
            cambio(numerox1, numerox2, numeroy1, numeroy2);
        }
        private void cambio(int x1,int x2,int y1,int y2)//switch Immagini
        {
            Image ImmagineDiCambio = arrimmagine[x1, y1];
            arrimmagine[x1, y1] = arrimmagine[x2, y2];
            arrimmagine[x2, y2] = ImmagineDiCambio;
        }
        private void controllo()
        {
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            var a = (PictureBox)sender;//la funzione è stata ampliata poi nella parte grafica
            if (a == pictureBox1)
            {
                a.BackgroundImage = arrimmagine[0, 0];//richiama l'immagine              
                //Thread.Sleep(2000);//lo ferma per 2 secondi
                a.BackgroundImage = Orange;
                a.Enabled = false;//non si può più premere
            }
            else if(a == pictureBox2)
            {
                a.BackgroundImage = arrimmagine[0, 1];//richiama l'immagine 
                a.Enabled = false;//non si può più premere
            }
            else if (a == pictureBox3)
            {
                a.BackgroundImage = arrimmagine[0, 2];//richiama l'immagine 
                a.Enabled = false;//non si può più premere
            }
            else if (a == pictureBox4)
            {
                a.BackgroundImage = arrimmagine[1, 0];//richiama l'immagine 
                a.Enabled = false;//non si può più premere
            }
            else if (a == pictureBox5)
            {
                a.BackgroundImage = arrimmagine[1, 1];//richiama l'immagine 
                a.Enabled = false;//non si può più premere
            }
            else if (a == pictureBox6)
            {
                a.BackgroundImage = arrimmagine[1, 2];//richiama l'immagine 
                a.Enabled = false;//non si può più premere
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;//in millisecondi(1 secondo) è la velocità in cui si muovi il conometro
            timer1.Enabled = false;//fermo a 0 o per disattivare, per attivarlo usare il true
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;

            int i = 0;
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    arrimmagine[x, y] = Image.FromFile(@"immagini\" + i + ".png");//inserisce l'immagine nell'array
                    i++;
                }
            }   
        }
    }
}
