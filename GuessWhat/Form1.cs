using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random randomNumber;
        int number;
        int sayac = 5;

        public void button1_Click(object sender, EventArgs e)
        {
            
            sayac--;
            if (sayac > 0)
            {
                if (Convert.ToInt16(textBox2.Text) > number)
                {
                    label2.Text = ("Tahmininiz Büyüktür.  " + sayac + " Hakınız kaldı.");
                }
                else if (Convert.ToInt16(textBox2.Text) < number)
                {
                    label2.Text = ("Tahmininiz Küçüktür - " + sayac + " Hakınız kaldı.");
                }
                else
                {
                    label2.Text = ("Saklanan Sayı : "+number);
                    MessageBox.Show("Tebrikler Buldunuz. " + number);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Bilemediniz Hakkınız Bitti. Saklanan Sayı : " + number);
                this.Close();
            }
            textBox2.Text = "";
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            randomNumber = new Random();
            number = randomNumber.Next(0, 100);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
