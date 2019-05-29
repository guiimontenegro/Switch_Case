using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Switch_case2 : Form
    {
        public Switch_case2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Switch_case2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (cboOpcao.Text)
            {
                case " 1 ou 2":
                    lblRes1.Text = "O dia do seu Rodizio é segunda-feira!";
                    break;
                case " 3 ou 4":
                    lblRes1.Text = " O dia do seu Rodizio é terça-feira!";
                    break;
                case " 5 ou 6":
                    lblRes1.Text = "O dia do seu Rodizio é quarta-feira!";
                    break;
                case " 7 ou 8":
                    lblRes1.Text = "O dia do seu Rodizio é quinta-feira!";
                    break;
                case " 9 ou 0":
                    lblRes1.Text = "O dia do seu Rodizio é sexta-feira!";
                    break;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }

        private void lblRes1_Click(object sender, EventArgs e)
        {

        }
    }
}
