using System;
using System.Globalization;

namespace RETANGULO_AREA_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());    
           
            
            Console.WriteLine();
            Console.WriteLine($"Área = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
