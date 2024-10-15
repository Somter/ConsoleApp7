using System;
using System.IO;
using System.Text;

namespace ConsoleApp7
{
    class UserInterface
    {
        public void BackgroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }

        public void ForegroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void WindowSize(int width, int height)
        {
            try
            {
                Console.SetWindowSize(width, height);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Размер превышает допустимые пределы.");
            }
        }

        public void Title(string title)
        {
            Console.Title = title;
        }

        public ConsoleColor ChooseColor(string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine("Available colors: red, yellow, blue, white, magenta, green, cyan");

            string s = Console.ReadLine().ToLower();
            switch (s)
            {
                case "red": return ConsoleColor.Red;
                case "yellow": return ConsoleColor.Yellow;
                case "blue": return ConsoleColor.Blue;
                case "white": return ConsoleColor.White;
                case "magenta": return ConsoleColor.Magenta;
                case "green": return ConsoleColor.Green;
                case "cyan": return ConsoleColor.Cyan;
                default:
                    Console.WriteLine("Invalid color, defaulting to black.");
                    return ConsoleColor.Black;
            }
        }

        public (int, int) InputWindowSize()
        {
            Console.WriteLine("Enter window width:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter window height:");
            int height = int.Parse(Console.ReadLine());

            return (width, height);
        }

        public string InputTitle()
        {
            Console.WriteLine("Enter the new window title:");
            return Console.ReadLine();
        }
    }
}