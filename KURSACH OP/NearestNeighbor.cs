using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH_OP
{
    public class NearestNeighbor
    {
        public static List<Point> NearestNeighborAlgorithm(List<Point> cities)
        {
            int n = cities.Count;
            List<Point> path = new List<Point>();
            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++)
            {
                visited[i] = false;
            }
            visited[0] = true;
            path.Add(cities[0]);

            for (int i = 0; i < n - 1; i++)
            {
                double minDistance = double.MaxValue;
                int closestCity = -1;
                for (int j = 0; j < n; j++)
                {
                    if (!visited[j])
                    {
                        double distance = CalculateDistance(path[i], cities[j]);
                        if (distance < minDistance)
                        {
                            minDistance = distance;
                            closestCity = j;
                        }
                    }
                }
                path.Add(cities[closestCity]);
                visited[closestCity] = true;
            }
            return path;
        }

        public static double CalculateDistance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

    }
}
