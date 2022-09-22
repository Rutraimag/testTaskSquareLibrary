namespace SquareLib
{
    public class Circle : Figure
    {
        private double radius;
        public double Radius
        { 
            get => radius;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Should not negative value");    
                }
                radius = value;
            }
        }

        private Circle() : base("Circle")
        {
            radius = 0;
        }

        public Circle(double _radius) : this()
        {
            if(_radius < 0)
            {
                throw new ArgumentException("Should not negative value");
            }
            radius = _radius;
        }

        public override double calcSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
}
