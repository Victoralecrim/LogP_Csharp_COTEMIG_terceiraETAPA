using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX03_PAG72
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[20];

            Random n = new Random();

            for (int i = 0; i < 20; i++)
            {
                numeros[i] = n.Next(100);

                if(numeros[i] > 50)
                {
                    LSTNUMEROS.Items.Add(numeros[i]);
                }
            }
        }
    }
}
