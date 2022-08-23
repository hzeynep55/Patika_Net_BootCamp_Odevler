﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_base.Excaption
{
    public class MessageResultException : Exception
    {
        public MessageResultException()
        {
        }

        public MessageResultException(string message) : base(message)
        {
        }

        public MessageResultException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
