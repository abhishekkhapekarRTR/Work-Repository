using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class ExtensionMethods //: IEnumerable<int>
    {
        IEnumerable<int> numbers = new List<int>() { 1, 5, 10, 12, 50 };
    }

    public static class StringExteisions
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if(numberOfWords < 0) 
            {
                throw new ArgumentOutOfRangeException("Number of words shold be greater than or equal to 0.");
            }
            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
