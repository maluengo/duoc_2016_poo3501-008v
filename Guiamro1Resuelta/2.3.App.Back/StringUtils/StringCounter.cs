using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3.App.Back.StringUtils
{
    public class StringCounter
    {
        public int CounteHowManyCharsInStringMethod1(string toCounte, string charToFind)
        {
            int counter = 0;

            if (!string.IsNullOrEmpty(toCounte) && (!string.IsNullOrEmpty(charToFind)))
            {
                foreach (char ch in toCounte)
                {
                    if (ch == char.Parse(charToFind))
                    {
                        counter++;
                    }

                }
            }
              
            return counter;
        }

        public int CounteHowManyCharsInStringMethod2(string toCounte, string charToFind)
        {
            int counter = 0;

            if (!string.IsNullOrEmpty(toCounte) && (!string.IsNullOrEmpty(charToFind)))
            {
                counter = toCounte.Count(f => f == char.Parse(charToFind));
            }

            return counter;
        }
    }
}
