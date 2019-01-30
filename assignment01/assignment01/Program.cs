using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment01
{
    class Program
    {
       
        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle Length");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Length");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit\n");

                Console.WriteLine("Please select an option, by entering a number:\n");
                userInput = Console.ReadLine();

                if(userInput != "1" &&
                   userInput != "2" &&
                   userInput != "3" &&
                   userInput != "4" &&
                   userInput != "5" &&
                   userInput != "6" &&
                   userInput != "7")
                {
                    Console.WriteLine("That's not a valid menu option, please try again:\n");
                }
                else
                {
                    validMenuSelect = true;
                }
            }
            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateUserInput(string rectSide)
        {
            int number = 1;
            bool isValid = false;

            while(isValid == false)
            {
                Console.WriteLine($"Please enter the {rectSide} of your rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input, please try again.\n");
                }
                else if(number < 0)
                {
                    Console.WriteLine("Number cannot be less than 0, please try again.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The {rectSide} of your rectangle is now {number}.\n");
                }
            }

            return number;
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            bool validRectangleSelect = false;
            string rectangleSelection;
            int selection;

            while(validRectangleSelect == false)
            {
                Console.WriteLine("1 = Create default (1 unit X 1 unit) Rectangle");
                Console.WriteLine("2 = Create custom REctangle");
                Console.WriteLine("Choose a menu item to begin:");
                rectangleSelection = Console.ReadLine();
                Console.WriteLine();

                if (rectangleSelection != "1" && rectangleSelection != "2")
                {
                    Console.WriteLine("That's not a valid selection, please try again.\n");
                }
                else if (int.Parse(rectangleSelection) == 1)
                {
                    validRectangleSelect = true;
                    int length = 1;
                    int width = 1;

                    
                    Console.WriteLine($"The length of rectangle is {length} and width is {width}.\n");
                    Rectangle customRectangle = new Rectangle(length, width);
                    r = customRectangle;
                }
                else if (int.Parse(rectangleSelection) == 2)
                {
                    validRectangleSelect = true;

                    int length;
                    int width;

                    length = ValidateUserInput("length");
                    width = ValidateUserInput("width");

                    Console.WriteLine($"Your custom  numbers are {length} and {width}.\n");
                    Rectangle customRectangle = new Rectangle(length, width);
                    r = customRectangle;
                }
            }

            selection = ValidateMenuSelection();
            while(selection != 7)
            {
                int result;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"Length is: {r.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateUserInput("length");
                        r.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Width is: {r.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateUserInput("Width");
                        r.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The result of area {r.GetLength()} * {r.GetWidth()} is: {r.GetArea()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"The result of perimeter {r.GetLength()} * {2} + {r.GetWidth()} * {2} is: {r.GetPerimeter()}\n");
                        break;
                    default:
                        break;
                }
                selection = ValidateMenuSelection();
            }

        }
    }
}
