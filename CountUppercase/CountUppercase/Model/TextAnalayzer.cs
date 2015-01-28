using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountUppercase.Model
{
    public static class TextAnalayzer
    {
       
        public static int GetNumberOfCapitals(string text)
        {
            int numberOfUpperCase = 0;

            foreach (char var in text)
            {
                if (Char.IsUpper(var))
                {
                    numberOfUpperCase++;
                }
            }

            return numberOfUpperCase;
        }
    }
}