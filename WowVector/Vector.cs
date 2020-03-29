using System;
namespace WowVector
{
    public class Vector
    {
        private double fx;
        private double fy;
        private double fz;

        public Vector(double fx, double fy, double fz)
        {
            this.fx = fx;
            this.fy = fy;
            this.fz = fz;
        }

        public double x
        {
            get
            {
                return fx;
            }
            set
            {
                fx = value;
            }
        }

        public double y
        {
            get
            {
                return fy;
            }
            set
            {
                fy = value;
            }

        }
        public double z
        {
            get
            {
                return fz;
            }
            set
            {
                fz = value;
            }

        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);
        }

        public static double scalar(Vector v1, Vector v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }

        public static double lengthV(Vector v1)
        {
            return Math.Sqrt(Math.Pow(v1.x, 2) + Math.Pow(v1.y, 2) + Math.Pow(v1.z, 2));
        }

        public override bool Equals(object obj)
        {
            var B = obj as Vector;

            if (B == null)
                return false;

            if ((this.fx != B.fx) | (this.fy != B.fy) | (this.fz != B.fz))
                return false;
            else
                return true;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(fx, fy, fz, x, y, z);
        }
    }
}
