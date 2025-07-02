using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH2Practice
{
    public class TimeException : Exception
    {
        public TimeException()
        {
        }

        public TimeException(string? message) : base(message)
        {
        }
    }
}
