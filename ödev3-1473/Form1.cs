using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev3_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int say = 1;
            do
            { 
                listBox1 .Items .Add (say);
                say++;
            }while (say <=10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = 1;
            do
            {
                listBox1.Items.Add(say);
                say++;
            } while (say <= 10);
        }
    }
}
