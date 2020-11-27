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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nova_Senha form2 = new Nova_Senha();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"data.loc"))
            {
                Pesquisar form3 = new Pesquisar();
                form3.Show();
            }
            else
            { MessageBox.Show("Nenhuma informação encontrada!"); }
        }
    }
}
