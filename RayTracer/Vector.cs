using System;

namespace RayTracer
{
    public class Vector : Tuple    // Should have created an array in first place in order to avoid all that Enumerator BS, will see if need to fill in matrices with Vectors in the actual RT

    {
        public Vector(float x, float y, float z) : base(x, y, z, 0)
        {
        }

        public Vector() : base(0.0f, 0.0f, 0.0f, 0)
        {
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector                 //TRY IN UNITY
            {
                X = a.X + b.X,
                Y = a.Y + b.Y,
                Z = a.Z + b.Z,
                W = a.W + b.W

            };
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector
            {
                X = a.X - b.X,
                Y = a.Y - b.Y,
                Z = a.Z - b.Z,
                W = a.W - b.W
            };
        }

        public static Vector operator -(Vector a)
        {
            return new Vector
            {
                X = 0 - a.X,
                Y = 0 - a.Y,
                Z = 0 - a.Z,
                W = 0 - a.W
            };
        }

        public static Vector operator *(float a, Vector b)
        {
            return new Vector
            {
                X = a * b.X,
                Y = a * b.Y,
                Z = a * b.Z,
                W = a * b.W
            };
        }
        public static Vector operator *(Vector b, float a)
        {
            return new Vector
            {
                X = a * b.X,
                Y = a * b.Y,
                Z = a * b.Z,
                W = a * b.W
            };
        }
        public static Vector operator /(Vector a, float b)
        {
            return new Vector
            {
                X = a.X / b,
                Y = a.Y / b,
                Z = a.Z / b,
                W = a.W / b
            };
        }
        public static float VectorMagnitude(Vector a)
        {

            float temp = MathF.Sqrt((a.X * a.X) + (a.Y * a.Y) + (a.Z * a.Z));
            return temp;
        }

        public static Vector Normalize(Vector a)
        {
            if (VectorMagnitude(a) == 0)
            {
                return new Vector(0, 0, 0);
            }

            else
                return new Vector
                {
                    X = a.X / VectorMagnitude(a),
                    Y = a.Y / VectorMagnitude(a),
                    Z = a.Z / VectorMagnitude(a)

                };

        }
        public static float Dot(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        public static Vector Cross(Vector a, Vector b)
        {
            return new Vector
            {
                X = a.Y * b.Z - a.Z * b.Y,
                Y = a.Z * b.X - a.X * b.Z,
                Z = a.X * b.Y - a.Y - b.X
            };
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public static bool IsEqual(Vector a, Vector b)
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