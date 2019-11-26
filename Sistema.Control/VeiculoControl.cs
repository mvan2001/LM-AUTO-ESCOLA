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
    public class VeiculoControl
    {
        public int Inserir(VeiculoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO veiculo ([chassi], [placa], [modelo], [cor]) VALUES (@chassi, @placa, @modelo,  @cor)";
                //Parâmetros Veiculo
                cn.Parameters.Add("chassi", SqlDbType.VarChar).Value = objtabela.Chassi;
                cn.Parameters.Add("placa", SqlDbType.VarChar).Value = objtabela.Placa;
                cn.Parameters.Add("modelo", SqlDbType.VarChar).Value = objtabela.Modelo;
                cn.Parameters.Add("cor", SqlDbType.VarChar).Value = objtabela.Cor;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<VeiculoEnt> Buscar(VeiculoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM veiculo WHERE placa LIKE @placa";
                //Parâmetros Veiculo
                cn.Parameters.Add("placa", SqlDbType.VarChar).Value = objtabela.Placa + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<VeiculoEnt> Lista = new List<VeiculoEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        VeiculoEnt dado = new VeiculoEnt();
                        dado.Id = Convert.ToString(dr["id"]);
                        dado.Chassi = Convert.ToString(dr["chassi"]);
                        dado.Placa = Convert.ToString(dr["placa"]);
                        dado.Modelo = Convert.ToString(dr["modelo"]);
                        dado.Cor = Convert.ToString(dr["cor"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }

        public int Editar(VeiculoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "";
                cn.CommandText = "UPDATE veiculo SET chassi = @chassi, placa = @placa, modelo = @modelo, cor = @cor WHERE id = @id";
                //Parâmetros Veiculo
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = objtabela.Id;
                cn.Parameters.Add("chassi", SqlDbType.VarChar).Value = objtabela.Chassi;
                cn.Parameters.Add("placa", SqlDbType.VarChar).Value = objtabela.Placa;
                cn.Parameters.Add("modelo", SqlDbType.VarChar).Value = objtabela.Modelo;
                cn.Parameters.Add("cor", SqlDbType.VarChar).Value = objtabela.Cor;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public int Excluir(VeiculoEnt objtabela)
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM veiculo WHERE id = @id";
                //Parâmetros Veiculo
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = objtabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<VeiculoEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection()) //Instanciando conexão
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM veiculo ORDER BY id ASC";
                cn.Connection = con;
                SqlDataReader dr;
                List<VeiculoEnt> Lista = new List<VeiculoEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        VeiculoEnt dado = new VeiculoEnt();
                        dado.Id = Convert.ToString(dr["id"]);
                        dado.Chassi = Convert.ToString(dr["chassi"]);
                        dado.Placa = Convert.ToString(dr["placa"]);
                        dado.Modelo = Convert.ToString(dr["modelo"]);
                        dado.Cor = Convert.ToString(dr["cor"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }
    }
}