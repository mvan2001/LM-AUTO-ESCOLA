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
    public class InstrutorControl
    {
        public int Inserir(InstrutorEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO instrutor ([nome], [cpf], [rg], [telefone]) VALUES (@nome, @cpf, @rg, @telefone)";
                //Parâmetros Instrutor
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objtabela.Nome;
                cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objtabela.Cpf;
                cn.Parameters.Add("rg", SqlDbType.VarChar).Value = objtabela.Rg;
                cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = objtabela.Telefone;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<InstrutorEnt> Buscar(InstrutorEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM instrutor WHERE nome LIKE @nome";
                //Parâmetros Instrutor
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objtabela.Nome + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<InstrutorEnt> Lista = new List<InstrutorEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        InstrutorEnt dado = new InstrutorEnt();
                        dado.Id = Convert.ToString(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }

        public int Editar(InstrutorEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "";
                cn.CommandText = "UPDATE instrutor SET nome = @nome, cpf = @cpf, rg = @rg, telefone = @telefone WHERE id = @id";
                //Parâmetros Instrutor
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = objtabela.Id;
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objtabela.Nome;
                cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objtabela.Cpf;
                cn.Parameters.Add("rg", SqlDbType.VarChar).Value = objtabela.Rg;
                cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = objtabela.Telefone;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public int Excluir(InstrutorEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM instrutor WHERE id = @id";
                //Parâmetros Instrutor
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = objtabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<InstrutorEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM instrutor ORDER BY id ASC";
                cn.Connection = con;
                SqlDataReader dr;
                List<InstrutorEnt> Lista = new List<InstrutorEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        InstrutorEnt dado = new InstrutorEnt();
                        dado.Id = Convert.ToString(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }
    }
}