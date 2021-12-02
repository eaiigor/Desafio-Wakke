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
    public partial class Form2 : Form
    {
        private readonly SQLiteConnection SqlConnection;
        private readonly Form1 Form1;
        private readonly Pessoa Pessoa;

        public Form2(Form1 form1, SQLiteConnection sqlConnection, Pessoa? pessoa = null)
        {
            Form1 = form1;
            Pessoa = pessoa;
            InitializeComponent();
            SqlConnection = sqlConnection;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Pessoa != null)
            {
                id_box.Text = Pessoa.ID.ToString();
                nome_box.Text = Pessoa.Nome;
                nascimento_box.Value = Pessoa.DataNascimento;
                altura_box.Value = Pessoa.Altura;
                sobrenome_box.Text = Pessoa.Sobrenome;
                radioAtivo.Checked = Pessoa.Ativo;
                radioInativo.Checked = !Pessoa.Ativo;
            }

            CenterToScreen();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_box.Text))
                Salvar();
            else
                Editar();
        }

        private void Salvar()
        {
            var strSql = "insert into pessoa (ativo,nome,sobrenome,datanascimento,altura) values (@ativo,@nome,@sobrenome,@datanascimento,@altura)";

            var connection = new SQLiteConnection(SqlConnection);
            var comando = new SQLiteCommand(strSql, connection);
            connection.Open();

            comando.Parameters.Add("@ativo", DbType.Boolean).Value = radioAtivo.Checked;
            comando.Parameters.Add("@nome", DbType.String).Value = nome_box.Text;
            comando.Parameters.Add("@sobrenome", DbType.String).Value = sobrenome_box.Text;
            comando.Parameters.Add("@datanascimento", DbType.Date).Value = nascimento_box.Value;
            comando.Parameters.Add("@altura", DbType.Decimal).Value = altura_box.Value;

            comando.ExecuteNonQuery();
            connection.Close();

            Form1.CarregarPessoas();
            Close();
        }

        private void Editar()
        {
            var strSql = @"
                update pessoa
                    set ativo = @ativo,
                    nome = @nome,
                    sobrenome = @sobrenome,
                    datanascimento = @datanascimento,
                    altura = @altura
                where id = @id;
            ";

            var connection = new SQLiteConnection(SqlConnection);
            var comando = new SQLiteCommand(strSql, connection);
            connection.Open();

            comando.Parameters.Add("@id", DbType.Int64).Value = Pessoa.ID;
            comando.Parameters.Add("@ativo", DbType.Boolean).Value = radioAtivo.Checked;
            comando.Parameters.Add("@nome", DbType.String).Value = nome_box.Text;
            comando.Parameters.Add("@sobrenome", DbType.String).Value = sobrenome_box.Text;
            comando.Parameters.Add("@datanascimento", DbType.Date).Value = nascimento_box.Value;
            comando.Parameters.Add("@altura", DbType.Decimal).Value = altura_box.Value;

            comando.ExecuteNonQuery();

            connection.Close();

            Form1.CarregarPessoas();
            Close();
        }
    }
}
