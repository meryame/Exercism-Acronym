using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_Acronym
{
    public class Acronym
    {
        public static string Abbreviat(string phrase)
        {
            var result = "";
            char[] separators = { ' ', '-', '_', ',' };
            var words = phrase.Split(separators , StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                result += word.ToUpper()[0];
            }
            return result;
        }
    }
}
