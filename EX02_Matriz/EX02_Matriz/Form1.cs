using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX02_Matriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngerar_Click(object sender, EventArgs e)
        {
            int[,] mat =
            {
                { 0, 0, 0, 0, 0},
                { 1, 1, 1, 1, 1},
                { 2, 2, 2, 2, 2} };

            int i, j;
            for (i = 0; i < mat.GetLength(0); i++)
            {
                for (j = 0; j < mat.GetLength(1); j++)
                {
                    lblnumeros.Text += mat[i, j].ToString("00") + "    " ;
                }
                lblnumeros.Text += "\n";
            }
        }
    }
}
