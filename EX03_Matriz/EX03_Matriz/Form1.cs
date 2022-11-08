using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX03_Matriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vet = new int[6];
            int[,] matriz = new int[4, 6];

            Random n = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = n.Next(2);
                    lbldados.Text += matriz[i, j].ToString("00") + "   ";
                }
                lbldados.Text += "\n";

            }
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                vet[j] = matriz[0, j] + matriz[1, j] + matriz[2, j] + matriz[3, j];
                lblvet.Text += vet[j].ToString() + " ";
            }

            lbltotaldados.Text = vet.Sum().ToString();
        }
    }
}
