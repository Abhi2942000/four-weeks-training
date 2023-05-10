// See https://aka.ms/new-console-template for more information
namespace AreaOfCircleUsingMethod
{
    class Circle
    {
        public void GetArea(int r)
        {
            double cArea;
            cArea = 3.14 * r * r;
            Console.WriteLine("Area Of Circle {0} ", cArea);
        }

        public void GetCircumference(int r)
        {
            double cCircumference;
            cCircumference = 3.14 * r * r;
            Console.WriteLine("cCircumference Of Circle {0} ", cCircumference);
        }

    }

    class Program
    {
        static public void Main()
        {
            Circle c = new Circle();
            c.GetArea(2);
            c.GetCircumference(8);

        }

    }
}
