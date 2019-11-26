using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptLogin
{
    public class Cadastrar
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public String mensagem = "";
        HashCode hc = new HashCode();

        public Cadastrar(String usuario, String senha)
        {
            // Comando SQL -- SqlCommand
            cmd.CommandText = "INSERT INTO tb_cadastrosistema (usuario, senha) VALUES (@usuario, @senha)";

            //Parâmetros
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", hc.PassHash(senha));

            //Conectando com o banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //Executar comando
                cmd.ExecuteNonQuery();

                //Desconectando
                conexao.desconectar();

                //Mensagem de sucesso
                this.mensagem = "Cadastrado com sucesso";

            }
            catch (SqlException)
            {
                //this.mensagem = "Erro ao tentar se conectar com o banco de dados!";
            }
        }
    }
}