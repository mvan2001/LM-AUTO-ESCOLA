using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class AlunoEnt
    {
        //Atributos Aluno

        private string id;
        private string nome;
        private string cpf;
        private string rg;
        private string telefone;
        private string categoriacnh;
        private string horariodeaula;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Categoriacnh
        {
            get
            {
                return categoriacnh;
            }

            set
            {
                categoriacnh = value;
            }
        }

        public string Horariodeaula
        {
            get
            {
                return horariodeaula;
            }

            set
            {
                horariodeaula = value;
            }

        }
    }
}