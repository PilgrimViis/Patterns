using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal interface ILogEntryVisitor
    {
        void Visit(ExceptionLogEntry exceptionLogEntry);
        void Visit(SimpleLogEntry simpleLogEntry);
    }
}
