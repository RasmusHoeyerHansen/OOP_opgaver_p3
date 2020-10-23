using System;
using System.Collections.Generic;

namespace Opgaver_4
{
    public class DigitalClock
    {
        List<int> digits = new List<int>();
        public int GetDigit(int i)
        {
            try
            {
                return digits[i];
            }
            catch (NoSuchDigitException e)
            {
                Console.WriteLine("NO such digit");
                throw e;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public void SetDigit(int i, int v)
        {
            try
            {
                digits[i] = v;
            }
            catch (IllegalDigitException e)
            {

                throw e;
            }
        }

    }
}

