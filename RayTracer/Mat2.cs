

namespace RayTracer
{
    public class Mat2 : Matrix
    {


        public Mat2() : base(2, 2)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Mat[i, j] = 0; //2x2 Zero Matrix
                }
            }

        }

        public Mat2(float a11, float a12,
                    float a21, float a22): base(3, 3)

        {
            Mat[0, 0] = a11; 
            Mat[0, 1] = a12;

            Mat[1, 0] = a21;
            Mat[1, 1] = a22;
        }

        public static float Det(Mat2 a)
        {
            float det = a.Mat[0, 0] * a.Mat[1, 1] - a.Mat[1, 0] * a.Mat[0, 1];
            return det;
        }

        public static Mat2 Identity()         // why not : base?
        {
            Mat2 temp;
            temp = new Mat2();

            for (int i = 0; i < 2; i++)
            {
                temp.Mat[i, i] = 1; // 1 on main diagonal
            }
            return temp;
        }

        public static Mat2 Transpose(Mat2 a)         // Standart Matrix Transposition
        {
            Mat2 transpose;
            transpose = new Mat2();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    transpose.Mat[i, j] = a.Mat[j, i];
                }
            }
            return transpose;
        }
        public static Mat2 operator *(Mat2 a, Mat2 b) //Standart Matrix Multiplication //Can i do this in Parent?
        {
            Mat2 temp;
            temp = new Mat2();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        temp.Mat[i, j] = temp.Mat[i, j] + (a.Mat[i, k] * b.Mat[k, j]);
                    }
                }
            }
            return temp;
        }
        public static Mat2 operator *(float k, Mat2 m) // Matrix Times constant
        {
            Mat2 temp;
            temp = new Mat2();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    temp.Mat[i, j] = m.Mat[i, j] * k;
                }
            }
            return temp;
        }
    }
}