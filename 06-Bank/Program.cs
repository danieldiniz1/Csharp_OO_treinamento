using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "321.654.789-80";
            cliente.Profissao = "ADM";


            conta.Titular = cliente;
            conta.Saldo = -10;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);


            Console.ReadLine();
        }
    }
}
