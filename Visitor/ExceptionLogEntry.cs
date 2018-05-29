using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ExceptionLogEntry : LogEntry
    {
        internal override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }
    }
}
