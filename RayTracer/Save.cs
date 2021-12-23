using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RayTracer
{
    public static class Save //copy pasted
    {
        public static void SaveCanvas(Canvas canvas, string filename = "temp")
        {
            CreatePPM(canvas, filename);
        }

        static void CreatePPM(Canvas canvas, string filename)
        {
            //Create Header
            //(Type) P3
            //Width Height
            //(Max Value) 255

            StreamWriter sw = File.CreateText(filename + ".ppm");

            int maxValue = 255;

            string header = "P3\n" +
                            canvas.Width.ToString() + " " + canvas.Height.ToString() + '\n' +
                            maxValue.ToString();

            sw.WriteLine(header);

            WritePPMBody(canvas, maxValue, sw);

            string footer = "\n"; //For ImageMagick loading, which requires a new line at the end.

            sw.WriteLine(footer);
            sw.Close();
        }

        static void WritePPMBody(Canvas canvas, int maxValue, StreamWriter sw)
        {
            string currentLine = "";

            //Iterate over all pixels

            for (int x = 0; x < canvas.Height; x++)
            {
                for (int y = 0; y < canvas.Width; y++)
                {
//                    if(x == 100)
//                    {
//                        Console.WriteLine("Skouris reached"); 
//                    }
                    //canvas.GetHeight() 
                    Color color = canvas.GetPixel(canvas.Height - x, y);

                    string r = Clamp(color.R * maxValue, maxValue).ToString();
                    string g = Clamp(color.G * maxValue, maxValue).ToString();
                    string b = Clamp(color.B * maxValue, maxValue).ToString();

                    currentLine = ' ' + r + ' ' + g + ' ' + b + ' ';

                    sw.WriteLine(currentLine);
                }
            }
        }

        static int Clamp(double channelColor, int maxValue, int minValue = 0)
        {
            int temp = (int)(channelColor);
            if (temp > maxValue)
            {
                temp = maxValue;
                return temp;
            }
            if (temp < minValue)
            {
                temp = minValue;
            }
            return temp;
        }


    }
}