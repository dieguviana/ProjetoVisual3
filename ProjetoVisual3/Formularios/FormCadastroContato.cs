using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoVisual3.Formularios
{
    public partial class FormCadastroContato : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;

        public FormCadastroContato()
        {
            InitializeComponent();

            Conexao();
        }


        private void Conexao()
        {
            string conexaoString = "server=localhost;database=projetovisual3;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    var nome = txtNome.Text;
                    var sexo = txtSexo.Text;
                    var data_nascimento = dataNascimento.Text;
                    var e_mail = txtEmail.Text;
                    var telefone = txtTelefone.Text;

                    string query = "INSERT INTO Contato (nome_con, sexo_con, data_nascimento_con, e_mail_con, telefone_con) VALUES (@_nome, @_sexo, @_data_nascimento, @_e_mail, @_telefone)";

                    var comando = new MySqlCommand(query, conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_data_nascimento", data_nascimento);
                    comando.Parameters.AddWithValue("@_e_mail", e_mail);
                    comando.Parameters.AddWithValue("@_telefone", telefone);

                    comando.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Salvo com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreram erros ao salvar as informações! Contate a aquipe de suporte do sistema. (CAD 10)");
                }
        }

        private void FormCadastroContato_Load(object sender, EventArgs e)
        {

        }
    }
}