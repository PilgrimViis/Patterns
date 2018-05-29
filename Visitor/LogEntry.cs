using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    abstract class LogEntry
    {
        internal abstract void Accept(ILogEntryVisitor logEntryVisitor);
    }
}
