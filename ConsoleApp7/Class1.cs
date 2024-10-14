namespace ConsoleApp7
{
    class UserInterface
    {
        public void BackroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.Clear(); 
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

        public void Title(string s)
        {
            Console.Title = s; 
        }      

        public int ShoiseBackroundColor(string s)
        {
            int result = 0;

            if (s == "red")
            {
                result = 1;
            }
            else if (s == "yellow")
            {
                result = 2;
            }
            else if (s == "blue")
            {
                result = 3;
            }
            else if (s == "white")
            {
                result = 4;
            }
            else if (s == "magenta")
            {
                result = 5;
            }
            else
            {
                result = 6; 
            }

            return result;
        }
    }
}
