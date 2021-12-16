
using System;

namespace RayTracer
{
    public static class Utility
    {
        public static bool FloatsAreEqual(float a, float b)
        {
            if (Math.Abs(a - b) < Constants.epsilon)
            {
                return true;
            }

            return false;                                                       
        }

    }
}
