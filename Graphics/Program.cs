using System;

namespace Graphics
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingPoint = new Coordinate(1, 1);
            var userInputCordinate = new Coordinate(10, 1);
            
            var rectangle = new Rectangle(startingPoint, 1, 1);
            rectangle.delta = new Coordinate(1, 1);
            rectangle.Draw();
            Console.WriteLine("User input cordianates :{0}, {1}", userInputCordinate.x, userInputCordinate.y);
            Console.WriteLine("Delta Allowed cordianates :{0}, {1}", rectangle.delta.x, rectangle.delta.y);
            rectangle.Select(userInputCordinate);

        }
    }

    public struct Coordinate
    {
        public  int x{ get; set; }
        public  int y{ get; set; }

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

       
    }



}
