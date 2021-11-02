using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.cpf = "123.456.789-90";
            //gabriela.profissao = "Desenvolvedora";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numeroConta = 5634527;
            conta.titular.profissao = "Desenvolvedora)";

            

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
