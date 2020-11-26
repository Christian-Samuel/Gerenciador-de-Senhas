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
    public partial class Nova_Senha : Form
    {
        public Nova_Senha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionar.add(local,login,senha);
            MessageBox.Show("Informações salvas com sucesso!");
            this.Close();
        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
