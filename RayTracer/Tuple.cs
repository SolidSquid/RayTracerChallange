
namespace RayTracer
{

    public abstract class Tuple
    {
        public float X;
        public float Y;
        public float Z;
        public float W;
 //       public float[]Array;

        public Tuple(float x = 0, float y = 0, float z = 0, float w = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
//            Array = new float[] { this.X, Y, Z, W};
        }

        public override string ToString()
        {
            return "" + X + " " + Y + " " + Z;
        }
    }
}