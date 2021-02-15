using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes {
    class Square {
        public int Side { get; set; }
        public int Area { get; set; }
        
        public int Perimeter() {
            return Side * 4;
        }

        public int area() {
            return Side * Side;

        }

        public Square() {

        }

        public Square(int s1) {
            Side = s1;
        }
    }

}
