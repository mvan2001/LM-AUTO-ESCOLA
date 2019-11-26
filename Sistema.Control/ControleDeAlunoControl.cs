using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Sistema.Control
{
    public class ControleDeAlunoControl
    {
        public int Inserir(ControleDeAlunoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO controledealuno ([nome], [frequencia], [pagamento]) VALUES (@nome, @frequencia, @pagamento)";
                //Parâmetros ControleDeAluno
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objtabela.Nome;
                cn.Parameters.Add("frequencia", SqlDbType.VarChar).Value = objtabela.Frequencia;
                cn.Parameters.Add("pagamento", SqlDbType.VarChar).Value = objtabela.Pagamento;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<ControleDeAlunoEnt> Buscar(ControleDeAlunoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM controledealuno WHERE nome LIKE @nome";
                //Parâmetros ControleDeAluno
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objtabela.Nome + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<ControleDeAlunoEnt> Lista = new List<ControleDeAlunoEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ControleDeAlunoEnt dado = new ControleDeAlunoEnt();
                        dado.Id = Convert.ToString(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Frequencia = Convert.ToString(dr["frequencia"]);
                        dado.Pagamento = Convert.ToString(dr["pagamento"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }

        public int Editar(ControleDeAlunoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "";
                cn.CommandText = "UPDATE controledealuno SET nome = @nome, frequencia = @frequencia, pagamento = @pagamento WHERE id = @id";
                //Parâmetros ControleDeAluno
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = objtabela.Id;
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objtabela.Nome;
                cn.Parameters.Add("frequencia", SqlDbType.VarChar).Value = objtabela.Frequencia;
                cn.Parameters.Add("pagamento", SqlDbType.VarChar).Value = objtabela.Pagamento;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public int Excluir(ControleDeAlunoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM controledealuno WHERE id = @id";
                //Parâmetros ControleDeAluno
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = objtabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<ControleDeAlunoEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM controledealuno ORDER BY id ASC";
                cn.Connection = con;
                SqlDataReader dr;
                List<ControleDeAlunoEnt> Lista = new List<ControleDeAlunoEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ControleDeAlunoEnt dado = new ControleDeAlunoEnt();
                        dado.Id = Convert.ToString(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Frequencia = Convert.ToString(dr["frequencia"]);
                        dado.Pagamento = Convert.ToString(dr["pagamento"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }
    }
}