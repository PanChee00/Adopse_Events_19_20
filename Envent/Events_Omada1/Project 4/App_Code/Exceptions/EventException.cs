﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.User_Classes.Exceptions
{
    class EventException : Exception
    {

        public EventException(string msg) : base(msg)
        {
        }

        public EventException()
        {

        }
    }
}
