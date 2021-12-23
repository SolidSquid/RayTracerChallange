
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
        /*       static void Main(string[] args)                    //Chapter 3
               {
                   Mat4 I = Mat4.Identity();
                   Mat4 a = new Mat4(1, 2, 3, 4, 4, 3, 2, 1, 7, 8, 9, 4, 5, 6, 2, 4);
                   var aInverse = Mat4.Inverse(a);
                   var aMultWithInver = a * aInverse;
                   var okey = new Vector(1, 2, 3);

                   var b = Mat4.Inverse(Mat4.Transpose(a));
                   var c = Mat4.Transpose(Mat4.Inverse(a));

                   System.Console.WriteLine(Mat4.IsEqual(b, c));


                   Mat4 notIndent = new Mat4(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
                   var g = notIndent * okey;
                   System.Console.WriteLine(Mat4.IsEqual(b, c));
               }
           } */


        /*        static void Main(string[] args)                                   //chapter 4
               {
                    Canvas Background = new Canvas(100, 100);  // Y, Z
                    Point Pixel = new Point(0,0,0);
                    Pixel = Mat4.Translation(0, 0, 40) * Pixel;
                    Point[] Pixels = new Point[12];

                    for (int i=0; i < 12; i++)
                    {
                        Pixels[i] = Mat4.Rotation_X((float)i*MathF.PI / 6f) * Pixel;
                        Pixels[i] = Mat4.Translation(0, 50, 50)*Pixels[i];
                        Background.WritePixel(Color.Fuchsia, (Pixels[i].Y), (Pixels[i].Z));
                    }    

                    Save.SaveCanvas(Background, "clock");

                }*/

            static void Main(string[] args)                                   //chapter 5
             {


             }





    }
}