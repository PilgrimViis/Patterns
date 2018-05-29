using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class DatabaseLogSaver : ILogEntryVisitor
    {
        void ILogEntryVisitor.Visit(ExceptionLogEntry exceptionLogEntry)
        {
            SaveException(exceptionLogEntry);
        }

        void ILogEntryVisitor.Visit(SimpleLogEntry simpleLogEntry)
        {
            SaveSimpleLogEntry(simpleLogEntry);
        }

        public void SaveLogEntry(LogEntry logEntry)
        {
            logEntry.Accept(this);
        }

        private void SaveSimpleLogEntry(SimpleLogEntry logEntry) { }
        private void SaveException(ExceptionLogEntry exceptionEntry) { }
    }
}
