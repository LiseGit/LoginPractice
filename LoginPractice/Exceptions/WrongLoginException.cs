﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPractice.Exceptions
{
    public class WrongLoginException : Exception
    {
        public WrongLoginException() : base() { }
        public WrongLoginException(string message) : base(message) { }
    }
}
