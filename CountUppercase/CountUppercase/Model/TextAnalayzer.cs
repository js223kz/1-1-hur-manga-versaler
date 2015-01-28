using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountUppercase.Model
{
    public class TextAnalayzer
    {
       
        public int GetNumberOfCapitals(string text)
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