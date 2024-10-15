using System.Text;

namespace ConsoleApp7
{
    class ApplicationSettingsHelper
    {
        string BackgroundColor;
        string TextColor;
        string WindowSize;
        string Title;

        public ApplicationSettingsHelper(ConsoleColor bg, ConsoleColor tc, int width, int height, string title)
        {
            BackgroundColor = bg.ToString();
            TextColor = tc.ToString();
            WindowSize = $"{width}x{height}";
            Title = title;
        }

        public void WriteFile()
        {
            string line = $"BackgroundColor: {BackgroundColor}\nTextColor: {TextColor}\nWindowSize: {WindowSize}\nTitle: {Title}";

            using (StreamWriter sw = new StreamWriter("Console.txt", true, Encoding.Default))
            {
                sw.WriteLine(line);
            }

            Console.WriteLine("Settings have been saved to file.");
        }
         
        public void ReadFile()
        {
          
            StreamReader sr = new StreamReader("Console.txt", Encoding.Default);
            string line = sr.ReadToEnd();
            Console.WriteLine("Settings loaded from file:");
            Console.WriteLine(line);
                
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
          
        }
    }

}
