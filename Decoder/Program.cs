using System.Text;
using NAudio.Midi;

namespace Decoder
{
    internal class Program
    {
        static void Main()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using FileStream fs = new FileStream("C:\\Lyrics\\Твої очі.txt", FileMode.Open, FileAccess.Read);
            using StreamReader reader = new StreamReader(fs, Encoding.GetEncoding(1252));
            var text = reader.ReadToEnd();

             //   string text = File.ReadAllText("C:\\Lyrics\\Твої очі.txt", Encoding.GetEncoding(1251));
            Console.WriteLine(text);


       //     var textReader = new StreamWriter("C:\\Lyrics\\Твої очі.txt");


        }
    }
}
