using System;

namespace Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "AB AB";

            Translator translator = new Translator();

            text = translator.Translate(text, Format.Text, Format.Binary);

            Console.Out.WriteLine(text);

            text = translator.Translate(text, Format.Binary, Format.Text);

            Console.Out.WriteLine(text);

            text = "AB";

            text = translator.Translate(text, Format.Text, Format.Morse);

            Console.Out.WriteLine(text);



        }
    }
}
