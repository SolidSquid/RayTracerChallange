

namespace RayTracer
{
    public class Point : Tuple
    {
        public Point(float x, float y, float z) : base(x, y, z, 1)
        {       
        }

        public Point() : base(0.0f, 0.0f, 0.0f, 1f)
        {
        }
        public static Point operator +(Vector a, Point b)
        {
            return new Point
            {
                X = a.X + b.X,
                Y = a.Y + b.Y,
                Z = a.Z + b.Z,
                W = a.W + b.W
            };
        }
        public static Point operator +(Point a, Vector b)
        {
            return b + a;
        }

        public static Point operator -(Point a, Vector b)
        {
            return new Point
            {
                X = a.X - b.X,
                Y = a.Y - b.Y,
                Z = a.Z - b.Z,
                W = a.W - b.W
            };
        }
        public static Vector operator -(Point b, Point a)
        {
            return new Vector
            {
                X = b.X - a.X,
                Y = b.Y - a.Y,
                Z = b.Z - a.Z,
                W = b.W - a.W
            };
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public static bool IsEqual(Point a, Point b)
        {
            if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}