﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LabSeven
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<GeographicalUnit> countries = new List<GeographicalUnit>();
            List<LogEntry> log = new List<LogEntry>();
            Sorter.Execute();
        }
    }
}
