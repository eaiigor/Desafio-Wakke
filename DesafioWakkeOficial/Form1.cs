using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DesafioWakkeOficial
{
    public partial class Form1 : Form
    {
        private readonly SQLiteConnection SqlConnection;

        public Form1()
        {
            SqlConnection = new($"Data source={Environment.CurrentDirectory}/../bancodedados.db");
            InitializeComponent();
        }

        public void CarregarPessoas()
        {
            SqlConnection.Open();
            SQLiteDataAdapter adapter = new("SELECT * FROM pessoa", SqlConnection);
            DataSet dset = new();
            adapter .Fill(dset, "pessoa");
            dataGridView1.DataSource = dset.Tables[0];
            SqlConnection.Close();
        }

        private void CriarTabelaPessoaSeNaoExiste()
        {
            SqlConnection.Open();
            SQLiteCommand command = new(SqlConnection);
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS pessoa (
                    id integer primary key autoincrement,
                    ativo boolean,
                    nome text,
                    sobrenome text,
                    datanascimento date,
                    altura decimal
                    )
                ";
            command.ExecuteNonQuery();
            SqlConnection.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            CriarTabelaPessoaSeNaoExiste();
            CarregarPessoas();

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new(this, SqlConnection);

            form2.Show();
            form2.Visible = true;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            Form2 form2 = new(this, SqlConnection, GetPessoaSelecionada());
            form2.Show();
            form2.Visible = true;

            SqlConnection.Close();
        }

        private Pessoa GetPessoaSelecionada()
        {
            var lineSelect = dataGridView1.CurrentCell.RowIndex;
            var pessoa = new Pessoa
            {
                ID = (long)dataGridView1.Rows[lineSelect].Cells[0].Value,
                Ativo = (bool)dataGridView1.Rows[lineSelect].Cells[1].Value,
                Nome = (string)dataGridView1.Rows[lineSelect].Cells[2].Value,
                Sobrenome = (string)dataGridView1.Rows[lineSelect].Cells[3].Value,
                DataNascimento = (DateTime)dataGridView1.Rows[lineSelect].Cells[4].Value,
                Altura = (decimal)dataGridView1.Rows[lineSelect].Cells[5].Value
            };

            return pessoa;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var pessoa = GetPessoaSelecionada();

            string txtQuery = "delete from pessoa where ID=@id";

            var connection = new SQLiteConnection(SqlConnection);

            var comando = new SQLiteCommand(txtQuery, connection);
            connection.Open();

            comando.Parameters.Add("@id", DbType.Int32).Value = pessoa.ID;
            comando.ExecuteNonQuery();

            connection.Close();
            CarregarPessoas();
        }
    }
}