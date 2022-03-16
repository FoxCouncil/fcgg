using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FCGG
{
    public static class Log
    {
        private const int MAX_BUFFER = 100;

        private static readonly List<string> _buffer = new List<string>(MAX_BUFFER);

        public static ReadOnlyCollection<string> LogBuffer => _buffer.AsReadOnly();

        public static void WriteLine(string line)
        {
            _buffer.Add(line);
            
            Console.WriteLine(line);
        }
    }
}