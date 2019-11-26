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
    public class CadastroSistemaControl
    {
        public int Inserir(CadastroSistemaEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO cadastrosistema ([usuario], [senha]) VALUES (@usuario, @senha)";
                //Parâmetros CadastroSistema
                cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = objtabela.Usuario;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objtabela.Senha;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<CadastroSistemaEnt> Buscar(CadastroSistemaEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM cadastrosistema WHERE usuario LIKE @usuario";
                //Parâmetros CadastroSistema
                cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = objtabela.Usuario + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<CadastroSistemaEnt> Lista = new List<CadastroSistemaEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CadastroSistemaEnt dado = new CadastroSistemaEnt();
                        dado.Id = Convert.ToString(dr["id"]);
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }

        }

        public CadastroSistemaEnt Login(CadastroSistemaEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM cadastrosistema WHERE usuario = @usuario AND senha = @senha";
                cn.Connection = con;
                //Parâmetros CadastroSistema
                cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = objtabela.Usuario;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objtabela.Senha;
                SqlDataReader dr;
                List<CadastroSistemaEnt> Lista = new List<CadastroSistemaEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CadastroSistemaEnt dado = new CadastroSistemaEnt();
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                    }
                }

                else
                {
                    objtabela.Usuario = null;
                    objtabela.Senha = null;
                }

                return objtabela;

            }
        }

        public int Editar(CadastroSistemaEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "";
                cn.CommandText = "UPDATE cadastrosistema SET usuario = @usuario, senha = @senha WHERE id = @id";
                //Parâmetros CadastroSistema
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = objtabela.Id;
                cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = objtabela.Usuario;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objtabela.Senha;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public int Excluir(CadastroSistemaEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM cadastrosistema WHERE id = @id";
                //Parâmetros CadastroSistema
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = objtabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<CadastroSistemaEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM cadastrosistema ORDER BY id ASC";
                cn.Connection = con;
                SqlDataReader dr;
                List<CadastroSistemaEnt> Lista = new List<CadastroSistemaEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CadastroSistemaEnt dado = new CadastroSistemaEnt();
                        dado.Id = Convert.ToString(dr["id"]);
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);

                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }
    }
}