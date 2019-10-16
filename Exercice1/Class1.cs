using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1
{
    class Class1
    {
        public static char RetourneChaine(char c)
        {
            int test = (int)c;

            if(test >= 120)
            {
                test = test + 3 - 26;
            }
            else
            {
                test = test + 3;
            }
            return Convert.ToChar(test);
        }
    }
}
