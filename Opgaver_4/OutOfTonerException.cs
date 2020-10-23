using System;

namespace Opgaver_4
{
    public class OutOfTonerException : Exception
    {
        public OutOfTonerException(string m) : base(m)
        {

        }
    }
}

