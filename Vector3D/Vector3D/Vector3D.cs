using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector3D
{
    public struct Vector
    {
        private double x;
        private double y;
        private double z;

        private const double Precision = 1e-13;

        public readonly double Length => Math.Sqrt(x * x + y * y + z * z);

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        private static string FormatofCoordinate(double value)
        {

            if (Math.Abs(value - Math.Round(value)) < Precision)
            {
                return Math.Round(value).ToString();
            }

            return value.ToString("0.#####");
        }
        public override string ToString()
        {
            return $"({FormatofCoordinate(x)}, {FormatofCoordinate(y)}, {FormatofCoordinate(z)})";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Vector))
            {
                throw new ArgumentException("Объект не является вектором");
            }

            Vector other = (Vector)obj;
            return Math.Abs(x - other.x) < Precision && 
                   Math.Abs(y - other.y) < Precision &&
                   Math.Abs(z - other.z) < Precision;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                const int prime = 23;
                hash = hash * prime + x.GetHashCode();
                hash = hash * prime + y.GetHashCode();
                hash = hash * prime + z.GetHashCode();
                return hash;
            }
        }
        public static bool operator ==(Vector a, Vector b) => a.Equals(b);
        public static bool operator !=(Vector a, Vector b) => !a.Equals(b);

        public static Vector operator -(Vector a)
        {
            return new Vector(-a.x, -a.y, -a.z);
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Vector operator *(Vector a, double λ)
        {
            return new Vector(a.x * λ, a.y * λ, a.z * λ);
        }

        public static Vector operator *(double λ, Vector a)
        {
            return a * λ;
        }

        public static double operator *(Vector a, Vector b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        public static Vector Cross(Vector a, Vector b)
        {
            return new Vector(
                a.y * b.z - a.z * b.y,
                a.z * b.x - a.x * b.z,
                a.x * b.y - a.y * b.x
            );
        }
    }
}
