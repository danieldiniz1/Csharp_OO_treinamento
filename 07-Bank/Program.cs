using System;

namespace _07_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 8671254);
            Console.WriteLine(ContaCorrente.QtdeContasCriadas);

            

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.NumeroConta);

            ContaCorrente contaGabi = new ContaCorrente(867, 8671255);
            

            Console.WriteLine(ContaCorrente.QtdeContasCriadas);

        }
    }
}
