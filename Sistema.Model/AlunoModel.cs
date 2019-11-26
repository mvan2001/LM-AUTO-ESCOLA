using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Control;
using Sistema.Entidades;

namespace Sistema.Model
{
    public class AlunoModel
    {
        public static int Inserir(AlunoEnt objtabela) //Método Inserir
        {
            return new AlunoControl().Inserir(objtabela);
        }

        public List<AlunoEnt> Buscar(AlunoEnt objtabela) //Método Buscar
        {
            return new AlunoControl().Buscar(objtabela);
        }

        public static int Excluir(AlunoEnt objtabela) //Método Excluir
        {
            return new AlunoControl().Excluir(objtabela);
        }

        public static int Editar(AlunoEnt objtabela) //Método Editar
        {
            return new AlunoControl().Editar(objtabela);
        }

        public List<AlunoEnt> Lista() //Método Lista
        {
            return new AlunoControl().Lista();
        }
    }
}