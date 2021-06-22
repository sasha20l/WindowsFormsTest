using System;

namespace WindowsFormsTest
{
    class ReverseText
    {
        public static string functionText(string text) 
        {
            char[] letters = text.ToCharArray();
            Array.Reverse(letters);

            return String.Concat(letters);
        }
    }
}
