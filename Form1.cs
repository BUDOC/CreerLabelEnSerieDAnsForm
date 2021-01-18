using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreerLabelEnSerieDAnsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string T;
            int cpt = 0;
            for (int j = 0; j < 4; j++)
            {

                for (int i = 0; i < 3; i++)
                {
                    cpt++;
                    Label L = new System.Windows.Forms.Label();
                    L.Parent = this;
                     L.Click += new EventHandler(LableEstChoisi);
                    T = "L" + cpt.ToString();
                    L.Text = T;
                    L.Name = T;
                    L.Width = 30;
                    L.Height = 20;
                    L.Top = 20 + j * 40;
                    L.Left = 20 + i * 40;
                    L.Show();
                }
                cpt++;
            }
        }
        private void LableEstChoisi(object sender, EventArgs e)
        {        
            Label choisi = (Label)sender;
            this.Text="Label " + choisi.Name + " a été cliqué.";
        }
    }
}
