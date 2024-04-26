using System.Numerics;

namespace PMach
{
    static public class Mathematics
    {

        /// <summary>
        /// Вычисление периметра круга если знаем радиус.
        /// </summary>
        /// <param name="Radius"></param>
        /// <returns></returns>
        static public double AreaCircle(double Radius) => Math.PI * Math.Pow(Radius, 2);

        /// <summary>
        /// Вычисление периметра треугольника  если знаем длину сторон.
        /// </summary>
        /// <param name="lengthA"></param>
        /// <param name="lengthB"></param>
        /// <param name="lengthC"></param>
        /// <returns></returns>
        static public double AreaTriangle(double lengthA, double lengthB, double lengthC)
        {
            double p = (lengthA + lengthB + lengthC) / 2;
            return Math.Sqrt(p * (p - lengthA) * (p - lengthB) * (p - lengthC));
        }

        /// <summary>
        /// Вычисление периметра круга от центра окружности на координатной плоскостью.
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        static public double AreaCircle(Vector2 vector1, Vector2 vector2)
            => AreaCircle(Distance(vector1, vector2));

        /// <summary>
        /// Вычисление периметра треугольника если знаем углы на координатной плоскостью.
        /// </summary>
        /// <param name="vectorA"></param>
        /// <param name="vectorB"></param>
        /// <param name="vectorC"></param>
        /// <returns></returns>
        static public double AreaTriangle(Vector2 vectorA, Vector2 vectorB, Vector2 vectorC)
            => AreaTriangle(Distance(vectorA, vectorB), Distance(vectorB, vectorC), Distance(vectorC, vectorA));

        /// <summary>
        /// Вычисление расстояния. 
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        static private double Distance(Vector2 vector1, Vector2 vector2)
            => Math.Sqrt( Math.Pow(vector1.X - vector2.X, 2) + Math.Pow(vector1.Y + vector2.Y, 2));

        /// <summary>
        /// Проверку на то является ли треугольник прямоугольным.
        /// </summary>
        /// <param name="lengthA"></param>
        /// <param name="lengthB"></param>
        /// <param name="lengthC"></param>
        /// <returns></returns>
        static public bool TriangleRectangular(double lengthA, double lengthB, double lengthC)
        {
            double[] lTriangle = [lengthA, lengthB, lengthC];
            double max = 0, x = 0;
            int i = 0, ignore = -1;
            for (i = 0; i < lTriangle.Length;i++ )
            {
                if (lTriangle[i] > max) 
                { 
                    max = lTriangle[i];
                    ignore = i;
                }
            }
            max = Math.Pow(max, 2);
            for (i = 0;i < lTriangle.Length;i++)
            {
                if (ignore == i) { continue; }
                x += Math.Pow(lTriangle[i], 2);
            }
            return x == max;
        }
    }
}
