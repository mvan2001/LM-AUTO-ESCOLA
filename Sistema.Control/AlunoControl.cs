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
    public class AlunoControl
    {
        public int Inserir(AlunoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO aluno ([nome], [cpf], [rg], [telefone], [categoriacnh], [horariodeaula]) VALUES (@nome, @cpf, @rg, @telefone, @categoriacnh, @horariodeaula)";
                //Parâmetros Aluno
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objtabela.Nome;
                cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objtabela.Cpf;
                cn.Parameters.Add("rg", SqlDbType.VarChar).Value = objtabela.Rg;
                cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = objtabela.Telefone;
                cn.Parameters.Add("categoriacnh", SqlDbType.VarChar).Value = objtabela.Categoriacnh;
                cn.Parameters.Add("horariodeaula", SqlDbType.VarChar).Value = objtabela.Horariodeaula;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<AlunoEnt> Buscar(AlunoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM aluno WHERE nome LIKE @nome";
                //Parâmetros Aluno
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objtabela.Nome + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<AlunoEnt> Lista = new List<AlunoEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        AlunoEnt dado = new AlunoEnt();
                        dado.Id = Convert.ToString(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        dado.Categoriacnh = Convert.ToString(dr["categoriacnh"]);
                        dado.Horariodeaula = Convert.ToString(dr["horariodeaula"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }

        public int Editar(AlunoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "";
                cn.CommandText = "UPDATE aluno SET nome = @nome, cpf = @cpf, rg = @rg, telefone = @telefone, categoriacnh = @categoriacnh, horariodeaula = horariodeaula WHERE id = @id ";
                //Parâmetros Aluno
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = objtabela.Id;
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objtabela.Nome;
                cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objtabela.Cpf;
                cn.Parameters.Add("rg", SqlDbType.VarChar).Value = objtabela.Rg;
                cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = objtabela.Telefone;
                cn.Parameters.Add("categoriacnh", SqlDbType.VarChar).Value = objtabela.Categoriacnh;
                cn.Parameters.Add("horariodeaula", SqlDbType.VarChar).Value = objtabela.Horariodeaula;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public int Excluir(AlunoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM aluno WHERE id = @id";
                //Parâmetros Aluno
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = objtabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<AlunoEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM aluno ORDER BY id ASC";
                cn.Connection = con;
                SqlDataReader dr;
                List<AlunoEnt> Lista = new List<AlunoEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        AlunoEnt dado = new AlunoEnt();
                        dado.Id = Convert.ToString(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        dado.Categoriacnh = Convert.ToString(dr["categoriacnh"]);
                        dado.Horariodeaula = Convert.ToString(dr["horariodeaula"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }
    }
}