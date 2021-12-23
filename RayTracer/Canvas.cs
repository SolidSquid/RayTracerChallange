﻿
using System;

namespace RayTracer
{
    public class Canvas
    {
        public int Width;
        public int Height;
        Color[,] colormatrix;  // Although named matrix, its multiple arrays that can behave like a matrix, to a certain degree

        public Canvas (int height =255, int width=255)  // Creates a black canvas 
        {
            this.Height = height;
            this.Width = width;
            colormatrix = new Color[Height, Width];
            FillCanvas(this, Color.Black);
        }

        public static void FillCanvas(Canvas a, Color c)
        {
            for (int i = 0; i < a.Height; i++)
            {
                for (int j = 0; j < a.Width; j++)
                {
                    a.colormatrix[i, j] = c;
                }
            }
        }

        public void WritePixel(Color c, float zf, float yf)  // Writes RGB to specified pixol
        {
            int z = (int)MathF.Round(zf);
            int y = (int)MathF.Round(yf);

            if (z >= 0 && y >= 0 && z < Width && y < Height)
                colormatrix[y, z] = c;   //might be smart to create a Pixel Class to store X and Y Pixel positions
            else
            {

            }
        }
        
      public Color GetPixel(int z, int y)
        {
            Color temp = new Color();
 //           Console.WriteLine("X:" + x +" "+ "Y:" + y);
            if (z >= 0 && y >= 0 && y < Width && z < Height)
            {
             //   Console.WriteLine("INSIDE" +" "+ "X:" + x + " " + "Y:" + y);
                temp = colormatrix[z, y];
            }
            return temp;
        } 
    }
}
