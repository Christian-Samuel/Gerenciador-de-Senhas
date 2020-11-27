using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciarSenhas
{
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            adicionar.procL(locais);
        }

        private void locais_SelectedIndexChanged(object sender, EventArgs e)
        {
                adicionar.proc(locais.SelectedIndex, login, senha);   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente Apagar?","",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                adicionar.remover(locais.SelectedIndex);
                adicionar.procL(locais);
            }



        }
    }
}
