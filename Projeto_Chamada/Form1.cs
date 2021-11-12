using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Chamada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<Form2>().Count()==0)
            {
                Form2 filho2 = new Form2();
                filho2.MdiParent = this;
                filho2.Show();
            }
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void palestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form3>().Count() == 0)
            {
                Form3 filho3 = new Form3();
                filho3.MdiParent = this;
                filho3.Show();
            }
        }

        private void presençaNoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form4>().Count() == 0)
            {
                Form4 filho4 = new Form4();
                filho4.MdiParent = this;
                filho4.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void atualizarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form5>().Count() == 0)
            {
                Form5 filho5 = new Form5(0);
                filho5.MdiParent = this;
                filho5.Show();
            }
        }

        private void excluirALunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form5>().Count() == 0)
            {
                Form5 filho5 = new Form5(1);
                filho5.MdiParent = this;
                filho5.Show();
            }
        }

        private void relatórioDePresençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form6>().Count() == 0)
            {
                Form6 filho6 = new Form6();
                filho6.MdiParent = this;
                filho6.Show();
            }
        }
    }
}
