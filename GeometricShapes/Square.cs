using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes {
    class Square : Rect {

        public override string Print() {
            return "Square";
        }
        
        public Square() {

        }

        public Square(int s1) : base(s1, s1) {
            
        }
    }

}
        

       
