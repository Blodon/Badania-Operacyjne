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

        Random rnd = new Random();

        string ShowTable;

        double[,] cena = new double[4, 100];

        double[,] slod = new double[4, 100];
        double[,] chmiel = new double[4, 100];
        double[,] woda = new double[4, 100];

        double[] ograniczenieSlod = new double[100];
        double[] ograniczenieChmiel = new double[100];
        double[] ograniczenieWoda = new double[100];
        public MainForm()
        {
            int dym = 100;
            double[] a = new double[dym];
            double[,] b = new double[dym,dym];
            double[] c = new double[dym];

            for(int i = 0; i < dym; i++){
                a[i] = 1;
                for (int j=0;j<dym;j++) b[i, j] = i;
                c[i] = i;
            }


            InitializeComponent();
        }
        private void RTB_Table_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BUTTON_GenerateTable_Click(object sender, EventArgs e)
        {
            for(int powtorzenia = 0; powtorzenia < 100; powtorzenia++)
            {
                for(int piwo = 0; piwo < 4; piwo++)
                {
                    cena[piwo, powtorzenia] = rnd.Next(1,10);
                    slod[piwo, powtorzenia] = rnd.Next(3, 15);
                    chmiel[piwo, powtorzenia] = rnd.Next(2, 20);
                    woda[piwo, powtorzenia] = rnd.Next(1, 10);
                }

                ograniczenieSlod[powtorzenia] = rnd.Next(1000, 2000);
                ograniczenieChmiel[powtorzenia] = rnd.Next(1000, 2000);
                ograniczenieWoda[powtorzenia] = rnd.Next(1000, 2000);

            }
        }

        private void BUTTON_StartSimAnno_Click(object sender, EventArgs e)
        {

        }

        private void BUTTON_ShowTable_Click(object sender, EventArgs e)
        {
            RTB_Table.Clear();

            ShowTable = "";
            for (int powtorzenia = 0; powtorzenia < 100; powtorzenia++)
            {
                ShowTable += "tabela ";
                ShowTable += powtorzenia + 1;
                ShowTable += "\nPiwo:";

                for (int piwo = 0; piwo < 4; piwo++)
                {
                    ShowTable += "\tPiwo";
                    ShowTable += piwo;
                }
                ShowTable += "\tZasób:";


                ShowTable += "\nSlod:";
                for (int piwo = 0; piwo < 4; piwo++)
                {
                    ShowTable += "\t";
                    ShowTable += slod[piwo, powtorzenia];
                }
                ShowTable += "\t";
                ShowTable += ograniczenieSlod[powtorzenia];


                ShowTable += "\nChmiel:";
                for (int piwo = 0; piwo < 4; piwo++)
                {
                    ShowTable += "\t";
                    ShowTable += chmiel[piwo, powtorzenia];
                }
                ShowTable += "\t";
                ShowTable += ograniczenieChmiel[powtorzenia];


                ShowTable += "\nWoda:";
                for (int piwo = 0; piwo < 4; piwo++)
                {
                    ShowTable += "\t";
                    ShowTable += woda[piwo, powtorzenia];
                }
                ShowTable += "\t";
                ShowTable += ograniczenieWoda[powtorzenia];


                ShowTable += "\nCena:";
                for (int piwo = 0; piwo < 4; piwo++)
                {
                    ShowTable += "\t";
                    ShowTable += cena[piwo, powtorzenia];
                }

                ShowTable += "\n\n";
            }
            RTB_Table.Text = ShowTable;
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

        private void textSimplex_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
