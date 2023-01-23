using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Macierze_JR
{
    

    public partial class Pytanie : Form
    {
        bool dobrze = false;
       

        public int getNumber(int liczba)
        {
            return liczba;
        }

        public Pytanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorzy aut = new Autorzy();
            aut.Show();
        }

        private void wiersze_1_TextChanged(object sender, EventArgs e)
        {
                if (!Regex.IsMatch(liczba_punktow.Text, "^[1-9][0-9]*$"))
                {
                    liczba_punktow.BackColor = Color.Red;
                    dobrze = false;
                }
                else
                {
                    liczba_punktow.BackColor = Color.White;
                    dobrze = true;
                }
        }

  



        private void wprowadz_Click(object sender, EventArgs e)
        {
            if (dobrze)
            {
                if (Int16.Parse(liczba_punktow.Text) < 1)
                {
                    MessageBox.Show("Musi być wprowaodzona liczba węzłów większa od 0.", "Za mało węzłów", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int punkty;
                    punkty = Int16.Parse(liczba_punktow.Text);

                    Dane frm1 = new Dane(punkty);
                    frm1.Show();
                }
            }
            else
            {
                MessageBox.Show("Dane wprowadzone nie są poprawne.", "Złe dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
