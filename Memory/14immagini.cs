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
    //codice per 14 immagini
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        PictureBox pselected1 = null;
        PictureBox pselected2 = null;
        Image[,] arrimmagine = new Image[4, 7];//da 28 perchè le immagini sono 2
        Random rd = new Random();//nomina random
        int punti = 0;//punteggio
        int countImm = 0;//aggiunta numero immagini

        private void azzeramento()//azzeramento di tutto
        {
            pictureBox1.BackgroundImage = null;
            pictureBox2.BackgroundImage = null;
            pictureBox3.BackgroundImage = null;
            pictureBox4.BackgroundImage = null;
            pictureBox5.BackgroundImage = null;
            pictureBox6.BackgroundImage = null;
            pictureBox7.BackgroundImage = null;
            pictureBox8.BackgroundImage = null;
            pictureBox9.BackgroundImage = null;
            pictureBox10.BackgroundImage = null;
            pictureBox11.BackgroundImage = null;
            pictureBox12.BackgroundImage = null;
            pictureBox13.BackgroundImage = null;
            pictureBox14.BackgroundImage = null;
            pictureBox15.BackgroundImage = null;
            pictureBox16.BackgroundImage = null;
            pictureBox17.BackgroundImage = null;
            pictureBox18.BackgroundImage = null;
            pictureBox19.BackgroundImage = null;
            pictureBox20.BackgroundImage = null;
            pictureBox21.BackgroundImage = null;
            pictureBox22.BackgroundImage = null;
            pictureBox23.BackgroundImage = null;
            pictureBox24.BackgroundImage = null;
            pictureBox25.BackgroundImage = null;
            pictureBox26.BackgroundImage = null;
            pictureBox27.BackgroundImage = null;
            pictureBox28.BackgroundImage = null;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            pictureBox17.Enabled = true;
            pictureBox18.Enabled = true;
            pictureBox19.Enabled = true;
            pictureBox20.Enabled = true;
            pictureBox21.Enabled = true;
            pictureBox22.Enabled = true;
            pictureBox23.Enabled = true;
            pictureBox24.Enabled = true;
            pictureBox25.Enabled = true;
            pictureBox26.Enabled = true;
            pictureBox27.Enabled = true;
            pictureBox28.Enabled = true;
            punti = 0;//punteggio
            lbtimer.Text = punti.ToString();//mostra lo 0 nella label
            countImm = 0;//aggiunta numero immagini
        }
        private void cambio(int x1, int x2, int y1, int y2)//switch Immagini
        {
            Image ImmagineDiCambio = arrimmagine[x1, y1];//"Immagine di cambio" è un'immagine vuota 
            arrimmagine[x1, y1] = arrimmagine[x2, y2];
            arrimmagine[x2, y2] = ImmagineDiCambio;
        }
        private void fine(int count)
        {
            lbtimer.Text = punti.ToString();//inserisce punti alla label
            Thread.Sleep(500);//aspetta 0.5 secondi
            if (count == 14)
            {
                MessageBox.Show("hai finito il gioco,\n " + "hai totalizzato: " + punti + " punti");//messaggio finale
                lbmessaggio.Text = "Clicca INIZIA per mescolare le carte";
            }

        }
        private void controllo()
        {
            if (pselected1 != null && pselected2 != null)
            {
                Thread.Sleep(1000);//aspetta 1 secondo
                if (pselected1.BackgroundImage == pselected2.BackgroundImage)//controlla se le immagini sono uguali
                {
                    MessageBox.Show("uguale " + " " + "+ 1 punto ");
                    punti++;//aggiorna punti
                    countImm++;//aggiornamento count immagine
                    pselected1.Enabled = false;//non si può più premere
                    pselected2.Enabled = false;//non si può più premere
                    pselected1 = null;//rimette pselected1 a null
                    pselected2 = null;//rimette pselected2 a null
                    fine(countImm);//inutile coutnImm però sti cazzi non ho voglia di cancellarlo
                }
                else
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
                lbtimer.Text = punti.ToString();//inserisce punti alla label
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
                a.BackgroundImage = arrimmagine[0, 3];//richiama l'immagine 
            }

            else if (a == pictureBox5)
            {
                a.BackgroundImage = arrimmagine[0,4];//richiama l'immagine
            }

            else if (a == pictureBox6)
            {
                a.BackgroundImage = arrimmagine[0,5];//richiama l'immagine 
            }
            else if (a == pictureBox7)
            {
                a.BackgroundImage = arrimmagine[0,6];//richiama l'immagine 
            }
            else if (a == pictureBox8)
            {
                a.BackgroundImage = arrimmagine[1, 0];//richiama l'immagine 
            }
            else if (a == pictureBox9)
            {
                a.BackgroundImage = arrimmagine[1,1];//richiama l'immagine 

            }
            else if (a == pictureBox10)
            {
                a.BackgroundImage = arrimmagine[1,2];//richiama l'immagine

            }
            else if (a == pictureBox11)
            {
                a.BackgroundImage = arrimmagine[1, 3];//richiama l'immagine 
            }

            else if (a == pictureBox12)
            {
                a.BackgroundImage = arrimmagine[1, 4];//richiama l'immagine
            }

            else if (a == pictureBox13)
            {
                a.BackgroundImage = arrimmagine[1, 5];//richiama l'immagine 
            }
            else if (a == pictureBox14)
            {
                a.BackgroundImage = arrimmagine[1,6];//richiama l'immagine 
            }
            else if (a == pictureBox15)
            {
                a.BackgroundImage = arrimmagine[2,0];//richiama l'immagine 
            }
            else if (a == pictureBox16)
            {
                a.BackgroundImage = arrimmagine[2,1];//richiama l'immagine 

            }
            else if (a == pictureBox17)
            {
                a.BackgroundImage = arrimmagine[2,2];//richiama l'immagine

            }
            else if (a == pictureBox18)
            {
                a.BackgroundImage = arrimmagine[2,3];//richiama l'immagine 
            }

            else if (a == pictureBox19)
            {
                a.BackgroundImage = arrimmagine[2,4];//richiama l'immagine
            }

            else if (a == pictureBox20)
            {
                a.BackgroundImage = arrimmagine[2,5];//richiama l'immagine 
            }
            else if (a == pictureBox21)
            {
                a.BackgroundImage = arrimmagine[2,6];//richiama l'immagine 
            }
            else if (a == pictureBox22)
            {
                a.BackgroundImage = arrimmagine[3, 0];//richiama l'immagine 
            }
            else if (a == pictureBox23)
            {
                a.BackgroundImage = arrimmagine[3, 1];//richiama l'immagine 

            }
            else if (a == pictureBox24)
            {
                a.BackgroundImage = arrimmagine[3, 2];//richiama l'immagine

            }
            else if (a == pictureBox25)
            {
                a.BackgroundImage = arrimmagine[3, 3];//richiama l'immagine 
            }

            else if (a == pictureBox26)
            {
                a.BackgroundImage = arrimmagine[3, 4];//richiama l'immagine
            }

            else if (a == pictureBox27)
            {
                a.BackgroundImage = arrimmagine[3, 5];//richiama l'immagine 
            }
            else if (a == pictureBox28)
            {
                a.BackgroundImage = arrimmagine[3, 6];//richiama l'immagine 
            }
            if (pselected1 == null)
                pselected1 = a;
            else
                pselected2 = a;
            a.Enabled = false;//ci vuole altrimenti si bugga
            controllo();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //timer1.Interval = 1000;//in millisecondi(1 secondo) è la velocità in cui si muovi il conometro
            //timer1.Enabled = false;//fermo a 0 o per disattivare, per attivarlo usare il true
            lbmessaggio.Text = "Clicca INIZIA per mescolare le carte";
            azzeramento();
            Image Imm0 = Image.FromFile(@"immagini\0.png");//richiama l'immagine 0 dalla cartella
            Image Imm1 = Image.FromFile(@"immagini\1.png");//richiama l'immagine 1 dalla cartella
            Image Imm2 = Image.FromFile(@"immagini\2.png");//richiama l'immagine 2 dalla cartella
            Image Imm3 = Image.FromFile(@"immagini\3.png");//richiama l'immagine 3 dalla cartella
            Image Imm4 = Image.FromFile(@"immagini\4.png");//richiama l'immagine 4 dalla cartella
            Image Imm5 = Image.FromFile(@"immagini\5.png");//richiama l'immagine 5 dalla cartella
            Image Imm6 = Image.FromFile(@"immagini\6.png");//richiama l'immagine 6 dalla cartella
            Image Imm7 = Image.FromFile(@"immagini\7.png");//richiama l'immagine 7 dalla cartella
            Image Imm8 = Image.FromFile(@"immagini\8.png");//richiama l'immagine 8 dalla cartella
            Image Imm9 = Image.FromFile(@"immagini\9.png");//richiama l'immagine 9 dalla cartella
            Image Imm10 = Image.FromFile(@"immagini\10.png");//richiama l'immagine 10 dalla cartella
            Image Imm11 = Image.FromFile(@"immagini\11.png");//richiama l'immagine 11 dalla cartella
            Image Imm12= Image.FromFile(@"immagini\12.png");//richiama l'immagine 12 dalla cartella
            Image Imm13 = Image.FromFile(@"immagini\13.png");//richiama l'immagine 13 dalla cartella



            //inserisco singolarmente l'immagine altrimenti il pc non lo accetta con l'inserimento automatico(come rappresentato nel commento sotto)
            arrimmagine[0, 0] = Imm0;
            arrimmagine[0, 1] = Imm0;
            arrimmagine[0, 2] = Imm1;
            arrimmagine[0, 3] = Imm1;
            arrimmagine[0, 4] = Imm2;
            arrimmagine[0, 5] = Imm2;
            arrimmagine[0, 6] = Imm3;
            arrimmagine[1, 0] = Imm3;
            arrimmagine[1, 1] = Imm4;
            arrimmagine[1, 2] = Imm4;
            arrimmagine[1, 3] = Imm5;
            arrimmagine[1, 4] = Imm5;
            arrimmagine[1, 5] = Imm6;
            arrimmagine[1, 6] = Imm6;
            arrimmagine[2, 0] = Imm7;
            arrimmagine[2, 1] = Imm7;
            arrimmagine[2, 2] = Imm8;
            arrimmagine[2, 3] = Imm8;
            arrimmagine[2, 4] = Imm9;
            arrimmagine[2, 5] = Imm9;
            arrimmagine[2, 6] = Imm10;
            arrimmagine[3, 0] = Imm10;
            arrimmagine[3, 1] = Imm11;
            arrimmagine[3, 2] = Imm11;
            arrimmagine[3, 3] = Imm12;
            arrimmagine[3, 4] = Imm12;
            arrimmagine[3, 5] = Imm13;
            arrimmagine[3, 6] = Imm13;

            //int i = 0;
            //for (int y = 0; y < 3; y++)
            //{
            // arrimmagine[0, y] = Image.FromFile(@"immagini\" + i + ".png");//inserisce l'immagine nell'array
            //arrimmagine[1, y] = Image.FromFile(@"immagini\" + i + ".png");//inserisce l'immagine nell'array
            //i++;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            azzeramento();
            for(int i = 0; i < 28; i++)//per mescolare più volte le carte
            {
                int numerox1 = rd.Next(0, 4);//prende i numeri random per la x1
                int numerox2 = rd.Next(0, 4);//prende i numeri random per la x2
                int numeroy1 = rd.Next(0, 7);//prende i numeri random per la y1
                int numeroy2 = rd.Next(0, 7);//prende i numeri random per la y2
                cambio(numerox1, numerox2, numeroy1, numeroy2);
            }
            lbmessaggio.Text = "Carte mescolate, buon divertimento";
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
