using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Control;
using Sistema.Entidades;

namespace Sistema.Model
{
    public class InstrutorModel
    {
        public static int Inserir(InstrutorEnt objtabela) //Método Inserir
        {
            return new InstrutorControl().Inserir(objtabela);
        }

        public List<InstrutorEnt> Buscar(InstrutorEnt objtabela) //Método Buscar
        {
            return new InstrutorControl().Buscar(objtabela);
        }

        public static int Excluir(InstrutorEnt objtabela) //Método Excluir
        {
            return new InstrutorControl().Excluir(objtabela);
        }

        public static int Editar(InstrutorEnt objtabela) //Método Editar
        {
            return new InstrutorControl().Editar(objtabela);
        }

        public List<InstrutorEnt> Lista() //Método Lista
        {
            return new InstrutorControl().Lista();
        }
    }
}