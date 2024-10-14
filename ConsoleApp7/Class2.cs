using System.Text;

namespace ConsoleApp7
{
    class ApplicationSettingsHelper
    {
        string BackroudColor;
        string TextColor;
        string WindowSize;
        string Title;

        public ApplicationSettingsHelper(ConsoleColor bg, ConsoleColor tc, int width, int height, string title)
        {
            BackroudColor = bg.ToString();
            TextColor = tc.ToString();
            WindowSize = $"{width}x{height}";
            Title = title;
        }

        public void WriteFile()
        {
            string line = $"BackgroundColor: {BackroudColor}\nTextColor: {TextColor}\nWindowSize: {WindowSize}\nTitle: {Title}";
        
            StreamWriter sw = new StreamWriter("Console.txt", true, Encoding.Default);  
            sw.WriteLine(line);
            sw.Close();
        }

        public void ReadFile() 
        {
            StreamReader sr = new StreamReader("Console.txt", Encoding.Default);    
            string line = sr.ReadToEnd();
            Console.WriteLine(line);
            sr.Close();
        }
    }
}
