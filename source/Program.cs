using Practice_1_source.Figures;

namespace Practice_1_source
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[] 
            {
                new Circle(3),
                new Rectangle(5, 8),
                new Triangle(3, 4, 5)
            };

            foreach (var figure in figures) Console.WriteLine(figure);
        }
    }
}