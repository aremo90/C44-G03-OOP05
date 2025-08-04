using ConsoleApp1.Question_01;
using ConsoleApp1.Question_02;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 01
            //ICircle Circle = new Circle(5.5);
            //IRect Rectangle = new Rectangle(4, 6);

            //Circle.DisplayShapeInfo();
            //Rectangle.DisplayShapeInfo();

            #endregion
            #region Question 02

            IAuthenticationService authService = new BasicAuthenticationService();

            Console.Write("Enter username: ");
            string username = Console.ReadLine().ToLower();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (authService.AuthenticateUser(username, password))
            {
                Console.WriteLine("Authentication successful.");

                Console.Write("Enter role to check: ");
                string role = Console.ReadLine().ToLower();

                if (authService.AuthorizeUser(username, role))
                {
                    Console.WriteLine("Authorization successful.");
                }
                else
                {
                    Console.WriteLine("Authorization failed.");
                }
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }

            #endregion

        }
    }
}
