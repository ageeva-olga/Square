
namespace SquareC​ircleAndTriangle
{
    public class Circle : Point, ISquare
    {
        public int R;
        public Circle(int x, int y, int r) : base(x, y)
        {
            R = r;
        }
        public double Square
        {
            get
            {
                return Math.PI * R * R;
            }
        }
    }
}
