using ConsoleApp7;

class Test
{
    public static void Main()
    {
        try
        {
            UserInterface userInterface = new UserInterface();

            Console.WriteLine("Select background color: red, yellow, blue, white, magenta");
            string s = Console.ReadLine();
            int choise = userInterface.ShoiseBackroundColor(s);

            ConsoleColor bgColor = ConsoleColor.Black;  
            switch (choise)
            {
                case 1:
                    bgColor = ConsoleColor.Red;
                    userInterface.BackroundColor(ConsoleColor.Red);
                    break;
                case 2:
                    bgColor = ConsoleColor.Yellow;
                    userInterface.BackroundColor(ConsoleColor.Yellow);
                    break;
                case 3:
                    bgColor = ConsoleColor.Blue;
                    userInterface.BackroundColor(ConsoleColor.Blue);
                    break;
                case 4:
                    bgColor = ConsoleColor.White;
                    userInterface.BackroundColor(ConsoleColor.White);
                    break;
                case 5:
                    bgColor = ConsoleColor.Magenta;
                    userInterface.BackroundColor(ConsoleColor.Magenta);
                    break;
                case 6:
                    Console.WriteLine("Wrong color");
                    break;
            }

            
            int maxWidth = Console.LargestWindowWidth;
            int maxHeight = Console.LargestWindowHeight;
            Console.WriteLine($"Maximum allowed size: {maxWidth} x {maxHeight}");

            int width = 200;
            int height = 20;
            userInterface.WindowSize(width, height);
             
            ConsoleColor textColor = ConsoleColor.Green;
            userInterface.ForegroundColor(ConsoleColor.Green);

            string title = "Title";
            userInterface.Title(title);

            Console.WriteLine("The title and window size have been set successfully!");

            ApplicationSettingsHelper applicationSettingsHelper = new ApplicationSettingsHelper(bgColor, textColor, width, height, title);
            applicationSettingsHelper.WriteFile();  
            applicationSettingsHelper.ReadFile();   
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
