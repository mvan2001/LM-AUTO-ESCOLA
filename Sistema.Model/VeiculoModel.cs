using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Control;
using Sistema.Entidades;

namespace Sistema.Model
{
    public class VeiculoModel
    {
        public static int Inserir(VeiculoEnt objtabela) //Método Inserir
        {
            return new VeiculoControl().Inserir(objtabela);
        }

        public List<VeiculoEnt> Buscar(VeiculoEnt objtabela) //Método Buscar
        {
            return new VeiculoControl().Buscar(objtabela);
        }

        public static int Excluir(VeiculoEnt objtabela) //Método Excluir
        {
            return new VeiculoControl().Excluir(objtabela);
        }

        public static int Editar(VeiculoEnt objtabela) //Método Editar
        {
            return new VeiculoControl().Editar(objtabela);
        }

        public List<VeiculoEnt> Lista() //Método Lista
        {
            return new VeiculoControl().Lista();
        }
    }
}