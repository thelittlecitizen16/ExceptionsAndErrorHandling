using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsAndErrorHandling
{
    public class ScubaException : Exception
    {
        private int _studentNumber;

        public ScubaException(string message, int studentNumber)
            : base(message)
        {
            _studentNumber = studentNumber;
        }
    }
}
