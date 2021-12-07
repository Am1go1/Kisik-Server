using System;
using System.Collections.Generic;
using System.Text;

namespace Shareds.Exceptions
{
    public class NoteFoundException : Exception
    {
        public NoteFoundException(string message) : base(message)
        {

        }
    }
}
