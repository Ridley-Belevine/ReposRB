using System;
using System.Numerics;
using NUnit.Framework;
using Vector3D;

namespace Vector3D.UnitTests
{
    [TestFixture]
    public class VectorTests
    {
        [Test]
        public void ConstructorSetsCoordinates()
        {
            var vector = new Vector(1.5, 2.7, 3.9);

            Assert.That(GetX(vector), Is.EqualTo(1.5).Within(1e-10));
            Assert.That(GetY(vector), Is.EqualTo(2.7).Within(1e-10));
            Assert.That(GetZ(vector), Is.EqualTo(3.9).Within(1e-10));
        }

        [Test]
        public void LengthCalculatesCorrectly()
        {
            var vector = new Vector(3, 4, 12);
            double length = vector.Length;

            Assert.That(length, Is.EqualTo(13).Within(1e-10));
        }

        [Test]
        public void LengthWithNegativeComponentsShouldBePositive()
        {
            var vector = new Vector(-3, -4, -12);
            double length = vector.Length;

            Assert.That(length, Is.EqualTo(13).Within(1e-10));
        }

        [Test]
        public void ToStringReturnsProperFormat()
        {
            var vector = new Vector(1.5, 2.0, 3.75);
            string result = vector.ToString();

            StringAssert.StartsWith("(", result);
            StringAssert.Contains(",", result);
            StringAssert.EndsWith(")", result);

            Assert.That(result, Does.Contain("1.5").Or.Contains("1,5"));
            Assert.That(result, Does.Contain("2").Or.Contains("2.0").Or.Contains("2,0"));
            Assert.That(result, Does.Contain("3.75").Or.Contains("3,75"));
        }

        [Test]
        public void EqualsWithSameValuesReturnTrue()
        {
            var a = new Vector(1.1, 2.2, 3.3);
            var b = new Vector(1.1, 2.2, 3.3);

            Assert.That(a.Equals(b), Is.True);
        }

        [Test]
        public void EqualsWithDifferentValuesReturnFalse()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(4, 5, 6);

            Assert.That(a.Equals(b), Is.False);
        }

        [Test]
        public void EqualsWithNonVectorObjectShouldThrowArgumentException()
        {
            var vector = new Vector(1, 2, 3);
            var notVector = "59468958605";

            Assert.Throws<ArgumentException>(() => vector.Equals(notVector));
        }

        [Test]
        public void GetHashCodeForEqualVectorsReturnsSameValue()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(1, 2, 3);

            int hash1 = a.GetHashCode();
            int hash2 = b.GetHashCode();

            Assert.That(hash1, Is.EqualTo(hash2));
        }

        [Test]
        public void OperatorEqualsWorksCorrectly()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(1, 2, 3);
            var c = new Vector(4, 5, 6);

            Assert.That(a == b, Is.True);
            Assert.That(a == c, Is.False);
        }

        [Test]
        public void OperatorNotEqualsWorksCorrectly()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(1, 2, 3);
            var c = new Vector(4, 5, 6);

            Assert.That(a != b, Is.False);
            Assert.That(a != c, Is.True);
        }

        [Test]
        public void OperatorAddWorksCorrectly()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(4, 5, 6);
            var result = a + b;

            Assert.That(result, Is.EqualTo(new Vector(5, 7, 9)));
        }

        [Test]
        public void OperatorSubtractWorksCorrectly()
        {
            var a = new Vector(5, 7, 9);
            var b = new Vector(1, 2, 3);
            var result = a - b;

            Assert.That(result, Is.EqualTo(new Vector(4, 5, 6)));
        }

        [TestCase(2.0)]
        [TestCase(0.5)]
        [TestCase(-3.0)]
        [TestCase(0.0)]
        [TestCase(1.5)]
        public void OperatorMultiplyVectorByScalarWorksCorrectly(double λ)
        {
            var v = new Vector(2, 3, 4);
            var result = v * λ;

            Assert.That(result, Is.EqualTo(new Vector(2 * λ, 3 * λ, 4 * λ)));
        }

        [Test]
        public void OperatorMultiplyScalarByVectorWorksCorrectly()
        {
            var v = new Vector(1, 2, 3);
            double λ = 2.5;

            var result1 = λ * v;
            var result2 = v * λ;

            Assert.That(result1, Is.EqualTo(result2));
            Assert.That(result1, Is.EqualTo(new Vector(2.5, 5, 7.5)));
        }

        [Test]
        public void DotProductCalculatesCorrectly()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(4, 5, 6);

            double result = a * b;

            Assert.That(result, Is.EqualTo(32).Within(1e-10));
        }

        [Test]
        public void DotProductWithOrthogonalVectorsIsZero()
        {
            var a = new Vector(1, 0, 0);
            var b = new Vector(0, 1, 0);
            double result = a * b;

            Assert.That(result, Is.EqualTo(0).Within(1e-10));
        }

        [Test]
        public void CrossProductCalculatesCorrectly()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(4, 5, 6);
            var result = Vector.Cross(a, b);

            Assert.That(result, Is.EqualTo(new Vector(-3, 6, -3)));
        }

        [Test]
        public void CrossProductStandardBasisVectors()
        {
            var i = new Vector(1, 0, 0);
            var j = new Vector(0, 1, 0);
            var k = new Vector(0, 0, 1);

            Assert.That(Vector.Cross(i, j), Is.EqualTo(k));
            Assert.That(Vector.Cross(j, k), Is.EqualTo(i));
            Assert.That(Vector.Cross(k, i), Is.EqualTo(j));

            Assert.That(Vector.Cross(j, i), Is.EqualTo(-k));
        }

        [Test]
        public void CrossProductIsOrthogonalToInputVectors()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(4, 5, 6);

            var cross = Vector.Cross(a, b);

            Assert.That(a * cross, Is.EqualTo(0).Within(1e-10),
                "Векторное произведение должно быть ортогонально первому вектору");
            Assert.That(b * cross, Is.EqualTo(0).Within(1e-10),
                "Векторное произведение должно быть ортогонально второму вектору");
        }

        [Test]
        public void CrossProductWithParallelVectorsIsZeroVector()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(2, 4, 6);

            var result = Vector.Cross(a, b);

            Assert.That(result, Is.EqualTo(new Vector(0, 0, 0)));
        }

        [Test]
        public void TestWithPrecisionWithinToleranceShouldBeEqual()
        {
            var a = new Vector(1.00000000000001, 2.00000000000002, 3.00000000000003);
            var b = new Vector(1.00000000000002, 2.00000000000001, 3.00000000000004);

            Assert.That(a.Equals(b), Is.True);
            Assert.That(a == b, Is.True);
        }
        private double GetX(Vector a) => (double)typeof(Vector)
                .GetField("x",
                          System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(a);

        private double GetY(Vector a) => (double)typeof(Vector)
                .GetField("y",
                          System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(a);

        private double GetZ(Vector a) => (double)typeof(Vector)
                .GetField("z",
                          System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(a);
    }
}
