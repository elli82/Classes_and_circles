using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_circles
{
    internal class Circle
    {
        float _pi = 3.141f;
        float _radius =0;

        public Circle(float radius)
        {            
            _radius = radius; 
        }
        public float getArea()
        {
            return _radius * _radius * _pi;            
        }
        public float getDiameter()
        {
            return _radius * 2;
        }


    }
}
