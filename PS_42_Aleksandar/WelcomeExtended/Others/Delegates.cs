﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Helpers;

namespace WelcomeExtended.Others
{
    internal class Delegates
    {
        public static readonly ILogger logger = LoggerHelper.GetLogger("Hello");

        public static void Log(string error)
        {
            logger.LogError(error);
        }

        public static void Log2(string error)
        {
            Console.WriteLine("-Delegates-");
            Console.WriteLine($"{error}");
            Console.WriteLine("-Delegates-");
        }
        public delegate void ActionOnError(string errorMessage);
    }
}
