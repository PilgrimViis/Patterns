using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class SimpleLogEntry : LogEntry
    {
        internal override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }
    }
}
