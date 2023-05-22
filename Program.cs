using System;
using System.Globalization;

namespace CalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Retangulo ret = new Retangulo();

            System.Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            System.Console.WriteLine("-----------------------------------------");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("-----------------------------------------");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("-----------------------------------------");
            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("-----------------------------------------");
            Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("-----------------------------------------");
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("-----------------------------------------");
           
        
           
            // System.Console.WriteLine("-----------------------------------------");
            // System.Console.WriteLine("Entre com a largura e altura do retangulo");
            // System.Console.WriteLine("-----------------------------------------");
            // System.Console.Write("Largura: ");
            // r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // System.Console.WriteLine("-----------------------------------------");
            // System.Console.Write("Altura: ");
            // r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // System.Console.WriteLine("-----------------------------------------");
            // System.Console.WriteLine("Area = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            // System.Console.WriteLine("-----------------------------------------");
            // System.Console.WriteLine("Perimetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            // System.Console.WriteLine("-----------------------------------------");
            // System.Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            // System.Console.WriteLine("-----------------------------------------");
            
            

        }
    }
}