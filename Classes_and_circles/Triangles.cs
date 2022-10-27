using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_circles
{
    internal class Triangle
    {
        float _cathetus = 0;
        float _hypotenuse = 0;

        public Triangle(float cathetus, float hypotenuse)
        {
            _cathetus=cathetus;
            _hypotenuse=hypotenuse;
        }
        public float getAreaofTriangle()
        {
            return (_cathetus * _hypotenuse) / 2;
        }
    }
}
