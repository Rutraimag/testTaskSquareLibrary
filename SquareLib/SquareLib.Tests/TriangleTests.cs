using SquareLib;
using Xunit;
using Xunit.Sdk;

namespace SquareLib.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        public void ConstructorTriangle_NegativeParam_ExpectedException(double side1, double side2, double side3)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }
        [Fact]
        public void ConstructorTriangle_RightParam_ExpectedException()
        {
            var triangle = new Triangle(5, 5, 6);
            Assert.Equal(5, triangle.Side1);
            Assert.Equal(5, triangle.Side2);
            Assert.Equal(6, triangle.Side3);
        }

        [Fact]
        public void ConstructorTriangle_ImpossibleParam_ExpectedException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, 5, 25));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(100)]
        public void SetSideTriangle_ImpossibleParam_ExpectedException(double param)
        {
            var triangle = new Triangle(5, 5, 6);
            Assert.Throws<ArgumentException>(() => triangle.Side1 = param);
            Assert.Throws<ArgumentException>(() => triangle.Side2 = param);
            Assert.Throws<ArgumentException>(() => triangle.Side3 = param);
        }

        [Fact]
        public void SetSideTriangle_RightParam_ExpectedRightParam()
        {
            var triangle = new Triangle(5, 5, 6);
            triangle.Side1 = 6;
            triangle.Side2 = 6;
            triangle.Side3 = 7;
            Assert.Equal(6, triangle.Side1);
            Assert.Equal(6, triangle.Side2);
            Assert.Equal(7, triangle.Side3);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(8, 5, 5, 12)]
        [InlineData(6, 5, 5, 12)]
        public void CalcSquareTriangle_Param_ExpectedRightValue(double side1, double side2, double side3, double square)
        {
            Assert.Equal(square, new Triangle(side1, side2, side3).calcSquare());
        }

    }
}
