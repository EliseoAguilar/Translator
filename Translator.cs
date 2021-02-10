using System;
using System.Collections.Generic;
using System.Text;

namespace Translator
{
    class Translator : ITranslator
    {


    private List<KeyValuePair<char, string>> listBinary = new List<KeyValuePair<char, string>>() {
            new KeyValuePair<char, string>('A', "01000001"),
            new KeyValuePair<char, string>('B', "01000010"),
            new KeyValuePair<char, string>('C', "01000010"),

    };

    private List<KeyValuePair<char, string>> listMorse = new List<KeyValuePair<char, string>>() {
            new KeyValuePair<char, string>('A', "· —"),
            new KeyValuePair<char, string>('B', "— · · ·"),
            new KeyValuePair<char, string>('C', "— · — ·"),

    };




        public string BinaryToText(string binary)
        {

            string _srt = "";

            for (int i = 0; i < binary.Length / 8; i++) {

                _srt += listBinary.Find(c => c.Value == binary.Substring( i*8 , 8)  ).Key;
            }

            return _srt;
        }

        public string MorseTotext(string morse)
        {
            throw new NotImplementedException();

        }

        public string TextToBinary(string text)
        {
            string _srt = "";

            foreach (char _char in text.ToCharArray()) {

                _srt += listBinary.Find(c => c.Key == _char).Value;

            }

            return _srt;

        }

        public string TextToMorse(string text)
        {

            string _srt = "";

            foreach (char _char in text.ToCharArray())
            {

                _srt +=listMorse.Find(c => c.Key == _char).Value;

            }

            return _srt;
        }

        public string Translate(string text, Format origin, Format destination)
        {

            string _text = "";
            string _text2 = "";

            switch (origin)
            {
                case Format.Binary:
                    _text = BinaryToText(text);
                    break;
                case Format.Morse:
                    _text = MorseTotext(text);
                    break;
                case Format.Text:
                    _text = text;
                    break;
                default:
                    _text2 = "Formato de Origen Invalido";
                    break;
            }

            switch (destination)
            {
                case Format.Binary:
                    _text2 = TextToBinary(_text);
                    break;
                case Format.Morse:
                    _text2 = TextToMorse(_text);
                    break;
                case Format.Text:
                    _text2 = _text;
                    break;
                default:
                    _text2 = "Formato de Destino Invalido";
                    break;
            }

            return _text2;

        }
    }
}
