using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int Capacity;
            Capacity = Convert.ToInt32(Pojemnosc.Text);
            List<int> index = new List<int>();                             
            List<int> values = new List<int>();
            List<int> weights = new List<int>();
            for (int i = 0; i < 4; i++)
            index.Add(i);
            values.Add(3);
            values.Add(10);
            values.Add(4);
            values.Add(2);
            weights.Add(30);
            weights.Add(25);
            weights.Add(10);
            weights.Add(4);

            string cos = "";
            string cos1 = "";
            string cos2 = "";

            foreach (int x in index)
            {
                cos += Convert.ToString(x) + "  ";
            }

            foreach (int x in values)
            {
                cos1 += Convert.ToString(x) + "  ";
            }

            foreach (int x in weights)
            {
                cos2 += Convert.ToString(x) + "  ";
            }
            Lista1.Text = cos;
            //Lista1.AppendText(cos1 & Environment.NewLine);
            Lista2.Text = cos1;
            Lista3.Text = cos2;



            var b1 = new Backpack(Capacity);
            b1.Load(index, values, weights);
            string text = Convert.ToString(Capacity);
            int waga_zm = b1.Load_weights;
            int wartosc_zm = b1.Load_value;
            Pojemnosc.Text = text;
            Waga.Text = Convert.ToString(waga_zm);
            Wartosc.Text = Convert.ToString(wartosc_zm);




            //Wartosc.Text = b1.Load_value;

        }

        private void Pojemnosc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
