
using SquareLib;
using Xunit;

namespace SquareLib.Tests
{
    public class CircleTests
    {
        [Fact]
        public void ConstructorCircle_NegativeParam_ExpectedException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void ConstructorCircle_SetParam_ExpectedParam()
        {
            const int param = 15;
            var circle = new Circle(param);
            Assert.Equal(param, circle.Radius);
        }

        [Fact]
        public void SetRadiusCircle_SetParam_ExpectedParam()
        {
            const int param = 15;
            var circle = new Circle(0);
            circle.Radius = param;
            Assert.Equal(param, circle.Radius);
        }
        [Fact]
        public void SetRadiusCircle_SetNegativeParam_ExpectedException()
        {
            const int param = -5;
            var circle = new Circle(1);
            Assert.Throws<ArgumentException>(() => (circle.Radius = param));
        }

        [Fact]
        public void CalcSquareCircle_ValidParam_ExpectedValidSquare()
        {
            var circle = new Circle(1);
            Assert.Equal(Math.PI, circle.calcSquare());
        }

    }
}
