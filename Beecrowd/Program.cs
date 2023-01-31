using Beecrowd;
using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            double pX, pY, aX, aY;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pX = (x.A + x.B + x.C) / 2;
            aX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));


            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pY = (y.A + y.B + y.C) / 2;

            aY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

            /*double xA, xB, xC, yA, yB,yC, aX, aY, pX,pY;

            xA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            xB= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pX = (xA + xB + xC) / 2;

            aX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));

            pY = (yA + yB + yC) / 2;

            aY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));*/

            Console.WriteLine("A área do triangulo X =  " + aX.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine($"A área do triangulo Y =  " + aY.ToString("F4", CultureInfo.InvariantCulture));

            if(aX > aY)
            {
                Console.WriteLine("O maior triangulo é: X");
            }
            if (aX == aY) { Console.WriteLine("Os dois possuem a mesma área"); }

            else { Console.WriteLine("O maior triangulo é: Y"); } 



        }
    }

}