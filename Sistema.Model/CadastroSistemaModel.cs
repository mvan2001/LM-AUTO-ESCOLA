using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Control;
using Sistema.Entidades;

namespace Sistema.Model
{
    public class CadastroSistemaModel
    {
        public static int Inserir(CadastroSistemaEnt objtabela) //Método Inserir
        {
            return new CadastroSistemaControl().Inserir(objtabela);
        }

        public List<CadastroSistemaEnt> Buscar(CadastroSistemaEnt objtabela) //Método Buscar
        {
            return new CadastroSistemaControl().Buscar(objtabela);
        }

        public CadastroSistemaEnt Login(CadastroSistemaEnt objtabela) //Método Login
        {
            return new CadastroSistemaControl().Login(objtabela);
        }

        public static int Excluir(CadastroSistemaEnt objtabela) //Método Excluir
        {
            return new CadastroSistemaControl().Excluir(objtabela);
        }

        public static int Editar(CadastroSistemaEnt objtabela) //Método Editar
        {
            return new CadastroSistemaControl().Editar(objtabela);
        }

        public List<CadastroSistemaEnt> Lista() //Método Lista
        {
            return new CadastroSistemaControl().Lista();
        }
    }
}