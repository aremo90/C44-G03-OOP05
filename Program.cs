using ConsoleApp1.Question_01;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 01
            ICircle Circle = new Circle(5.5);
            IRect Rectangle = new Rectangle(4, 6);

            Circle.DisplayShapeInfo();
            Rectangle.DisplayShapeInfo();

            #endregion

        }
    }
}
