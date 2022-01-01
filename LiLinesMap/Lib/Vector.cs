using System;

namespace LiLinesMap.Lib
{
    public static class veclib
    {
        public static Vector Mul(this Vector v, double mul)
        {
            return new Vector(v.X * mul, v.Y * mul, v.Z * mul);
        }
    }

    public struct Vector
    {
        public double X
        {
            get; set;
        }
        public double Y
        {
            get; set;
        }
        public double Z
        {
            get; set;
        }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public double Distance(Vector v, Vector v2)
              => Math.Sqrt(Math.Pow((v.X - v2.X), 2) + Math.Pow((v.Y - v2.Y), 2) + Math.Pow((v.Z - v2.Z), 2));
        public Vector2 ToScreen(Vector Position3D, Vector2 Position2D, Angle angle)
        {
            double PosX = (double)Position3D.X * 2;
            double PosY = (double)Position3D.Y * 2;
            double PosZ = (double)Position3D.Z * 2;
            double res_x = -PosZ * Math.Sin(angle.P) + PosX * Math.Cos(angle.P) + Position2D.X;
            double res_y = -(PosZ * Math.Cos(angle.P) + PosX * Math.Sin(angle.P)) * Math.Sin(angle.Y) + PosY * Math.Cos(angle.Y) + Position2D.Y;
            return new Vector2((int)(res_x), (int)(res_y));
        }

        public override string ToString()
        {
            return $"{X}:{Y}:{Z}";
        }
    }
}
