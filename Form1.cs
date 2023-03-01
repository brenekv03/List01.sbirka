using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            List<int> list = new List<int>();
            int n = int.Parse(textBox1.Text);
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(2, 11));
            }
            Vypis(list, listBox1);
            int max = list.Max();
            int prvniMaxPoradi = 0;
            int posledniMaxPoradi = 0;
            int poradiMinima = 0;
            bool prvniMax = false;
            int min = 11;
            for(int i =0;i<list.Count();i++)
            {
                int prvek = list[i];
                if (max == prvek)
                {
                    posledniMaxPoradi = i;
                    if (!prvniMax) prvniMaxPoradi = i;
                }
                if (prvek%2==0)
                {
                    if(prvek<min)
                    {
                        min = prvek;
                        poradiMinima = i;
                    }
                }
            }
            MessageBox.Show("Pořadí prvního max je: " + prvniMaxPoradi + "\nPořadí posledního max je: " + posledniMaxPoradi);
            list[poradiMinima] = list[0];
            list[0] = min;
            Vypis(list, listBox2);
            for(int i =0;i<list.Count();i++)
            {
                if (list[i] == max) list.Remove(max);
            }
            Vypis(list, listBox3) ;
        }
        private static void Vypis(List<int> list,ListBox listBox)
        {
            foreach(int x in list)
            {
                listBox.Items.Add(x);
            }
        }
    }
}
