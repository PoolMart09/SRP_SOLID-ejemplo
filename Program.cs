using System;
using static Rectangle;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
      var rectangulos = new[]
{
    new Rectangle {Width = 10, Height = 5},
    new Rectangle {Width = 4, Height = 6},
    new Rectangle {Width = 5, Height = 1},
    new Rectangle {Width = 8, Height = 9}
};

var sumaDeAreas = AreaOperations.Sum(rectangulos);
var sumaDePerimetros = PerimeterOperations.Sum(rectangulos);

Console.WriteLine($"Area total:  {sumaDeAreas}" + $"\n Perimetro Total: {sumaDePerimetros}");

Console.ReadKey();
        }
    }
}
