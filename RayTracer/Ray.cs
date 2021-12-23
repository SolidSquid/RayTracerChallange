using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracer
{
    public class Ray
    {
        Point Origin;
        Vector Direction;

        public  Ray(Point origin, Vector direcion)
        {
            this.Origin = origin;
            this.Direction = direcion;
        }

        public static Point Position(Ray r, float k)
        {
            Point position = r.Origin + k * r.Direction;
            return position;
        }
    }
}
