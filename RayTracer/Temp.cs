using System;
using System.Collections.Generic;

namespace RayTracer
{
    public static class Temp
    {

        
        public static void Tick(Environment env, Projectile prj)
        {
            prj.Position = prj.Position + prj.Velocity;
            prj.Velocity = prj.Velocity + env.Gravity + env.Wind;

        }


        public static List<Point> ShootProjectile(Environment env, Projectile prj)
        {
            prj.Position = new Point(0f, 1f, 0f);
            prj.Velocity = /*Vector.Normalize(*/new Vector(0f, 8.8f, 4f);
            env.Gravity = new Vector(0, -0.3f, 0);
            env.Wind = new Vector(-0f, 0, 0);

            int maxLoops = 100;
            List<Point> pjPoints;
            pjPoints = new List<Point>();
            int i = 0;
            while (i < maxLoops && prj.Position.Y >= 0)
            {
                
                Console.WriteLine(prj.Position);
                i++;
                pjPoints.Add(prj.Position);
                Tick(env, prj);
            }

            return pjPoints;

        }
    }

}
