using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParolaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Cevapla";
            soruNo++;
            this.Text=soruNo.ToString();

            if( soruNo == 1 ) 
            {
                richTextBox1.Text = "Ülkemizin alt tarfındaki denizin ismi? ";
                button4.BackColor = Color.Yellow;
            }
            if ( soruNo == 2 )
            {
                richTextBox1.Text = "BursaSpor  hangi ilin takımıdır?";
                button5.BackColor = Color.Yellow;
            }
            if( soruNo == 3 )
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button6.BackColor = Color.Yellow;
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü İlimiz?";
                button7.BackColor = Color.Yellow;
            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                button8.BackColor = Color.Yellow;
            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Padişahın Emirlerinin Yazıldığı kağıda verilen isim?";
                button9.BackColor = Color.Yellow;
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button10.BackColor = Color.Yellow;
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Salatalığın diğer ismi?";
                button11.BackColor = Color.Yellow;
            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "Gülü ile Ünlü ilimiz?";
                button12.BackColor = Color.Yellow;
            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Yeni bir buluşa verilen isim ?";
                button13.BackColor = Color.Yellow;
            }

        }
    }
}
