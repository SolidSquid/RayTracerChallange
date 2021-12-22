

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


        public static Mat2 SubM(Mat3 o, int x, int y)          //Delets a Row X and column Y and returns the remainingg 2x2 Matrix
        {
            Mat2 minor = new Mat2();
            int m = 0;

            for (int i = 0; i < 3; i++)
            {

                int n = 0;
                if (i == x)
                    continue;

                for (int j = 0; j < 3; j++)
                {
                    if (j == y)
                        continue;

                    minor.Mat[m, n] = o.Mat[i, j];
                    n++;
                }
                m++;
            }
            return minor;
        }

        public static float Det (Mat3 m)                                      //Determinant of a 3x2 Matrix, Minors a11, a12, a13
        {
            float det=0;
            for (int j = 0; j < 3; j++)
                {
                det = det + m.Mat[0,j]*Cofactor(m, 0, j);
                }
            return det;
        }
        
        public static float Minor (Mat3 m, int x, int y)                   // Creates a 2x2 SubMatrix and computes its Determinant
        {
            float minor;
            Mat2 temp = Mat3.SubM(m, x, y);
            minor = Mat2.Det(temp);
            return minor;
        }

        public static float Cofactor(Mat3 m, int x, int y)                      // Creates a minor and choses its sign (basic linear algebra)
        {
            float cofactor;
            if ((x + y) % 2 == 0)
                cofactor = Minor(m, x, y);

            else
                cofactor = -Minor(m, x, y);

            return cofactor;
        }

        public static Mat3 operator *(Mat3 a, Mat3 b)                      //Standart Matrix Multiplication //Can i do this in Parent?
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

        public static Mat3 operator *(float k, Mat3 m) // Matrix Times constant
        {
            Mat3 temp;
            temp = new Mat3();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp.Mat[i, j] = m.Mat[i, j] * k;
                }
            }
            return temp;
        }

        public static bool IsEqual(Mat3 a, Mat3 b)          // redo with epsilon!
        {
            if (a.Mat[0, 0] == b.Mat[0, 0] &&
                a.Mat[0, 1] == b.Mat[0, 1] &&
                a.Mat[0, 2] == b.Mat[0, 2] &&

                a.Mat[1, 0] == b.Mat[1, 0] &&
                a.Mat[1, 1] == b.Mat[1, 1] &&
                a.Mat[1, 2] == b.Mat[1, 2] &&

                a.Mat[2, 0] == b.Mat[2, 0] &&
                a.Mat[2, 1] == b.Mat[2, 1] &&
                a.Mat[2, 2] == b.Mat[2, 2])

            {
                return true;
            }
            else
                return false;
        }
    }
}