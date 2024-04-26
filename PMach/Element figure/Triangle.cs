namespace PMach.Element_figure
{
    public class Triangle : IFigure
    {

        public Triangle(double lengthA, double lengthB, double lengthC) 
        {
            _lengthA = lengthA;
            _lengthB = lengthB;
            _lengthC = lengthC;
        }

        private double _lengthA;
        private double _lengthB;
        private double _lengthC;

        public double Area() => Mathematics.AreaTriangle(_lengthA,_lengthB,_lengthC);

        public override string ToString()
            => (Mathematics.TriangleRectangular(_lengthA, _lengthB, _lengthC) ?
            "Прямоугольны" :
            "Не прямоугольный"
            ) + $" треугольник с сторанами {_lengthA}:{_lengthB}:{_lengthC}";
    }
}
