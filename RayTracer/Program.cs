
using System;
using System.Collections.Generic;
using System.Linq;

namespace RayTracer

{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas bg = new Canvas(140,255);

        
            var pjPoints = Temp.ShootProjectile(new Environment(), new Projectile());

            for (int i = 0; i < pjPoints.Count; i++)
            {
                bg.WritePixel(Color.Orange, (int)MathF.Round(pjPoints[i].Z), bg.Height - (int)MathF.Round(pjPoints[i].Y));
            }

            Save.SaveCanvas(bg, "Skouris");


        }
    }
}