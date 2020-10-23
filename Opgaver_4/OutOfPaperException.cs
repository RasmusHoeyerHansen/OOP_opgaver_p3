using System;

namespace Opgaver_4
{
    public class OutOfPaperException : Exception
    {
        public OutOfPaperException(string message): base(message)
        {

        }
    }
}

