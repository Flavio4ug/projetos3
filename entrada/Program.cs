using System;
using System.Runtime.CompilerServices;
namespace Entrada
{
    class Projeto
    {
        static void Main(string[] args)
        {
            int numero;
            int hora;
            float salario;

            Console.WriteLine("qual seu N°?");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("qual seu salario?");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("quantas horas voce trabalha?");
            hora = int.Parse(Console.ReadLine());

            double salariomensal = hora * salario;

            Console.WriteLine("OLÁ NÚMERO " + numero + ", o seu salário é: R$" + salariomensal);
        }
    }
}