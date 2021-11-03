using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Bank
{
    class ContaCorrente
    {
        public int id;

        public Cliente Titular { get; set; }

        public static int QtdeContasCriadas { get; private set; } // menbro estático da classe 

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            
            set
            {
                if (value <= 0)
                    return;
                _agencia = value;
            }
        }

        private int _numeroConta;

        public int NumeroConta
        {
            get
            {
                return _numeroConta;
            }

            set
            {
                if (value <= 0)
                    return;
                _numeroConta = value;
            }
        }



        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0) { return; }
                _saldo = value;
            }
        }



        public ContaCorrente(int agencia, int numeroConta)
        {
            Agencia = agencia;
            NumeroConta = numeroConta;

            QtdeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
