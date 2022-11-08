using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX08PAG73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngerarnumeros_Click(object sender, EventArgs e)
        {
            Random n = new Random();

            int [] vet1 = new int[50];
            int [] vet2 = new int[50];
            int [] soma = new int[50];
            int [] subtracao = new int[50];

            lstvetor1.Items.Clear();
            lstvetor2.Items.Clear();
            lstsoma.Items.Clear();
            lstsubtracao.Items.Clear();

            for (int i = 0; i < vet1.Length; i++)
            {
                vet1[i] = n.Next(50);
                lstvetor1.Items.Add(vet1[i]);

                vet2[i] = n.Next(50);
                lstvetor2.Items.Add(vet2[i]);
            }

            for (int i = 0;i < soma.Length; i++)
            {
                soma[i] = vet1[i] + vet2[i];
                subtracao[i] = vet1[i] - vet2[i];

                lstsoma.Items.Add(soma[i]);
                lstsubtracao.Items.Add(subtracao[i]);

            }

          
        }

        
    }
}
