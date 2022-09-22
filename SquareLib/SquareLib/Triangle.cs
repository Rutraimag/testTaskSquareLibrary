namespace SquareLib
{
    internal class Triangle : Figure
    {
        private double side1, side2, side3;
        
        public double Side1
        {
            get => side1;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Should not negative value");
                }
                side1 = value;
            }
        }

        public double Side2
        {
            get => side2;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Should not negative value");
                }
                side2 = value;
            }
        }

        public double Side3
        {
            get => side3;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Should not negative value");
                }
                side3 = value;
            }
        }

        private Triangle() : base("Triangle")
        {
            side1 = side2 = side3 = 0;
        }

        public Triangle(double side1, double side2, double side3) : this()
        {
            if(side1 < 0 || side2 < 0 || side3 < 0)
            {
                throw new ArgumentException("Should not negative value");
            }
            if ((side1 + side2) > side3 && (side2 + side3) > side1 && (side1 + side3) > side2)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            else
            {
                throw new ArgumentException("Impossible values");
            }
        } 

        public override double calcSquare()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
    }
}
