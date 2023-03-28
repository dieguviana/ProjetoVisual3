using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoVisual3.Formularios;

namespace ProjetoVisual3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }
        private void AlternaCorFundo()
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AlternaCorFundo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastroContato form = new FormCadastroContato();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListarContatos form = new FormListarContatos();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
