using System;
using System.Collections.Generic;
using System.Text;

namespace Translator
{
    public interface ITranslator
    {

        public string Translate(string text, Format origin, Format destination);

        public string BinaryToText(string binary);

        public string MorseTotext(string morse);

        public string TextToBinary(string text);

        public string TextToMorse(string text);

    }
}
