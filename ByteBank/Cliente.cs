using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Profissao { get; set; }
        private string _cpf;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escrevo a lógica de validação de CPF
                _cpf = value;
            }
        }
    }


}
