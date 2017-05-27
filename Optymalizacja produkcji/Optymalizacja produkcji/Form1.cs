using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optymalizacja_produkcji
{
    public partial class MainForm : Form
    {

        Random rnd = new Random();

        string ShowTable;
        int piwa = 4;

        double[,] cena = new double[4, 100];

        double slodMax;
        double chmielMax;
        double wodaMax;

        double[,] slod = new double[4, 100];
        double[,] chmiel = new double[4, 100];
        double[,] woda = new double[4, 100];


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
            for(int piwo = 0; piwo < 4; piwo++)
            {
                for(int powtorzenia = 0; powtorzenia < 100; powtorzenia++)
                {
                    cena[piwo, powtorzenia] = rnd.Next(1,10);
                    slod[piwo, powtorzenia] = rnd.Next(3, 15);
                    chmiel[piwo, powtorzenia] = rnd.Next(2, 20);
                    woda[piwo, powtorzenia] = rnd.Next(1, 10);
                }

            }
        }

        private void BUTTON_StartSimplex_Click(object sender, EventArgs e)
        {

        }

        private void BUTTON_StartSimAnno_Click(object sender, EventArgs e)
        {

        }

        private void BUTTON_ShowTable_Click(object sender, EventArgs e)
        {
            ShowTable = "";
            for (int powtorzenia = 0; powtorzenia < 100; powtorzenia++)
            {
                RTB_Table.Clear();
                ShowTable += "tabela ";
                ShowTable += powtorzenia + 1;
                ShowTable += "\nPiwo:";
                for (int piwo = 0; piwo < 4; piwo++)
                {
                    ShowTable += "\tPiwo";
                    ShowTable += piwo;
                }
                ShowTable += "\nCena:";
                for (int piwo = 0; piwo < 4; piwo++)
                {
                    ShowTable += "\t";
                    ShowTable += cena[piwo,powtorzenia];
                }
                ShowTable += "\nSlod:";
                for (int piwo = 0; piwo < 4; piwo++)
                {
                    ShowTable += "\t";
                    ShowTable += slod[piwo, powtorzenia];
                }
                ShowTable += "\nChmiel:";
                for (int piwo = 0; piwo < 4; piwo++)
                {
                    ShowTable += "\t";
                    ShowTable += chmiel[piwo, powtorzenia];
                }
                ShowTable += "\nWoda:";
                for (int piwo = 0; piwo < 4; piwo++)
                {
                    ShowTable += "\t";
                    ShowTable += woda[piwo, powtorzenia];
                }
                ShowTable += "\n\n";
            }
            RTB_Table.Text = ShowTable;
        }
        
    }
}
