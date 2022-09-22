using System.Formats.Asn1;

namespace SquareLib
{
    public class Triangle : Figure
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
                else if ((side2 + value) > side3 && (value + side3) > side2 && (side2 + side3) > value)
                {
                    throw new ArgumentException("Impossible values");
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
                }else if((side1 + value) > side3 && (value + side3) > side1 && (side1 + side3) > value)
                {
                    throw new ArgumentException("Impossible values");
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
                else if ((side1 + value) > side2 && (value + side2) > side1 && (side1 + side2) > value)
                {
                    throw new ArgumentException("Impossible values");
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

        private double isRight()
        {
            double tempSide1, tempSide2, tempSide3;
            tempSide1 = Math.Max(side1, Math.Max(side2, side3));
            tempSide3 = Math.Min(side1, Math.Min(side2, side3));
            tempSide2 = side1 + side2 + side3 - tempSide1 - tempSide3;

            if(Math.Pow(tempSide1, 2) == Math.Pow(tempSide2, 2) + Math.Pow(tempSide3, 2))
            {
                return (tempSide2 * tempSide3) / 2;
            }
            else
            {
                return 0;
            }
        }


        public override double calcSquare()
        {
            double area;
            if ((area = isRight()) != 0)
            {
                return area;
            }
            double p = (side1 + side2 + side3) / 2;
            area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return area;
        }
    }
}
