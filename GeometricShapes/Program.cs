using System;

namespace GeometricShapes {
    class Program {
        static void Main(string[] args) {


            Quad x = new Square(3);

            var sqr1 = new Square(7);
            Console.WriteLine($"sqr1 perimeter is {sqr1.Perimeter()}, sqr1 area is {sqr1.Area()}");
            Console.WriteLine($"sqr1 is a {sqr1.Print()}");

            var rect1 = new Rect(5, 7);
            Console.WriteLine($"Rect: perimeter is {rect1.Perimeter()}");
            Console.WriteLine($"Rect: area is {rect1.Area()}");


            var quad1 = new Quad(3, 4, 5, 6);
            Console.WriteLine($"quad1 perimeter is {quad1.Perimeter()}");

            var shapes = new Quad[] {sqr1, rect1, quad1};
            foreach(var shape in shapes) {
                Console.WriteLine($"shape is a {shape.Print()}");
                var rect = shape as Rect;
                if(rect != null) {
                    Console.WriteLine($"shape's area is {rect.Area()}");
                    } else {
                    Console.WriteLine("The shape is a Quad");
                }

            }


            //var sqr2 = new Square(8);
            //Console.WriteLine($"sqr2 perimeter is {sqr2.Perimeter()}, sqr2 area is {sqr2.area()}");

            //var quad3 = new Quad(5, 3, 5, 2);
            //var perimeter = quad3.Perimeter();
            //Console.WriteLine($"quad3 perimeter is {perimeter}");




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
