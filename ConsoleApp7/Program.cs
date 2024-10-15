using ConsoleApp7;

class Test
{
    public static void Main()
    {
        UserInterface userInterface = new UserInterface();
        ApplicationSettingsHelper appSettings = null;

        ConsoleColor bgColor = ConsoleColor.Black;
        ConsoleColor textColor = ConsoleColor.White;
        int windowWidth = 80;
        int windowHeight = 25;
        string title = "Default Title";

        bool exit = false;
        while (!exit)
        {
            Console.Clear(); 
            Console.WriteLine("--- Current Settings ---");
            Console.WriteLine($"Background Color: {bgColor}");
            Console.WriteLine($"Text Color: {textColor}");
            Console.WriteLine($"Window Size: {windowWidth}x{windowHeight}");
            Console.WriteLine($"Title: {title}\n");

            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1. Change background color");
            Console.WriteLine("2. Change text color");
            Console.WriteLine("3. Change window size");
            Console.WriteLine("4. Change window title");
            Console.WriteLine("5. Save settings to file");
            Console.WriteLine("6. Load settings from file");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    bgColor = userInterface.ChooseColor("Select background color:");
                    userInterface.BackgroundColor(bgColor);
                    break;
                case "2":
                    textColor = userInterface.ChooseColor("Select text color:");
                    userInterface.ForegroundColor(textColor);
                    break;
                case "3":
                    (windowWidth, windowHeight) = userInterface.InputWindowSize();
                    userInterface.WindowSize(windowWidth, windowHeight);
                    break;
                case "4":
                    title = userInterface.InputTitle();
                    userInterface.Title(title);
                    break;
                case "5":
                    appSettings = new ApplicationSettingsHelper(bgColor, textColor, windowWidth, windowHeight, title);
                    appSettings.WriteFile();
                    break;
                case "6":
                    if (appSettings == null)
                    {
                        appSettings = new ApplicationSettingsHelper(bgColor, textColor, windowWidth, windowHeight, title);
                    }
                    appSettings.ReadFile();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
