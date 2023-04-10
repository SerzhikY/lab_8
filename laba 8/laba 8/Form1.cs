using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            postcard postcard1 = new Poorpostcard();
            postcard1 = new Silverpostcard(postcard1); 
            MessageBox.Show("Название: " + postcard1.Name);
            MessageBox.Show("Цена: " + postcard1.GetCost());

            postcard postcard2 = new Expensifepostcard();
            postcard2 = new Goldenpostcard(postcard2);
            MessageBox.Show("Название: " + postcard2.Name);
            MessageBox.Show("Цена: " + postcard2.GetCost());

            postcard postcard3 = new Expensifepostcard();
            postcard3 = new Goldenpostcard(postcard3);
            postcard3 = new Silverpostcard(postcard3);
            MessageBox.Show("Название: " + postcard3.Name);
            MessageBox.Show("Цена: " + postcard3.GetCost());
        }
    }
}
