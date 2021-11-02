using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            contaDoBruno.titular = "Bruno";
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(150);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(600);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            

            bool resultadoTransferencia = contaDoBruno.Transferir(400, contaDaGabriela);

            Console.WriteLine(resultadoTransferencia);
            Console.WriteLine("Saldo do Bruno após tranferir: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
