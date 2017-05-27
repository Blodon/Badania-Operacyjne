using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Optymalizacja_produkcji.Methods.Linear_Methods;

namespace Optymalizacja_produkcji
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void BUTTON_StartSimplex_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            double[] c = { 30, 20 };
            double[,] A = { {2,1 }, {3,3}, {1.5,0} };
            double[] b = { 1000, 2400, 600 };

            Simplex simplex = new Simplex(c, A, b);

            textSimplex.Text = simplex.maximize().Item1.ToString();
        }

        private void RTB_Table_TextChanged(object sender, EventArgs e)
        {
        }

        private void textSimplex_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
