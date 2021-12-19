
using System;
using System.Collections.Generic;
using System.Linq;

namespace RayTracer

{
    class Program
    {
/*        static void Main(string[] args)             //Chapter 2
        {
            Canvas bg = new Canvas(550,900);

        
            var pjPoints = Temp.ShootProjectile(new Environment(), new Projectile());

            for (int i = 0; i < pjPoints.Count; i++)
            {
                bg.WritePixel(Color.Orange, (int)MathF.Round(pjPoints[i].Z), bg.Height - (int)MathF.Round(pjPoints[i].Y));
            }

            Save.SaveCanvas(bg, "Skouris");


        } */
        static void Main(string[] args)
        {
         Mat4 a;
            Mat4 a1;
            Mat4 a2;
            bool g;

            a = new Mat4(1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 4, 2, 3, 1);
            a1 = Mat4.Transpose(a);
            a2 = new Mat4(1, 2, 3, 2, 1, 2, 3, 4, 1, 2, 3, 4, 4, 2, 3, 1);
            g = Mat4.IsEqual(a, a2);
            Console.WriteLine(g);
        }
    }
}