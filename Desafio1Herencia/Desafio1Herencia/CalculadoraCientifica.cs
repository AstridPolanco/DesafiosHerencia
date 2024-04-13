using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Herencia
{
    internal class CalculadoraCientifica : Calculadora
    {
        public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
        {
        }

        public double Potencia(double n1, double n2)
        {
            Console.WriteLine("---------");
            Console.WriteLine("Potencia");
            return Math.Pow (n1, n2); 
        }

        public double Raiz(double n1)
        {
            Console.WriteLine("---------");
            Console.WriteLine("Raiz");
            return Math.Sqrt(n1);
        }
        public double Modulo(double n1, double n2)
        {
            Console.WriteLine("---------");
            Console.WriteLine("Modulo"); 
            return n1 % n2;
        }
        public double Logaritmo(double n1, double newBase)
        {
            Console.WriteLine("---------");
            Console.WriteLine("Logaritmo"); 
            return Math.Log(n1 / newBase);
        }
    }
}
