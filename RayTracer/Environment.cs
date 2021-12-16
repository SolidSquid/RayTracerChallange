

namespace RayTracer
{
    public class Environment
    {
        public Vector Gravity;
        public Vector Wind;

        public Environment(Vector Gravity, Vector Wind)
        {
            this.Gravity = Gravity;
            this.Wind = Wind;
        }
    }
}
