using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaJalalAssignment1
{
    class Program
    {
        static int PrintMenu()
        {
            string userInput = string.Empty;
            int menuSelection = -1;
            Console.Clear();
            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Length");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");
            userInput = Console.ReadLine();
            try
            {
                menuSelection = int.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return menuSelection;
        }

        static Rectangle CreateNewRectangleFromUserInput()
        {
            int length = 0;
            int width = 0;
            string userLengthInput = string.Empty;
            string userWidthInput = string.Empty;

            Console.WriteLine("Please enter the length of the rectangle. Values must be an integer and greater than 0");
            while (!(length>0))
            {
                try
                {
                    userLengthInput = Console.ReadLine();
                    length = int.Parse(userLengthInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Please enter the width of the rectangle. Values must an intenger and greater than 0");
            while (!(width>0))
            {
                try
                {
                    userWidthInput = Console.ReadLine();
                    width = int.Parse(userWidthInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Rectangle rec = new Rectangle(length,width);
            return rec;
        }

        static int ChangeRectangleParam()
        {
            int param = 0;
            string userParamInput = string.Empty;

            Console.WriteLine("Please enter an integer with a value greater than 0");
            while (!(param>0))
            {
                try
                {
                    userParamInput = Console.ReadLine();
                    param = int.Parse(userParamInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return param;
        }

        static void Main(string[] args)
        {
            int menuSelected;
            Rectangle rectangle;
            bool exited = false;
            rectangle = CreateNewRectangleFromUserInput();

            while (!exited)
            {
                menuSelected = PrintMenu();
                while (menuSelected == -1)
                {
                    menuSelected = PrintMenu();
                }

                switch (menuSelected)
                {
                    case 1:
                        Console.WriteLine($"Rectangle length is {rectangle.GetLength()}");
                        break;
                    case 2:
                        rectangle.SetLength(ChangeRectangleParam());
                        break;
                    case 3:
                        Console.WriteLine($"Rectangle width is {rectangle.GetWidth()}");
                        break;
                    case 4:
                        rectangle.SetWidth(ChangeRectangleParam());
                        break;
                    case 5:
                        Console.WriteLine($"Rectangle perimeter is {rectangle.GetPerimeter()}");
                        break;
                    case 6:
                        Console.WriteLine($"Rectangle area is {rectangle.GetArea()}");
                        break;
                    case 7:
                        Console.WriteLine("Thank you, exiting now...");
                        exited = true;
                        break;
                }
                if (!exited)
                {
                    Console.WriteLine("press any key to continue to menu");
                    Console.ReadKey();
                }
            }
        }
    }
}
