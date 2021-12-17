using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracer
{
    public class Canvas
    {
        public int Width;
        public int Heidht;
        Color[,] colormatrix; // Although named matrix, its multiple arrays that can behave like a matrix, to a certain degree

        public Canvas (int height =256, int width=256) // Creates a black canvas 
        {
            this.Heidht = height;
            this.Width = width;
            colormatrix = new Color[Heidht, Width];
            FillCanvas(Color.Black);
        }

        public void FillCanvas(Color c)
        {
            for (int i = 0; i < Heidht; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    colormatrix[i, j] = c;
                }
            }
        }

        public void WritePixel(Canvas a, Color c, int x, int y) // Writes RGB to specified pixol (only uses x and y component of Point)
        {
            a.colormatrix[x, y] = c;   //might be smart to create a Pixel Class to store X and Y Pixel positions;
        }
    }
}
