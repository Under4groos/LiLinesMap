namespace LiLinesMap.Lib
{
    public struct Angle
    {
        public double P
        {
            get; set;
        }
        public double Y
        {
            get; set;
        }
        public double R
        {
            get; set;
        }
        public Angle(double p, double y, double r)
        {
            P = p;
            Y = y; R = r;
        }
        public override string ToString()
        {
            return $"{P}:{Y}:{R}";
        }
    }
}
