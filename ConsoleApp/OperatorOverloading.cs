using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Box
    {
        public double Length { get; set; }   // Length of a box
        public double Breadth { get; set; }  // Breadth of a box
        public double Height { get; set; }  // Hei ght of a box

        public double getVolume()
        {
            return this.Length * this.Breadth * this.Height;
        }

        public static bool operator ==(Box b1, Box b2)
        {
            if(b1.Breadth==b2.Breadth && b1.Height == b2.Height && b1.Length==b2.Length)
                return true;
            return false;
        }
        
        public static bool operator !=(Box b1, Box b2)
        {
            if (b1.Breadth != b2.Breadth || b1.Height != b2.Height || b1.Length != b2.Length)
                return true;
            return false;
        }
        
        public static Box operator +(Box b1, Box b2)
        {
            Box b = new Box();
            b.Length = b1.Length + b2.Length;
            b.Breadth = b1.Breadth + b2.Breadth;
            b.Height = b1.Height + b2.Height;
            return b;
        }

        //TODO: Overload <, >, >=, <=, - operators

    }
}
