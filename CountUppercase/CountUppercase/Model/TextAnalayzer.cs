using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountUppercase.Model
{
    public class TextAnalayzer
    {
        public string Text{ get; set;}
   
        public int GetNumberOfCapitals(string text)
        {
            Text = text;
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