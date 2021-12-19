using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracer
{
    public class Mat3 : Matrix
    {


        public Mat3() : base(3, 3)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Mat[i, j] = 0; //3x3 Zero Matrix
                }
            }

        }

        public Mat3(float a11, float a12, float a13,
                    float a21, float a22, float a23,
                    float a31, float a32, float a33) : base(3, 3)

        {
            Mat[0, 0] = a11;
            Mat[0, 1] = a12;
            Mat[0, 2] = a13;

            Mat[1, 0] = a21;
            Mat[1, 1] = a22;
            Mat[1, 2] = a23;

            Mat[2, 0] = a31;
            Mat[2, 1] = a32;
            Mat[2, 2] = a33;
        }
        public static Mat3 Identity()         // why not : base?
        {
            Mat3 temp;
            temp = new Mat3();

            for (int i = 0; i < 3; i++)
            {
                temp.Mat[i, i] = 1; // 1 on main diagonal
            }
            return temp;
        }
        public static Mat3 Transpose(Mat3 a)         // Standart Matrix Transposition
        {
            Mat3 transpose;
            transpose = new Mat3();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    transpose.Mat[i, j] = a.Mat[j, i];
                }
            }
            return transpose;
        }

        public static Mat3 operator *(Mat3 a, Mat3 b) //Standart Matrix Multiplication //Can i do this in Parent?
        {
            Mat3 temp;
            temp = new Mat3();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        temp.Mat[i, j] = temp.Mat[i, j] + (a.Mat[i, k] * b.Mat[k, j]);
                    }
                }
            }
            return temp;
        }
    }
}