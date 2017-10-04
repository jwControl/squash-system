using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemSquash
{
    public partial class Form1 : Form
    {
        //dane wejsciowe
        List<TextBox> ListaZawodnikow = new List<TextBox>();
        // dane do prezentacji
        List<Label> ListaEtykiet = new List<Label>();
        //lista posredniczaca
        List<String> WpisaniZawodnicy = new List<string>();

        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            ZainicjalizujTextBoxy();
            ZainicjlizujLabelki();
        }

        public void ZainicjalizujTextBoxy()
        {
            ListaZawodnikow.Add(textBox1);
            ListaZawodnikow.Add(textBox2);
            ListaZawodnikow.Add(textBox3);
            ListaZawodnikow.Add(textBox4);
            ListaZawodnikow.Add(textBox5);
            ListaZawodnikow.Add(textBox6);
            ListaZawodnikow.Add(textBox7);
            ListaZawodnikow.Add(textBox8);
        }

        public void ZainicjlizujLabelki()
        {
            ListaEtykiet.Add(label5);
            ListaEtykiet.Add(label6);
            ListaEtykiet.Add(label7);
            ListaEtykiet.Add(label8);
            ListaEtykiet.Add(label9);
            ListaEtykiet.Add(label10);
            ListaEtykiet.Add(label11);
            ListaEtykiet.Add(label12);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Label tymczasowaZmienna in ListaEtykiet)
            {
                tymczasowaZmienna.Text = "";
            }
            WpisaniZawodnicy.Clear();

            foreach (TextBox tymczasowaZmienna in ListaZawodnikow)
            {
                if (tymczasowaZmienna != null && tymczasowaZmienna.Text != "")
                    WpisaniZawodnicy.Add(tymczasowaZmienna.Text);
            }
            List<int> tab = new List<int>();
            for (int i = 0; i < WpisaniZawodnicy.Count; i++)
            {

                int a = r.Next(WpisaniZawodnicy.Count);
                while (tab.Contains(a))
                {
                    a = r.Next(WpisaniZawodnicy.Count);
                }
                tab.Add(a);//kazda wylosowana ma sie zapisywac w tablicy
                ListaEtykiet[i].Text = WpisaniZawodnicy[a]; //jezeli nie to wpisz do kolejnej etykiety
            }


            foreach (TextBox tymczasowaZmienna in ListaZawodnikow)
            {
                tymczasowaZmienna.Text = "";
            }

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
