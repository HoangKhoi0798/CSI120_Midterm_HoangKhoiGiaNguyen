using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSI120_Midterm_HoangKhoiGiaNguyen
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // Hoang Khoi Gia Nguyen
            // CSI 120 - Computer Programming 1
            // Midterm
            // May 12 2024

            Console.WriteLine("Hoang Khoi Gia Nguyen - 05/12/2024");
            Console.WriteLine("CSI 120 - Computer Programming I - Midterm Menu");
            Console.WriteLine();
            Menu();

        }

        public static void Menu() // Main selection menu
        {

            // Choices
            Console.WriteLine("1 - Personal Calculator");
            Console.WriteLine("2 - Finance Calculator");
            Console.WriteLine("3 - Geometry Calculator");
            Console.WriteLine("4 - Cartesian Plane");
            Console.WriteLine("E - Exit");
            Console.WriteLine();
            Console.Write("Select your option: ");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                BasicCalculator();
            }
            else if (userInput == "2")
            {
                FinanceCalculator();
            }
            else if (userInput == "3")
            {
                GeometryCalculator();
            }
            else if (userInput == "4")
            {
                CartesianPlane();
            }
            else if (userInput == "E")
            {

                Console.WriteLine();
                Console.Write("Exiting. Press any key to exit the app.");
                Console.ReadKey();
                System.Environment.Exit(0);

            }// Shutdown

            else
            {

                Console.WriteLine();
                Console.WriteLine("Invalid input. Please try again.");
                Menu();
                Console.WriteLine();

            }

        }// End of Menu




        public static void BasicCalculator() // Personal Calculator
        {

            Console.WriteLine("Personal Calculator");
            Console.WriteLine();

            try // try catch for overarching error
            {

            Console.Write("Enter your first number: "); // First Number input
            decimal userNum1 = 0;
            bool isValid = false;

            while (!isValid)
            {
                string userInput = Console.ReadLine();
                isValid = decimal.TryParse(userInput, out userNum1);
                

                
                if (decimal.TryParse(userInput, out userNum1))
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Please enter a valid number: ");
                }
            } // End of checking first number

            Console.WriteLine();
            Console.WriteLine($"Your first number is: {userNum1}"); // Print out first number
            Console.WriteLine();

            Console.WriteLine("Choose an operation you would like to perform:"); //Choosing operation
            Console.WriteLine("+ - Add");
            Console.WriteLine("- - Subtract");
            Console.WriteLine("* - Multiply");
            Console.WriteLine("/ - Divide");
            Console.WriteLine("E - Exit");
            Console.WriteLine();

            Console.Write("Your selection: ");
            
            string userOperation = "?"; // Checking operation
            bool validOperation = false;
            while (!validOperation) 
            {
                string userInputOP = Console.ReadLine();
                
                if (userInputOP == "+" || userInputOP == "-" || userInputOP == "*" || userInputOP == "/")
            {
                    userOperation = userInputOP;
                Console.WriteLine($"Your chosen operation is: {userOperation} ");
                 validOperation = true;
            }
            else if (userInputOP == "E")
                {
                    Menu();
                }
            else
                {
                    Console.Write("Operation not found. Enter an available operation: ");
                }
            }

            Console.WriteLine();
            Console.Write("Enter your second number: ");// Enter second number
            decimal userNum2 = 0;
            bool isValid2 = false;

            while (!isValid2) // Checking second number
            {
                string userInput2 = Console.ReadLine();
                isValid2 = decimal.TryParse(userInput2, out userNum2);
                

                
                if (decimal.TryParse(userInput2, out userNum2))
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Please enter a valid number: ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Your second number is: {userNum2}");// Print second number
            Console.WriteLine();
            
            // Setting up operation

                 
            Console.WriteLine();
            
            if (userOperation == "+") // Printing chosen operation

            {
                decimal userSum = userNum1 + userNum2;
                Console.WriteLine($"{userNum1} {userOperation} {userNum2} = {userSum}");
            }
            else if (userOperation == "-")
            {
                decimal userSubtract = userNum1 - userNum2;
                Console.WriteLine($"{userNum1} {userOperation} {userNum2} = {userSubtract}");
            }
            else if (userOperation == "*")
            {
                decimal userMultiply = userNum1 * userNum2;
                Console.WriteLine($"{userNum1} {userOperation} {userNum2} = {userMultiply}");
            }
            else
            {
                decimal userDivide = userNum1 / userNum2;
                Console.WriteLine($"{userNum1} {userOperation} {userNum2} = {userDivide}");

            }
            
            
            }
            catch (Exception ex) // Printing error message
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex);
                Console.WriteLine("Restarting...");
                BasicCalculator();
            }
            // Loop back
            Console.WriteLine();
            BasicCalculator();

        } // End of Personal Calculator

        public static void FinanceCalculator()
        {
            Console.WriteLine("Finance Calculator");// Selection list
            Console.WriteLine("1 - Net income");
            Console.WriteLine("2 - Rule of 72");
            Console.WriteLine("3 - Net worth");
            Console.WriteLine("E - Exit");
            Console.WriteLine();
            Console.Write("Select a calculation: ");

            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                NetIncome();
            }
            else if (userInput == "2")
            {
                Rule72();
            }
            else if (userInput == "3")
            {
                NetWorth();
            }
            else if (userInput == "E")
            {
                Menu();
            }
            else 
            {
                Console.WriteLine("Invalid input. Please try again.");
                FinanceCalculator();
            }

            Console.WriteLine();
            FinanceCalculator();

        }// End of Finance Calculator

        public static void NetIncome() // Net income calculation
        {
            Console.WriteLine("Net Income calculation");
            Console.WriteLine();
            try 
            {
                Console.WriteLine("E - Exit");
                Console.Write("Enter Total Revenues: ");
                

                decimal userRevenue = 0;
                bool isValid = false;

                while (!isValid)
                {
                    string userInput = Console.ReadLine();
                    isValid = decimal.TryParse(userInput, out userRevenue);



                    if (decimal.TryParse(userInput, out userRevenue))
                    {
                        isValid = true;
                    }
                    else if (userInput == "E")
                    {
                        FinanceCalculator();
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }
                }
                decimal userCost = 0;
                bool isValid2 = false;

                Console.WriteLine(); 
                Console.WriteLine("E - Exit");
                Console.Write("Enter Total Costs: ");
                
                while (!isValid2)
                {
                    string userInput = Console.ReadLine();
                    isValid2 = decimal.TryParse(userInput, out userCost);



                    if (decimal.TryParse(userInput, out userCost))
                    {
                        isValid2 = true;
                    }
                    else if (userInput == "E")
                    {
                        FinanceCalculator();
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }
                }
                decimal userIncome = userRevenue - userCost;

                Console.Write("The net income is: ");
                Console.WriteLine(userIncome.ToString("c"));

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex);
                Console.WriteLine("Restarting...");
                NetIncome();

            }

            
        } // End of Net Income Calculation

        public static void Rule72() // Rule of 72 calculation
        {
            Console.WriteLine("Rule of 72 calculation");
            Console.WriteLine();
            try 
            {
                decimal userInterest = 0;
                bool isValid = false;
                Console.WriteLine("E - Exit");

                Console.Write("Enter interest rate: ");
                while (!isValid)
                {
                    string userInput = Console.ReadLine();
                    isValid = decimal.TryParse(userInput, out userInterest);



                    if (decimal.TryParse(userInput, out userInterest))
                    {
                        isValid = true;
                    }
                    else if (userInput == "E")
                    {
                        FinanceCalculator();
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }
                }

                Console.WriteLine();

                decimal userRule72 = 72 / userInterest;
                decimal userYear = Math.Round(userRule72, 1);

                Console.WriteLine($"It will take {userYear} year(s) to double the money with {userInterest}% interest rate");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex);
                Console.WriteLine("Restarting...");
                Rule72();

            }

            }// End of Rule 72

        public static void NetWorth() // Net worth calculation
        {
            Console.WriteLine("Net worth calculation");
            Console.WriteLine();
            try
            {
                Console.WriteLine("E - Exit");

                Console.Write("Enter asset amount: ");
                decimal userAssest = 0;
                bool isValid = false;
            while (!isValid)
            {
                string userInput = Console.ReadLine();
                isValid = decimal.TryParse(userInput, out userAssest);



                if (decimal.TryParse(userInput, out userAssest))
                {
                    isValid = true;
                }
                else if (userInput == "E")
                    {
                        FinanceCalculator();
                    }

                else
                {
                    Console.Write("Please enter a valid number: ");
                }
            }
                Console.WriteLine("E - Exit");

                Console.Write("Enter liability amount: ");
                decimal userLiability = 0;
                bool isValid2 = false;
                while (!isValid2)
                {
                    string userInput = Console.ReadLine();
                    isValid2 = decimal.TryParse(userInput, out userLiability);



                    if (decimal.TryParse(userInput, out userLiability))
                    {
                        isValid2 = true;
                    }
                    else if (userInput == "E")
                    {
                        FinanceCalculator();
                    }

                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }
                }

                decimal userNetWorth = userAssest - userLiability;
                Console.Write("Your net worth is: ");
                Console.WriteLine(userNetWorth.ToString("c"));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex);
                Console.WriteLine("Restarting...");
                NetWorth();
            }

        }// End of Net worth

        public static void GeometryCalculator()
        {
            Console.WriteLine("Geometry Calculator");
            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("3 - Circle");
            Console.WriteLine("4 - Right Circular Cone");
            Console.WriteLine("E - Exit");

            Console.WriteLine();
            Console.Write("Select your calculation: ");


            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Square();
            }
            else if (userInput == "2")
            {
                Rectangle();
            }
            else if (userInput == "3")
            {
                Circle();
            }
            else if (userInput == "4")
            {
                RightCircularCone();
            }
            else if (userInput == "E")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                GeometryCalculator();
            }

        }

        public static void Square() // Square calculation
        {
            Console.WriteLine("Square's area and perimeter calcualtion");
            Console.WriteLine();
            try
            {
                Console.Write("Enter square's side length: ");
                decimal userSquareSide = 0;
                bool isValid = false;

                while (!isValid)
                {
                    string userInput = Console.ReadLine();
                    isValid = decimal.TryParse(userInput, out userSquareSide);


                    if (decimal.TryParse(userInput, out userSquareSide))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }
                }

                decimal userSquarePerimeter = Math.Round(userSquareSide * 4, 2);
                decimal userSquareArea = Math.Round(userSquareSide * userSquareSide, 2);

                Console.WriteLine();
                Console.WriteLine($"Square Perimeter: {userSquarePerimeter}; Square Area: {userSquareArea} ");
                GeometryCalculator();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex);
                Console.WriteLine("Restarting...");
                Square();
            }

        }// End of Square calculation
        public static void Rectangle() // Rectangle calculation
        {
            Console.WriteLine("Rectangle's area and perimeter calculation");

            try
            {
                Console.Write("Enter rectangle's length: ");
                decimal userLength = 0;
                bool isValid = false;

                while (!isValid)
                {
                    string userInput = Console.ReadLine();
                    isValid = decimal.TryParse(userInput, out userLength);


                    if (decimal.TryParse(userInput, out userLength))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }
                }

                Console.Write("Enter rectangle's width: ");
                decimal userWidth = 0;
                bool isValid2 = false;

                while (!isValid2)
                {
                    string userInput = Console.ReadLine();
                    isValid2 = decimal.TryParse(userInput, out userWidth);


                    if (decimal.TryParse(userInput, out userWidth))
                    {
                        isValid2 = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }
                }

                decimal userRectanglePerimeter = Math.Round((userLength + userWidth) * 2, 2);
                decimal userRectangleArea = Math.Round(userLength * userWidth, 2);

                Console.WriteLine();
                Console.WriteLine($"Rectangle Perimeter: {userRectanglePerimeter}; Rectangle Area: {userRectangleArea} ");
                GeometryCalculator();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex);
                Console.WriteLine("Restarting...");
                Rectangle();
            }
        } // End of rectangle

        public static void Circle() // Circle calculation
        {
            Console.WriteLine("Circle's area and circumference calculation");
            try
            {
                Console.Write("Enter circle's radius: ");
                decimal userRadius = 0;
                bool isValid = false;

                while (!isValid)
                {
                    string userInput = Console.ReadLine();
                    isValid = decimal.TryParse(userInput, out userRadius);


                    if (decimal.TryParse(userInput, out userRadius))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }
                }
                
                decimal userCircleArea = Math.Round((userRadius * userRadius) * (decimal)Math.PI, 2);
                decimal userCircleCircumference = Math.Round( 2 * (decimal)Math.PI * userRadius, 2);

                Console.WriteLine();
                Console.WriteLine($"Circle Area: {userCircleArea}; Circle Circumference: {userCircleCircumference} ");
                GeometryCalculator();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex);
                Console.WriteLine("Restarting...");
                Circle();
            }
        } // End of circle

        public static void RightCircularCone() // Cone calculation
        {
            Console.WriteLine("Right circular cone's volume calculation");
            try
            {
                Console.Write("Enter cone's radius: ");
                decimal userRadius = 0;
                bool isValid = false;

                while (!isValid)
                {
                    string userInput = Console.ReadLine();
                    isValid = decimal.TryParse(userInput, out userRadius);


                    if (decimal.TryParse(userInput, out userRadius))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }
                }

                Console.Write("Enter cone's height: ");
                decimal userHeight = 0;
                bool isValid2 = false;

                while (!isValid2)
                {
                    string userInput = Console.ReadLine();
                    isValid2 = decimal.TryParse(userInput, out userHeight);


                    if (decimal.TryParse(userInput, out userHeight))
                    {
                        isValid2 = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }
                }

                decimal userVolume = Math.Round((decimal)Math.PI * (userRadius * userRadius) * (userHeight / 3), 2);

                Console.WriteLine();
                Console.WriteLine($"Cone Volume: {userVolume}");
                GeometryCalculator();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex);
                Console.WriteLine("Restarting...");
                RightCircularCone();
            }
        } // End of cone

        public static void CartesianPlane()
        {
            Console.WriteLine("Cartesian Plane");
            Console.WriteLine();
            try 
            {      
            Console.Write("Enter your X coordinate: ");
            string userInputX = Console.ReadLine();

            int userX = int.Parse(userInputX);
            Console.WriteLine();

            Console.Write("Enter your Y coordinate: ");
            string userInputY = Console.ReadLine();

            int userY = int.Parse(userInputY);
            Console.WriteLine();

            string userPosition = "?";
            if (userX > 0 && userY > 0)
            {
                userPosition = "Quadrant I";
            }
            else if (userX > 0 && userY < 0)
            {
                userPosition = "Quadrant IV";
            }
            else if (userX < 0 && userY < 0)
            {
                userPosition = "Quadrant III";
            }
            else if (userX < 0 && userY > 0)
            {
                userPosition = "Quadrant II";
            }
            else if (userX == 0 && userY == 0)
            {
                userPosition = "point of origin";
            }
            else if (userY == 0)
            {
                userPosition = "Y axis";
            }
            else
            {
                userPosition = "X axis";
            }
            Console.WriteLine($"Your coordination ({userX},{userY}) is on {userPosition}");
                Console.WriteLine();
                Console.Write("Press any key to return to main menu");
                Console.WriteLine();
                Console.ReadKey();
                Menu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex);
                Console.WriteLine("Restarting...");
                CartesianPlane();
            }
        }// Cartesian Plane End


    } // Class End

}// Name End
