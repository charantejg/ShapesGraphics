using System;

namespace Graphics
{
   public abstract class Shape
    {

        public virtual void Draw()
        {
            Console.WriteLine("Default super shape");
        }
    }
}
