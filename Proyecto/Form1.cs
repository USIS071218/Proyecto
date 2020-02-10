using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtFibonacci.Text), A = 0, B = 1, SM, i;
            string Answer1 = "";
            for (i = 0; i < N; i++)
            {
                SM = A;
                A = B;
                B = SM + A;
                Answer1 += "LA SUMATORIA DE  " + A + " ES " + B + "\n";
                lblfibonacci.Text = Answer1;
                txtFibonacci.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
        
        

        





