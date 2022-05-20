using BoxContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class FigureTests
    {
        [Theory]
        [InlineData(10, 100)]
        [InlineData(10, 4188.79)]
        public void BallVolumeTest(int radius, double expectedValue)
        {
            Ball ball = new Ball(radius);

            Assert.Equal(expectedValue, ball.Volume(), 3);
        }

        [Theory]
        [InlineData(9, 729)]
        [InlineData(10, 1000)]
        public void BoxVolumeTest(int height, double expectedValue)
        {
            Box box = new Box(height);

            Assert.Equal(expectedValue, box.Volume(), 3);
        }

        [Fact]
        public void CyllenderVolumeTest()
        {
            Cylinder cylinder = new Cylinder(10, 10);

            Assert.Equal(3141.59, cylinder.Volume(), 1);
        }
    }
}
