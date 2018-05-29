using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var naive = new DatabaseLogSaver();
            naive.SaveLogEntry(new ExceptionLogEntry());

            var visitor = new DatabaseLogSaver();
            visitor.SaveLogEntry(new SimpleLogEntry());
        }
    }
}
