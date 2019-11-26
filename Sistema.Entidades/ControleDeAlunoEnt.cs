using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class ControleDeAlunoEnt
    {
        //Atributos ControleDeAluno

        private string id;
        private string nome;
        private string frequencia;
        private string pagamento;

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

        public string Frequencia
        {
            get
            {
                return frequencia;
            }

            set
            {
                frequencia = value;
            }
        }

        public string Pagamento
        {
            get
            {
                return pagamento;
            }

            set
            {
                pagamento = value;
            }
        }
    }
}