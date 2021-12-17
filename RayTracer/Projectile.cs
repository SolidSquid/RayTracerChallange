

namespace RayTracer
{
   
    public class Projectile 
    {
        public Point Position;
        public Vector Velocity; 

        public Projectile(Point Position, Vector Velocity)
        {
            this.Position = Position;
            this.Velocity = Velocity;
        }
        
        public Projectile()
        {

        }
    }


    
}
