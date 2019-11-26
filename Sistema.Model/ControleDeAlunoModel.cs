using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Control;
using Sistema.Entidades;

namespace Sistema.Model
{
    public class ControleDeAlunoModel
    {
        public static int Inserir(ControleDeAlunoEnt objtabela) //Método Inserir
        {
            return new ControleDeAlunoControl().Inserir(objtabela);
        }

        public List<ControleDeAlunoEnt> Buscar(ControleDeAlunoEnt objtabela) //Método Buscar
        {
            return new ControleDeAlunoControl().Buscar(objtabela);
        }

        public static int Excluir(ControleDeAlunoEnt objtabela) //Método Excluir
        {
            return new ControleDeAlunoControl().Excluir(objtabela);
        }

        public static int Editar(ControleDeAlunoEnt objtabela) //Método Editar
        {
            return new ControleDeAlunoControl().Editar(objtabela);
        }

        public List<ControleDeAlunoEnt> Lista() //Método Lista
        {
            return new ControleDeAlunoControl().Lista();
        }
    }
}