using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes {
    class Rect : Quad {



        public int Area() {
            return Side1 * Side2;
        }

        //consructor

        public Rect() {

        }

        public Rect(int s1, int s2)  : base(s1, s2, s1, s2) {

        }
    
    
    }   


}
