using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Herencia
{
    internal class Calculadora
    {
        public Calculadora()
        {
        }

        public string Marca {  get; set; }
        public string Serie { get; set;}

        public Calculadora(string marca, string serie)
        {
            Marca = marca;
            Serie = serie;
        }

        public double Sumar(double n1, double n2) 
        {
            Console.WriteLine("---------"); 
            Console.WriteLine("Suma");
            return n1 + n2;
        }
        public double Restar(double n1, double n2) 
        {
            Console.WriteLine("---------"); 
            Console.WriteLine("Resta"); 
            return n1 - n2;
        }
        public double Multiplicar(double n1, double n2) 
        {
            Console.WriteLine("---------"); 
            Console.WriteLine("Multiplicacion");
            return n1 * n2;
        }
        public double Dividir(double n1, double n2) 
        {
            Console.WriteLine("---------"); 
            Console.WriteLine("Division");
            return n1 / n2;
        }
    }
}
