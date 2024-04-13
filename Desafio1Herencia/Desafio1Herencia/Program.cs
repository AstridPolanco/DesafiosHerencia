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
            double n1 = 48;
            double n2 = 20;
            double newBase = 10;
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