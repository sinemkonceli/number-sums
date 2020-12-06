using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekÇiftToplamalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
           
                if (sayi1 % 2 == 0)
                {
                    lblÇift.Text = (Convert.ToInt32(lblÇift.Text) + sayi1).ToString();
                }
           
            else
            {

                lblTek.Text = (Convert.ToInt32(lblTek.Text) + sayi1).ToString();
                
            }
            MessageBox.Show("Tek Toplam:" + lblTek.Text+ " Çift Toplam:" + lblÇift.Text);

        }


    }
    }

