using ConsoleApp1.Question_01;
using ConsoleApp1.Question_02;
using ConsoleApp1.Question_03;
using ConsoleApp1.Question_04;

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

            //IAuthenticationService authService = new BasicAuthenticationService();

            //Console.Write("Enter username: ");
            //string username = Console.ReadLine().ToLower();

            //Console.Write("Enter password: ");
            //string password = Console.ReadLine();

            //if (authService.AuthenticateUser(username, password))
            //{
            //    Console.WriteLine("Authentication successful.");

            //    Console.Write("Enter role to check: ");
            //    string role = Console.ReadLine().ToLower();

            //    if (authService.AuthorizeUser(username, role))
            //    {
            //        Console.WriteLine("Authorization successful.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Authorization failed.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed.");
            //}

            #endregion
            #region Question 03
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification("hamza@example.com", "Welcome to our platform!");
            //smsService.SendNotification("+201234567890", "Your verification code is 1234.");
            //pushService.SendNotification("HamzaDeviceToken", "You have a new message.");

            #endregion
            #region Question 04
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter user type (Regular / Premium / Guest): ");
            string userType = Console.ReadLine().ToLower();

            Question_04.User user;

            switch (userType)
            {
                case "regular":
                    user = new RegularUser(userName);
                    break;
                case "premium":
                    user = new PremiumUser(userName);
                    break;
                case "guest":
                    user = new GuestUser(userName);
                    break;
                default:
                    Console.WriteLine("Invalid user type. Defaulting to Guest.");
                    user = new GuestUser(userName);
                    break;
            }

            Console.Write("Enter product price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Discount discount = user.GetDiscount();
            decimal discountAmount = discount.CalculateDiscount(price, quantity);
            decimal finalPrice = price * quantity - discountAmount;

            Console.WriteLine($"\nUser: {user.Name} ({userType.ToUpper()})");
            Console.WriteLine($"Applied Discount: {discount.Name}");
            Console.WriteLine($"Total Discount: {discountAmount:C}");
            Console.WriteLine($"Final Price: {finalPrice:C}");
        }

        #endregion

    }
    }
