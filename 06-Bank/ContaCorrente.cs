using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Bank
{
    class ContaCorrente
    {
        public int id;
        public Cliente titular;
        public int agencia;
        public int numeroConta;
        private double saldo = 100;



        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {

            }
            else
            {
                this.saldo = saldo;
            }
        }
        public double ObterSaldo()
        {
            return saldo;
        }
        public bool Sacar(double valor)
        {
            if(saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar (double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
