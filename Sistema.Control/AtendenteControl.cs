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
    public class AtendenteControl
    {
        public int Inserir(AtendenteEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO atendente ([nome], [cpf], [rg], [telefone]) VALUES (@nome, @cpf, @rg, @telefone)";
                //Parâmetros Atendente
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

        public List<AtendenteEnt> Buscar(AtendenteEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM atendente WHERE nome LIKE @nome";
                //Parâmetros Atendente
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objtabela.Nome + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<AtendenteEnt> Lista = new List<AtendenteEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        AtendenteEnt dado = new AtendenteEnt();
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

        public int Editar(AtendenteEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "";
                cn.CommandText = "UPDATE atendente SET nome = @nome, cpf = @cpf, rg = @rg, telefone = @telefone WHERE id = @id ";
                //Parâmetros Atendente
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

        public int Excluir(AtendenteEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM atendente WHERE id = @id";
                //Parâmetros Atendente
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = objtabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<AtendenteEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM atendente ORDER BY id ASC";
                cn.Connection = con;
                SqlDataReader dr;
                List<AtendenteEnt> Lista = new List<AtendenteEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        AtendenteEnt dado = new AtendenteEnt();
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