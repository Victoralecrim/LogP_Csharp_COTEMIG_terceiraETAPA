using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX09PAG73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngerarnumeros_Click(object sender, EventArgs e)
        {
            int[] vet = new int[100];
            int soma = 0;
            double media = 0;
            Random r = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = r.Next(100);
                lstnumeros.Items.Add(vet[i]);

                soma += vet[i];
                
            }

            lblmaiornumero.Text = "O maior elemento é: " + Convert.ToString(vet.Max());
            lblmenornumero.Text = "O menor elemento é: " + Convert.ToString(vet.Min());

            media = soma / vet.Length;

            lblmedia.Text = "A média dos elementos é: " + media.ToString();
        }
    }
}
