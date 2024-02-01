using KURSACH_OP;
using System.Drawing;
using NUnit.Framework;
using System.Collections.Generic;


namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void NearestNeighborAlgorithm_ReturnsExpectedPath()
        {
            List<Point> cities = new List<Point>
        {
            new Point(0, 0),
            new Point(3, 4),
            new Point(6, 8),
            new Point(9, 1)
        };

            List<Point> expectedPath = new List<Point>
        {
            new Point(0, 0),
            new Point(3, 4),
            new Point(6, 8),
            new Point(9, 1)
        };

            List<Point> result = NearestNeighbor.NearestNeighborAlgorithm(cities);

            CollectionAssert.AreEqual(expectedPath, result);
        }

        [Test]
        public void CalculateDistance_ReturnsExpectedDistance()
        {
            Point a = new Point(0, 0);
            Point b = new Point(3, 4);

            double expectedDistance = 5.0;

            double result = NearestNeighbor.CalculateDistance(a, b);

            Assert.That(result, Is.EqualTo(expectedDistance));

        }
        [Test]
        public void NearestNeighborAlgorithm_ReturnsValidPathWithFourCities()
        {
            List<Point> cities = new List<Point>
    {
        new Point(0, 0),
        new Point(3, 4),
        new Point(6, 8),
        new Point(9, 1)
    };

            List<Point> result = NearestNeighbor.NearestNeighborAlgorithm(cities);

            // Проверяем, что возвращенный путь содержит все города и не содержит дубликатов
            Assert.That(result.Count, Is.EqualTo(cities.Count));
            CollectionAssert.AllItemsAreUnique(result);
        }


        [Test]
        public void CalculateDistance_ReturnsZeroForSamePoint()
        {
            Point a = new Point(2, 2);
            double expectedDistance = 0.0;

            double result = NearestNeighbor.CalculateDistance(a, a);

            Assert.That(result, Is.EqualTo(expectedDistance));
        }
    }
}