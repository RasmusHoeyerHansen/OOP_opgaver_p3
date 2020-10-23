using System;

namespace Opgaver_4
{
    public class IllegalGearChangeException : Exception
    {
        public IllegalGearChangeException(string message) : base(message) 
        {
        }
    }

}

