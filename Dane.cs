using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Macierze_JR
{
    public partial class Dane : Form
    {
        //private Pytanie dane;
        int punkty;
        bool[] regex_check_x;
        bool[] regex_check_y;
        void testuj_regexy()
        {
            for (int i = 0; i < punkty; i++)
            {
                string test;
                test = kolumnaX.GetControlFromPosition(0, i).Text;

                if (!Regex.IsMatch(test, "^[-]?(?:[0](?:[\\,\\.][0-9]+|$)+|[1-9][0-9]*(?:[\\,\\.][0-9]+|$)$)"))
                {
                    kolumnaX.GetControlFromPosition(0, i).BackColor = Color.Red;
                    regex_check_x[i] = false;
                }
                else
                {
                    kolumnaX.GetControlFromPosition(0, i).BackColor = Color.White;
                    regex_check_x[i] = true;
                }

            }
            for (int i = 0; i < punkty; i++)
            {
                string test;
                test = kolumnaY.GetControlFromPosition(0, i).Text;

                if (!Regex.IsMatch(test, "^[-]?(?:[0](?:[\\,\\.][0-9]+|$)+|[1-9][0-9]*(?:[\\,\\.][0-9]+|$)$)"))
                {
                    kolumnaY.GetControlFromPosition(0, i).BackColor = Color.Red;
                    regex_check_y[i] = false;
                }
                else
                {
                    kolumnaY.GetControlFromPosition(0, i).BackColor = Color.White;
                    regex_check_y[i] = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitX(int p)
        {
            kolumnaX.ColumnCount = 1;
            kolumnaX.RowCount = p;
            kolumnaX.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            for (int i = 0; i < p; i++)
            {
                kolumnaX.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                //Label etykieta = new Label();
                //etykieta.Text = "x" + (i + 1);
                //kolumnaX.Controls.Add(etykieta, 1, i);
                kolumnaX.Controls.Add(new TextBox(), 1, i);
            }

        }

        private void InitY(int p)
        {
            kolumnaY.ColumnCount = 1;
            kolumnaY.RowCount = p;
            kolumnaY.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            for (int i = 0; i < p; i++)
            {
                kolumnaY.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                //Label etykieta = new Label();
                //etykieta.Text = "y" + (i + 1);
                //kolumnaY.Controls.Add(etykieta, 1, i);
                kolumnaY.Controls.Add(new TextBox(), 1, i);
            }
        }

        public Dane(int pkt)
        {
            InitializeComponent();


            punkty = pkt;

            regex_check_x = new bool[pkt];
            for (int i = 0; i < pkt; i++)
            {
                regex_check_x[i] = false;
            }

            regex_check_y = new bool[pkt];
            for (int i = 0; i < pkt; i++)
            {
                regex_check_y[i] = false;
            }

            InitY(pkt);
            InitX(pkt);

        }

 

        private void wprowadz_Click_1(object sender, EventArgs e)
        {
            bool dalej = true;
            testuj_regexy();

            for (int i = 0; i < punkty; i++)
            {
                if (!regex_check_x[i] || !regex_check_y[i])
                    dalej = false;
            }

            if (dalej)
            {
                float[] p_x = new float[punkty];
                float[] p_y = new float[punkty];

                for (int i = 0; i < punkty; i++)
                {
                    p_x[i] = float.Parse(kolumnaX.GetControlFromPosition(0, i).Text);
                    p_y[i] = float.Parse(kolumnaY.GetControlFromPosition(0, i).Text);
                }
                for (int i = 0; i < punkty; i++)
                {
                    for (int j = 0; j < punkty; j++)
                    {
                        if (p_x[i] == p_x[j] && i != j)
                        {
                            MessageBox.Show("Wprowadzono dwie identyczne wartości x. Należy zmienić jedną z nich.", "Powtórzone węzły!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                

                float[] temp_x = new float[punkty];
                float[] temp_y = new float[punkty];

                for (int i = 0; i < punkty - 1; i++)
                {
                    for (int j = 0; j < punkty - 1; j++)
                    {
                        if (p_x[j] > p_x[j+1])
                        {
                            temp_x[j] = p_x[j];
                            temp_y[j] = p_y[j];

                            p_x[j] = p_x[j + 1];
                            p_x[j + 1] = temp_x[j];

                            p_y[j] = p_y[j + 1];
                            p_y[j + 1] = temp_y[j];
                        }
                    }
                }

                Wykres wyk = new Wykres(p_x, p_y, punkty);
                wyk.Show();
            }
            else
            {
                MessageBox.Show("Dane wprowadzone nie są poprawne.", "Złe dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
