using PolygonCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class PolygonTest
    {
        [Fact]
        public void PerimeterTest()
        {
            var points = new List<Point>()
            {
                new Point("Point1", 10, 10),
                new Point("Point2", 20, 20),
                new Point("Point3", 20, 10)
            };

            var polygon = new Polygon("Polygon", points);

            Assert.Equal(34.1421, polygon.GetPerimetr, 3);
        }
    }
}
