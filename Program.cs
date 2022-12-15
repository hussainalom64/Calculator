using System;

namespace Basicsplus
{
    public class Program
    {
        static int displayMenu()
        {
            int selection;
            Console.WriteLine("Arithmetic Menu");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("Input 1, 2, 3 or 4");
            selection = Convert.ToInt32(Console.ReadLine());
            return selection;
            
        }
        static void Main(string[] args)
        {
            
            double numA;
            double numB;
            double ans = 0;
            bool error = false;
            int option;
            Console.WriteLine("Put in a number");
            numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Put in another number");
            numB = Convert.ToDouble(Console.ReadLine());
            
            option = displayMenu();

            /*if (option == 1)
            {
                ans = numA + numB;
            }
            else if (option == 2)
            {
                ans = numA - numB;
            }
            else if (option == 3)
            {
                ans = numA * numB;
            }
            else if (option == 4)
            {
                ans = numA / numB;
            }
            else
            {
                Console.WriteLine("Option doesn't exist.");
            }*/

            switch (option)
            {
                case 1: ans = numA + numB;
                    break;
                case 2: ans = numA - numB;
                    break;
                case 3: ans = numA * numB;
                    break;
                case 4: ans = numA / numB;
                    break;
                default: error = true;
                    break;
            }
            if (error)
            {
                Console.WriteLine("Invalid option");
                Console.WriteLine("Must choose 1, 2, 3 or 4!");
            }
            else
            {
                Console.WriteLine("Answer is " + ans);
            }
                    
        }
    }
}