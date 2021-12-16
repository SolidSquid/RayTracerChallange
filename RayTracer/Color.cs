

namespace RayTracer
{
    class Color : Tuple
    {
        public float R;
        public float G;
        public float B;

        public Color(float r, float g, float b) : base(r, g, b, 0)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public Color() : base(0.0f, 0.0f, 0.0f, 0)
        {
        }

        public static Color Red = new Color(1.0f, 0.0f, 0.0f);
        public static Color Green = new Color(0.0f, 1.0f, 0.0f);
        public static Color Blue = new Color(0.0f, 0.0f, 1.0f);
        public static Color Yellow = new Color(1.0f, 1.0f, 0.0f);
        public static Color Black = new Color(0.0f, 0.0f, 0.0f);
        public static Color White = new Color(1.0f, 1.0f, 1.0f);

        public static Color operator +(Color a, Color b)
        {
            Color temp = new Color();
            temp.R = a.R + b.R;
            temp.G = a.G + b.G;
            temp.B = a.B + b.B;
            return temp;
        }

        public static Color operator -(Color a, Color b)
        {
            Color temp = new Color();
            temp.R = a.R - b.R;
            temp.G = a.G - b.G;
            temp.B = a.B - b.B;
            return temp;
        }

        public static Color operator *(Color a, float b)
        {
            Color temp = new Color();
            temp.R = a.R * b;
            temp.G = a.G * b;
            temp.B = a.B * b;
            return temp;
        }

        public static Color operator *(float a, Color b)
        {
            Color temp = new Color();
            temp.R = b.R * a;
            temp.G = b.G * a;
            temp.B = b.B * a;
            return temp;
        }

        public static Color operator *(Color a, Color b)
        {
            Color temp = new Color();
            temp.R = a.R * b.R;
            temp.G = a.G * b.G;
            temp.B = a.B * b.B;
            return temp;
        }
    }
}
