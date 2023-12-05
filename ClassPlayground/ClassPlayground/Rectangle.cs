using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
        public int width;
        public int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public float calculateArea()
        {
            float area = width * height;
            return area;
        }
        public float calculateAspectRatio()
        {
            float aspectRatio = (float)width / height;
            return aspectRatio;
        }
        public bool containsPoint(int x, int y)
        {
            bool result = true;
            if (x > width || y > height)
            {
                result = false;
            }
            return result;
        }
    }
    
}
