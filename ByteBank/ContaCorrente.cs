using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set; }

        public double Numero { get; set; }

        private double _saldo = 100;
        private int _agencia;

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30/TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }


        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value > 0)
                {
                    _saldo = value;
                }
            }
        }



        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;


        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Sacar(valor))
            {
                contaDestino.Depositar(valor);
                return true;
            }

            return false;

        }

        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
    }
}