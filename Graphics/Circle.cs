using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
   public class Circle: Shape
    {
        private int radius;
        private Coordinate startingPoint;
        const float PI = 3.14f;

        public Circle(Coordinate userInput, int radius)
        {
            this.startingPoint = userInput;
            this.radius = radius;
        }

        
        public override void Draw()
        {
            //logic to draw circle
        }

        public void Selected(Coordinate userInput)
        {
            // if the coordinate lies in the starting point + radius
        }

    }
}
