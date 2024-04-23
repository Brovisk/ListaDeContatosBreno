using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosBreno
{
    internal class Contato
    {
        //Declaração de variáveis.
        private string nome;
        private string sobrenome;
        private string telefone;

        //Propriedades. São os métodos "get" e "set".
        //get = leitura.
        //set = definição.
        //É possível ser somente leitura, ou somente definição...
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
        public string Sobrenome { get {  return sobrenome; } set { sobrenome = value; } }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "(00) 00000-0000";
                }
            }
        }
        //construtor da classe
        public Contato() 
        {
            Nome = "Cláudio";
            sobrenome = "Genésio II";
            Telefone = "(11) 95555-6666";
        }
        //Sobrecarga do método construtor.
        public Contato(string nome, string sobrenome);
    }
}
