using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVisual3.Formularios
{
    public partial class FormListarContatos : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        public FormListarContatos()
        {
            InitializeComponent();

            Conexao();
            CarregarDados();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=projetovisual3;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }

        //private void Conexao()
        //{
        //    string conexaoString = "server=localhost;database=projetovisual4;user=root;password=root;port=3360";
        //    conexao = new MySqlConnection(conexaoString);
        //    comando = conexao.CreateCommand();

        //    conexao.Open();
        //}

        public void CarregarDados()
        {
            Conexao();

            string sql = "SELECT * FROM contato";
            var comando = new MySqlCommand(sql, conexao);
            var adaptador = new MySqlDataAdapter(comando);

            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            tabela.Columns["id_con"].ColumnName = "ID";
            dgvContato.DataSource = tabela;
        }
    }
}
