﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to Console { message }");
        }
    }
}
