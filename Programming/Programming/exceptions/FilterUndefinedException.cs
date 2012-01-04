using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programming
{
    class FilterUndefinedException : Exception
    {
        public FilterUndefinedException()
        {
        }

        public FilterUndefinedException(string message)
        : base(message)
        {
        }

        public FilterUndefinedException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
