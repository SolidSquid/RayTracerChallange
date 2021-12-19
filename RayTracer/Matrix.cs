using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracer
{
    public abstract class Matrix     // Will only expand on 4x4 Becuase i only need 3x3 and 2x2 for DET and not actual Transofmations.
    {
        public int M; // Row in the Matrix
        public int N; // Line in the Matrix
        public int MaxM;
        public int MaxN;
        public float[,] Mat;

        public Matrix(int MaxM, int MaxN)
        {
            this.MaxM = MaxM;
            this.MaxN = MaxN;
            Mat = new float[MaxM,MaxN];
            
        }
    }
}
