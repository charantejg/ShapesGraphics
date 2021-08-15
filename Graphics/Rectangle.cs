using System;

namespace Graphics
{
    class Rectangle : Shape
    {
        private Coordinate topX, topY, bottomX, bottomY;
        private int length, width;
        public Coordinate delta;

        public Rectangle(Coordinate topX, int length, int width)
        {
            this.topX = topX;
            this.width = width;
            this.length = length;
        }

        public override void Draw()
        {
            topY.x = topX.x + width;
            topY.y = topX.y;
            bottomX.x = topX.x;
            bottomX.y = topX.y + length;
            bottomY.x = topY.x;
            bottomY.y = bottomX.y;

            Console.WriteLine("Top X:  ("+topX.x +", "+topX.y +")" +
                "Top Y: (" + topY.x + "," + topY.y + "), " +
                "Bottom X:" + "(" + bottomX.x + "," + bottomX.y + ")" +
                ", Bottom Y: (" + bottomY.x + ", " + bottomY.y + ")");
              
        }

        public void Select(Coordinate userInput)
        {

            // User clicking near to the edges 
            // Pre-defined delta 
            var positiveDelta = userInput;
            var negativeDelta = userInput;

            positiveDelta.x += delta.x;
            positiveDelta.y += delta.y;
            negativeDelta.x -= delta.x;
            negativeDelta.y -= delta.y;

            // user clicking exactly on the edges

            if ((topX.x == userInput.x && topX.y == userInput.y)
                || (topY.x == userInput.x && topY.y == userInput.y)
                || (bottomX.x == userInput.x && bottomX.y == userInput.y)
                || (bottomY.x == userInput.x && bottomY.y == userInput.y))
            {
                Console.WriteLine("Edges are selected");
               
            }

            //else if (
            //   ((topX.x == positiveDelta.x || topY.x == positiveDelta.x
            //       || topX.x == userInput.x || topY.x == userInput.x 
            //       || topX.x == negativeDelta.x || topY.x == negativeDelta.x)
            //   &&
            //   (topX.y == positiveDelta.y || topY.y == positiveDelta.y
            //    || topX.y == userInput.y || topY.y == userInput.y
            //    || topX.y == negativeDelta.y || topY.y == negativeDelta.y))

            //   ||

            //   ((bottomX.x == positiveDelta.x || bottomY.x == positiveDelta.x
            //   || bottomX.x == userInput.x || bottomY.x == userInput.x
            //   || bottomX.x == negativeDelta.x || bottomY.x == negativeDelta.x)
            //     &&
            //   (bottomX.y == positiveDelta.y || bottomY.y == positiveDelta.y
            //   || bottomX.y == userInput.y || bottomY.y == userInput.y
            //   || bottomX.y == negativeDelta.y || bottomY.y == negativeDelta.y)) )
            //{
            //    Console.WriteLine("Edges are selected with  delta");

            //}
            //else
            //{
            //    Console.WriteLine("Rectangle is not selected");
            //}

            var result = CheckUserSelction(topX, positiveDelta, negativeDelta);
            if(!result)
                result = CheckUserSelction(topY, positiveDelta, negativeDelta);
            if (!result)
                result = CheckUserSelction(bottomX, positiveDelta, negativeDelta);
            if (!result)
                result = CheckUserSelction(bottomY, positiveDelta, negativeDelta);

            if(result)
                Console.WriteLine("Edges are selected with  delta");
            else
                Console.WriteLine("user selection is not close to edges");




        }

       static bool  CheckUserSelction( Coordinate edge, Coordinate pdelta, Coordinate ndelta)
        {
            if ((edge.x >= ndelta.x && edge.x <= pdelta.x) && (edge.y >= ndelta.y && edge.y <= pdelta.y))
            {
                return true;
            }
            else
               return false;


           
        }


    }
}

    
