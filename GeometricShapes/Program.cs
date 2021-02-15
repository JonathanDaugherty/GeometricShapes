using System;

namespace GeometricShapes {
    class Program {
        static void Main(string[] args) {

            var sqr1 = new Square(5);
            Console.WriteLine($"sqr1 perimeter is {sqr1.Perimeter()}, sqr1 area is {sqr1.area()}");
            
            
            /* var rect1 = new Rect(6, 4);
            var perimeter = rect1.Perimeter();
            var area = rect1.Area();
            Console.WriteLine($"Rect1's perimeter is {perimeter}, Rect1's area is {area}"); 

            var rect1 = new Rect(6, 4);
            Console.WriteLine($"rect1 perimeter is {rect1.Perimeter()}, rect1 area is {rect1.Area()}");


            var Rect2 = new Rect(5, 8);
            Console.WriteLine($"Rect2 perimeter is {Rect2.Perimeter()}, Rect2 area is {Rect2.Area()}"); */
            
           /* var quad1 = new Quad(3, 4, 5, 6);
            var perimeter = quad1.Perimeter();
            Console.WriteLine($"quad1's perimeter is {perimeter}");

            var quad2 = new Quad();
            Console.WriteLine($"quad 2's perimeter is {quad2.Perimeter()}"); */
        }
    }
}
