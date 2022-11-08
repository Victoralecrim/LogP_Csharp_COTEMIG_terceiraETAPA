using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX05PÁG73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numeros = new int[100];
        int i;
        private void button1_Click(object sender, EventArgs e)
        {
            
            LSTNUMEROS.Items.Clear();

            Random r = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = r.Next(100);
                //LSTNUMEROS.Items.Add("[" + i + "] = " + numeros[i]);
                LSTNUMEROS.Items.Add($"[{i}] = {numeros[i]}");

                if (numeros[i] == 0)
                {
                    LSTNUMEROS.Items.Add("[" + i + "]");

                    lstzeros.Items.Add("[" + i + "]");
                    label1.Text += "[" + i + "] ";
                }
            }

            
        }

        private void btnposicao0_Click(object sender, EventArgs e)
        {
           

        }
    }
}
