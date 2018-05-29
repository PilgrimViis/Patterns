using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class DatabaseLogSaverNaive
    {
        internal void SaveLogEntry(LogEntry logEntry)
        {
            var exception = logEntry as ExceptionLogEntry;
            if (exception != null)
            {
                SaveException(exception);
            }
            else
            {
                var simpleLogEntry = logEntry as SimpleLogEntry;
                if (simpleLogEntry != null)
                {
                    SaveSimpleLogEntry(simpleLogEntry);
                }
            }
        }

        private void SaveSimpleLogEntry(SimpleLogEntry logEntry) { }
        private void SaveException(ExceptionLogEntry exceptionEntry) { }
    }
}
