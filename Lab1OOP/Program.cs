using System;

namespace Lab1OOP
    //Kenny Lindblom SUT22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle1 = new Circle(5);
            Console.WriteLine($"Arean av 1st cirklen med raiden 5cm är: {circle1.GetArea()} cm²"); //Skapar Obkejt för första Cirklen med radie 5
            Console.WriteLine($"Omkretsen av 1st cirklen med raiden 5cm är: {circle1.GetO()} cm");

            Console.WriteLine("**************************************************************");


            var circle2 = new Circle(6);
            Console.WriteLine($"Arean av 2st cirklen med raiden 6cm cirklen är: {circle2.GetArea()} cm²"); // Skapar objekt för andra cirklen med radie 6
            Console.WriteLine($"Omkretsen av 2st cirkel med raiden 6cm cirklen är: {circle2.GetO()} cm");
            Console.WriteLine("**************************************************************");

            Console.WriteLine();

            var Triangle1 = new Triangle(5,6);
            Console.WriteLine($"En triangle med basen 5 och höjden 6 ger area : {Triangle1.TriangleArea()} cm² "); //Skapar Objekt för en triangel med värderna 5 och 6




        }
    }

    class Circle          // Classen för cirklen med float värde för pi 
    {
        float _pi = 3.141f;
        int _radius;

        public Circle(int radius)
        {
            _radius = radius;   //Skapr en Conductour med värdet int radius i params. kommer anvädnas när vi skapar objektet ( Skickar värdet där) 
        }

        public float GetArea()   // Metod för att räkna ut Area på Cirklen. 
        {
            return (_radius * _radius) * _pi;
        }

        public float GetO()                    // En metod för att räkna ut omkrets på en cirkel. 2 * pi * radien.
        {
            return 2 * _pi * _radius;

        }

    }

     class Triangle   //Class för triangel där vi beestämmer vi ska anvädna basen och höjden. 
    {

        int _bass;
        int _height;

        public Triangle(int bass, int height)    //Conductor 
        {
            _bass = bass;
            
            _height = height;

        }

        public int TriangleArea()
        {
            return _bass * _height / 2;                     // A = B * H / 2 Metod för att räkna ut area på Triangel
          

        }

    }


}
