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
            int[] numeros = new int[50];

            Random n = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = n.Next(200);
                lstnumeros.Items.Add(numeros[i]);

            }
            lstnumeros2.Items.Add(numeros.Max());
        }
    }
}
