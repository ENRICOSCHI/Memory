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

namespace Memory
{
    //codice per la form con 3 immagini
    public partial class Form1 : Form
    {
        PictureBox pselected1 = null;
        PictureBox pselected2 = null;
        public Form1()
        {
            InitializeComponent();
        }
        Image[,] arrimmagine = new Image[2,3];//da 6 perchè le immagini sono 2
        Random rd = new Random();//nomina random
        int punti = 0;//punteggio
        int countImm = 0;//aggiunta numero immagini
        Image verde = Image.FromFile(@"immagini\green2.png");//immagine per la piccola animazione


        private void azzeramento()//azzeramento di tutto
        {
            pictureBox1.BackgroundImage = null;
            pictureBox2.BackgroundImage = null;
            pictureBox3.BackgroundImage = null;
            pictureBox4.BackgroundImage = null;
            pictureBox5.BackgroundImage = null;
            pictureBox6.BackgroundImage = null;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            punti = 0;//punteggio
            lbltimer.Text = punti.ToString();//mostra lo 0 nella label
            countImm = 0;//aggiunta numero immagini
        }
        private void button1_Click(object sender, EventArgs e)
        {
            azzeramento();
            int numerox1 = rd.Next(0, 2);//prende i numeri random per la x1
            int numerox2 = rd.Next(0, 2);//prende i numeri random per la x2
            int numeroy1 = rd.Next(0, 3);//prende i numeri random per la y1
            int numeroy2 = rd.Next(0, 3);//prende i numeri random per la y2
            cambio(numerox1, numerox2, numeroy1, numeroy2);
            lbmessaggio.Text= "Carte mescolate, buon divertimento";//cambio del messaggio per far capire che le carte sono state mescolate
        }
        private void cambio(int x1,int x2,int y1,int y2)//switch Immagini
        {
            Image ImmagineDiCambio = arrimmagine[x1, y1];//"Immagine di cambio" è un'immagine vuota 
            arrimmagine[x1, y1] = arrimmagine[x2, y2];
            arrimmagine[x2, y2] = ImmagineDiCambio;
        }
        private void fine(int count)
        {
            lbltimer.Text = punti.ToString();//inserisce punti alla label
            Thread.Sleep(500);//aspetta 0.5 secondi
            if (count == 3)
            {
                MessageBox.Show("hai finito il gioco,\n " + "hai totalizzato: " + punti + " punti");//messaggio finale
                lbmessaggio.Text = "Clicca INIZIA per mescolare le carte";//rimetto il messaggio che deve rimescolare le carte
            }
               
        }
        private void controllo()
        {
            if (pselected1 != null && pselected2 != null)
            {
                Thread.Sleep(1000);//aspetta 1 secondo
                if (pselected1.BackgroundImage == pselected2.BackgroundImage)//controlla se le immagini sono uguali
                {
                    MessageBox.Show("uguale "+ " "+ "+ 1 punto ");
                    punti++;//aggiorna punti
                    countImm++;//aggiornamento count immagine
                    pselected1.Enabled = false;//non si può più premere
                    pselected2.Enabled = false;//non si può più premere
                    pselected1 = null;//rimette pselected1 a null
                    pselected2 = null;//rimette pselected2 a null
                    fine(countImm);//inutile coutnImm però sti cazzi non ho voglia di cancellarlo
                }else
                {
                    MessageBox.Show("non uguale " + " " + " -1 punto ");
                    punti--;//aggiorna punti
                    pselected1.Enabled = true;//si può ancora cliccare
                    pselected2.Enabled = true;//si può ancora cliccare
                    pselected1.BackgroundImage = null;//rimette l'immagine arancione
                    pselected2.BackgroundImage = null;//rimette l'immagine arancione
                    pselected1 = null;//rimette pselected1 a null
                    pselected2 = null;//rimette pselected2 a null

                }
                lbltimer.Text = punti.ToString();//inserisce punti alla label
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            var a = (PictureBox)sender;//la funzione è stata ampliata poi nella parte grafica
            if (a == pictureBox1)
            {
                a.BackgroundImage = arrimmagine[0, 0];//richiama l'immagine
            }
            else if (a == pictureBox2)
            {
                a.BackgroundImage = arrimmagine[0, 1];//richiama l'immagine 

            }
            else if (a == pictureBox3)
            {
                a.BackgroundImage = arrimmagine[0, 2];//richiama l'immagine

            }
            else if (a == pictureBox4)
            {
                a.BackgroundImage = arrimmagine[1, 0];//richiama l'immagine 
            }

            else if (a == pictureBox5)
            {
                a.BackgroundImage = arrimmagine[1, 1];//richiama l'immagine
            }

            else if (a == pictureBox6)
            {
                a.BackgroundImage = arrimmagine[1, 2];//richiama l'immagine 
            }
            if (pselected1 == null)
                pselected1 = a;
            else
                pselected2 = a;
            a.Enabled = false;//ci vuole altrimenti si bugga
            controllo();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Interval = 1000;//in millisecondi(1 secondo) è la velocità in cui si muovi il conometro
            //timer1.Enabled = false;//fermo a 0 o per disattivare, per attivarlo usare il true
            lbmessaggio.Text = "Clicca INIZIA per mescolare le carte";//messaggio per far capire che deve mescolare le carte
            azzeramento();
            Image Imm0 = Image.FromFile(@"immagini\0.png");//richiama l'immagine 0 dalla cartella
            Image Imm1 = Image.FromFile(@"immagini\1.png");//richiama l'immagine 1 dalla cartella
            Image Imm2 = Image.FromFile(@"immagini\2.png");//richiama l'immagine 2 dalla cartella

            //inserisco singolarmente l'immagine altrimenti il pc non lo accetta con l'inserimento automatico(come rappresentato nel commento sotto)
            arrimmagine[0, 0] = Imm0;
            arrimmagine[1, 0] = Imm0;
            arrimmagine[0, 1] = Imm1;
            arrimmagine[1, 1] = Imm1;
            arrimmagine[0, 2] = Imm2;
            arrimmagine[1, 2] = Imm2;
            //int i = 0;
            //for (int y = 0; y < 3; y++)
            //{
            // arrimmagine[0, y] = Image.FromFile(@"immagini\" + i + ".png");//inserisce l'immagine nell'array
            //arrimmagine[1, y] = Image.FromFile(@"immagini\" + i + ".png");//inserisce l'immagine nell'array
            //i++;
            //}

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Index menu = new Index();
            menu.ShowDialog();//mostra il menu
            //this.Close();//chiude questa form quando schiacchi sulla x
            System.Windows.Forms.Application.ExitThread();//quando schiacchi la x chiude tutte le form aperte
        }
    }
}
