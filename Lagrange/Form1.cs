using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagrange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(textBox1.Text);
            double v2 = Convert.ToDouble(textBox5.Text);
            double v3 = Convert.ToDouble(textBox6.Text);
            double v4 = Convert.ToDouble(textBox2.Text);

            double v5 = Convert.ToDouble(textBox9.Text);
            double A0 = Convert.ToDouble(textBox10.Text);
            double A1 = Convert.ToDouble(textBox11.Text);


            //

            double P1 = A0*(v5 - v3) + A1*(v5 - v2);

            //




            textBox12.Text = P1.ToString() + "°c";



        }

        private void button2_Click(object sender, EventArgs e)
        {

            double v1 = Convert.ToDouble(textBox1.Text);
            double v2 = Convert.ToDouble(textBox5.Text);
            double v3 = Convert.ToDouble(textBox6.Text);
            double v4 = Convert.ToDouble(textBox2.Text);
            double v5 = Convert.ToDouble(textBox3.Text);
            double v6 = Convert.ToDouble(textBox7.Text);
            double v7 = Convert.ToDouble(textBox9.Text);

            double a0 = Convert.ToDouble(textBox15.Text);
            double a1 = Convert.ToDouble(textBox14.Text);
            double a2 = Convert.ToDouble(textBox16.Text);


            //

            double P2 = a0 * ((v7-v3)*(v7-v6)) + a1 * ((v7-v2)*(v7-v6)) + a2 * ((v7-v2)*(v7-v3)) ;

            //




            textBox13.Text = P2.ToString() + "°c";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(textBox1.Text);
            double v2 = Convert.ToDouble(textBox5.Text);
            double v3 = Convert.ToDouble(textBox6.Text);
            double v4 = Convert.ToDouble(textBox2.Text);
            double v5 = Convert.ToDouble(textBox3.Text);
            double v6 = Convert.ToDouble(textBox7.Text);

            //


            double A0 = v1 / (v2 - v3);
            double A1 = v4 / (v3 - v2);

            //


            double a0 = v1 / ((v2-v3) * (v2-v6));
            double a1 = v4 / ((v3 - v2) * (v3 - v6));
            double a2 = v5 / ((v6 - v2) * (v6 - v3));


            //


            textBox10.Text = A0.ToString();
            textBox11.Text = A1.ToString();

            //

            textBox15.Text = a0.ToString();
            textBox14.Text = a1.ToString();
            textBox16.Text = a2.ToString();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();

            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();

                
        }
    }
}
