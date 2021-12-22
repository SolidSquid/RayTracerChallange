
namespace RayTracer
{
    public class Mat4 : Matrix          //get set index same as vector todo
    {


        public Mat4() : base(4, 4)           // Mayber Faster to hard code?
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Mat[i, j] = 0; //4x4 Zero Matrix
                }
            }

        }

        public  Mat4(   float a11, float a12, float a13, float a14,
                        float a21, float a22, float a23, float a24,
                        float a31, float a32, float a33, float a34,
                        float a41, float a42, float a43, float a44) : base(4, 4)

        {
            Mat[0, 0] = a11;  //c sharp does not suppert dynamic paramaters, take it of leave it.
            Mat[0, 1] = a12;
            Mat[0, 2] = a13;
            Mat[0, 3] = a14;

            Mat[1, 0] = a21;
            Mat[1, 1] = a22;
            Mat[1, 2] = a23;
            Mat[1, 3] = a24;

            Mat[2, 0] = a31;
            Mat[2, 1] = a32;
            Mat[2, 2] = a33;
            Mat[2, 3] = a34;

            Mat[3, 0] = a41;
            Mat[3, 1] = a42;
            Mat[3, 2] = a43;
            Mat[3, 3] = a44;
        }

        public static Mat4 Identity()         // why not : base?
        {
            Mat4 temp;
            temp = new Mat4();

            for (int i = 0; i < 4; i++)
            {
                temp.Mat[i, i] = 1; // 1 on main diagonal
            }
            return temp;
        }

        public static Mat4 Transpose(Mat4 a)         // Standart Matrix Transposition
        {
            Mat4 transpose;
            transpose = new Mat4();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    transpose.Mat[i, j] = a.Mat[j, i];
                }    
            }
            return transpose;
        }
        public static Mat3 SubM(Mat4 o, int x, int y)          //Delets a Row X and column Y and returns the remainingg 3x3 Matrix
        {
            Mat3 minor = new Mat3();
            int m = 0;

            for (int i=0; i<4; i++)
            {
               
                int n = 0;
                if (i == x)
                    continue;

                for (int j = 0; j < 4; j++)
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

        public static Mat4 Inverse(Mat4 m)                               // Returns the Inveres of a Matrix, if Matrix not reversible, returns the initial Matrix
        {
            float det = Mat4.Det(m);
            if (det != 0)
            {
                Mat4 temp = new Mat4();

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        temp.Mat[i, j] = Cofactor(m, j, i) / det;       //Division takes long, maybe i should 1 with det and then multiply on every loop
                    }
                }
                return temp;
            }
            else 
            {
                System.Console.WriteLine("Non reversible Matrix");
                return m;
            } 
                
        }

        public static float Det(Mat4 m)                                  //Determinant of a 4x4 Matrix, Minors a11, a12, a13, a14
        {
            float det = 0;
            for (int j = 0; j < 4; j++)
            {
                det = det + m.Mat[0,j]*Cofactor(m, 0, j);
            }
            return det;
        }

        public static float Minor(Mat4 m, int x, int y)                   // Creates a 2x2 SubMatrix and computes its Determinant
        {
            float minor;
            Mat3 temp = Mat4.SubM(m, x, y);
            minor = Mat3.Det(temp);
            return minor;
        }

        public static float Cofactor(Mat4 m, int x, int y)                      // Creates a minor and choses its sign (basic linear algebra)
        {
            float cofactor;
            if ((x + y) % 2 == 0)
                cofactor = Minor(m, x, y);

            else
                cofactor = -Minor(m, x, y);

            return cofactor;
        }

        public static Mat4 operator *(Mat4 a, Mat4 b) //Standart Matrix Multiplication //Can i do this in Parent?
        {
            Mat4 temp;
            temp = new Mat4();

            for (int i = 0; i < 4; i++) 
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        temp.Mat[i, j] = temp.Mat[i, j] + (a.Mat[i, k] * b.Mat[k, j]);
                    }
                }
            }
            return temp;
        }
        public static Mat4 operator *(float k, Mat4 m) // Matrix Times constant
        {
            Mat4 temp;
            temp = new Mat4();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    temp.Mat[i, j] = m.Mat[i, j] * k;              
                }
            }
            return temp;
        }

        public static Vector operator *(Mat4 a, Vector b) //Matrix Transformation on Vector
        {
            Vector temp;
            temp = new Vector();

            float[] result;
            result = new float[] { 0, 0, 0, 0 };

            float[] vec;
            vec = new float[] {b.X,b.Y,b.Z,b.W};

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result[i] = result[i] + (a.Mat[i, j] * vec[j]);
                }
            }
            temp.X = result[0];
            temp.Y = result[1];
            temp.Z = result[2];
            temp.W = result[3];
            return temp;
        }
        public static Point operator *(Mat4 a, Point b) //Matrix Transformation on Point
        {
            Point temp;
            temp = new Point();

            float[] result;
            result = new float[] { 0, 0, 0, 0 };

            float[] vec;
            vec = new float[] { b.X, b.Y, b.Z, b.W };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result[i] = result[i] + (a.Mat[i, j] * vec[j]);
                }
            }
            temp.X = result[0];
            temp.Y = result[1];
            temp.Z = result[2];
            temp.W = result[3];
            return temp;
        }
        public static bool IsEqual(Mat4 a, Mat4 b)          // redo with epsilon!
        {
            if (a.Mat[0, 0] == b.Mat[0, 0] &&
                a.Mat[0, 1] == b.Mat[0, 1] &&
                a.Mat[0, 2] == b.Mat[0, 2] &&
                a.Mat[0, 3] == b.Mat[0, 3] &&
                a.Mat[1, 0] == b.Mat[1, 0] &&
                a.Mat[1, 1] == b.Mat[1, 1] &&
                a.Mat[1, 2] == b.Mat[1, 2] &&
                a.Mat[1, 3] == b.Mat[1, 3] &&
                a.Mat[2, 0] == b.Mat[2, 0] &&
                a.Mat[2, 1] == b.Mat[2, 1] &&
                a.Mat[2, 2] == b.Mat[2, 2] &&
                a.Mat[2, 3] == b.Mat[2, 3] &&
                a.Mat[3, 0] == b.Mat[3, 0] &&
                a.Mat[3, 1] == b.Mat[3, 1] &&
                a.Mat[3, 2] == b.Mat[3, 2] &&
                a.Mat[3, 3] == b.Mat[3, 3])
            {
                return true;
            }
            else
                return false;
        }
    }
}