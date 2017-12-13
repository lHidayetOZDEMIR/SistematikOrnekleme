using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODEV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox5.Clear();
                double N = Convert.ToInt32(textBox1.Text);
                double n = Convert.ToInt32(textBox2.Text);
                double k = Math.Ceiling(N / n);
                Random rastgele = new Random();
                double sayi = rastgele.Next(0, (int)k + 1);
                label7.Text = k.ToString();
                label8.Text = sayi.ToString();
                textBox5.Text = sayi.ToString() + " \n";
                for (int i = 0; i < n - 1; i++)
                {

                    textBox5.Text += (sayi += k).ToString() + "\n ";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz Bilgiler Hatalıdır Kontrol Ediniz!", "HATA!");
            }
          
                
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
