using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            contaCorrente contaGabriela = new contaCorrente();

            contaGabriela.id = 1;
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numeroConta = 863452;
            contaGabriela.saldo = 100;

            Console.ReadLine();
        }
    }
}
