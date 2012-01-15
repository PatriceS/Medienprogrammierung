using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programming
{
    class EmptyPictureBoxException : Exception
    {

        public EmptyPictureBoxException()
        {
        }

        public EmptyPictureBoxException(string message)
        : base(message)
        {
        }

        public EmptyPictureBoxException(string message, Exception inner)
        : base(message, inner)
        {
        }

    }
}
