using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightTriangleProgram
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        double c = 0;

        public Form1()
        {
            InitializeComponent();

            txtA.Text = a.ToString();
            txtB.Text = b.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            updateHypotenuse();
        }

        public void updateHypotenuse()
        {
            if(txtA.Text != "" && txtB.Text != "")
            {
                try
                {
                    a = Convert.ToDouble(txtA.Text);
                    b = Convert.ToDouble(txtB.Text);

                    c = Math.Sqrt(a * a + b * b);

                    txtHypot.Text = c.ToString();
                }
                catch(Exception)
                {
                    txtHypot.Text = "Error";
                }
            }
            else
            {
                txtHypot.Text = "N\\A";
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            updateHypotenuse();
        }
    }
}
