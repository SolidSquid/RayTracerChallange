


namespace RayTracer
{
    class Program
    {


        public Projectile Tick(Environment env, Projectile prj)
        {
            prj.Position = prj.Position + prj.Velocity;
            prj.Velocity = prj.Velocity + env.Gravity + env.Wind;
            return new Projectile(prj.Position, prj.Velocity);
        }


        public Point ShootProjectile(Environment env, Projectile prj)
        {
            prj.Position = new Point(0f, 1f,0f);
            prj.Velocity = Vector.Normalize(new Vector(1,1,0));
            env.Gravity = new Vector(0, -0.1f, 0);
            env.Wind = new Vector(-0.01f, 0, 0);

            int MaxLoops = 60000;
            int i = 0;

            while (i < MaxLoops ^ prj.Position.Y <= 0)
            {
                Tick(env, prj);
                return prj.Position;
            }

            return prj.Position;

        }
    }

}
