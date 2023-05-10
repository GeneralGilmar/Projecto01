

using exercicio02;
using System.Globalization;

Console.WriteLine("Entre a largura e altura do rectangulo :");

Retangulo r=new Retangulo(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture),
    double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine("Area = "+r.Area().ToString("F2",CultureInfo.InvariantCulture));

Console.WriteLine("Perimetro= "+r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine("Diagonal = "+ r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));