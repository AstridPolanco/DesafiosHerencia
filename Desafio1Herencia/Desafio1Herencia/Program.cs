using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());


            Calculadora calculadora = new Calculadora("Casio", "fx-50");
            double total = calculadora.Sumar(n1, n2);
            Console.WriteLine(total);
            double diferencia = calculadora.Restar(n1, n2);
            Console.WriteLine(diferencia);
            double producto = calculadora.Multiplicar(n1, n2);
            Console.WriteLine(producto);
            double cociente = calculadora.Dividir(n1, n2);
            Console.WriteLine(cociente);

            CalculadoraCientifica cientifica = new CalculadoraCientifica("Xiaomi", "5642");
            Console.Write("Ingrese la base para el logaritmo: ");

            double newBase = Convert.ToDouble(Console.ReadLine());
            double potencia = cientifica.Potencia(n1, n2);
            Console.WriteLine(potencia);
            double raiz = cientifica.Raiz(n1);
            Console.WriteLine(raiz);
            double modulo = cientifica.Modulo(n1, n2);
            Console.WriteLine(modulo);
            double logaritmo = cientifica.Logaritmo(n1, newBase);
            Console.WriteLine(logaritmo);

            Console.ReadLine();
        }
    }
}