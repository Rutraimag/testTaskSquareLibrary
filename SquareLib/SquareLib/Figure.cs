namespace SquareLib
{
    public abstract class Figure
    {
        private String type { get; }

        protected Figure(String _type)
        {
            type = _type;
        }

        public abstract double calcSquare();
    }
}