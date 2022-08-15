using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] yazıTura = new string[] { "Yazı", "Tura" };
        private void btnFırlat_Click(object sender, EventArgs e)
        {
            while (true)
            {
                var random = new Random();
                int randomnumber = random.Next(2);
                string gelen = yazıTura[randomnumber];
                if(txtYazıTura.Text.ToLower()=="yazı" && gelen == "Yazı")
                {
                    MessageBox.Show("Yazı geldi kazandınız");
                    break;
                }
                else if(txtYazıTura.Text.ToLower()=="yazı" && gelen == "Tura")
                {
                    MessageBox.Show("Tura geldi Kaybettiniz");
                    break;
                }
                else if (txtYazıTura.Text.ToLower()=="tura" && gelen == "Tura")
                {
                    MessageBox.Show("Tura geldi kazandınız");
                    break;
                }
                else
                {
                    MessageBox.Show("Yazı geldi kaybettiniz");
                    break;
                }
            }
        }
    }
}
