using pratica01;
using System;
using System.Globalization;
using System.Threading.Channels;

namespace MyApp {
    class Program {
        static void Main(string[] args) {

            
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("entre com as medidas do triâNGULO X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  
            Console.WriteLine(" X = "+ x.area().ToString("F4",CultureInfo.InvariantCulture));

            Console.WriteLine("entre com as medidas do triâNGULO X");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine(" X = " + y.area().ToString("F4", CultureInfo.InvariantCulture));
            if (x.area() >= y.area() ){
                Console.WriteLine(" o maior é X");
            }
            else {
                Console.WriteLine(" o maior é Y");
            }




        }
}
}