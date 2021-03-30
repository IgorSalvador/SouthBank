using System;

namespace _01_SouthBack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis de base
            int agencia, contaNumero;

            Console.WriteLine("Bem-Vindo ao SouthBank");
            Console.Write("Informe o Número de sua conta: ");
            contaNumero = int.Parse(Console.ReadLine());
            Console.Write("Informe sua Agencia: ");
            agencia = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(contaNumero, agencia);
            conta.Saldo = 2000;
            Console.WriteLine(conta.Saldo);
        }
    }
}
