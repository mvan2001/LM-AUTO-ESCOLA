using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Control;
using Sistema.Entidades;

namespace Sistema.Model
{
    public class AtendenteModel
    {
        public static int Inserir(AtendenteEnt objtabela) //Método Inserir
        {
            return new AtendenteControl().Inserir(objtabela);
        }

        public List<AtendenteEnt> Buscar(AtendenteEnt objtabela) //Método Buscar
        {
            return new AtendenteControl().Buscar(objtabela);
        }

        public static int Excluir(AtendenteEnt objtabela) //Método Excluir
        {
            return new AtendenteControl().Excluir(objtabela);
        }

        public static int Editar(AtendenteEnt objtabela) //Método Editar
        {
            return new AtendenteControl().Editar(objtabela);
        }

        public List<AtendenteEnt> Lista() //Método Lista
        {
            return new AtendenteControl().Lista();
        }
    }
}