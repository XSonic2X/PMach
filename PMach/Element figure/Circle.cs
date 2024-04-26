namespace PMach.Element_figure
{
    public class Circle : IFigure
    {

        public Circle(int radius) 
        {
            _radius = radius;
        }

        private int _radius;

        public double Area() => Mathematics.AreaCircle(_radius);

        public override string ToString() => $"Окружность с радиусом:{_radius}";
    }
}
