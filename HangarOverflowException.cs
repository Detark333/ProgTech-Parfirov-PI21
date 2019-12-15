using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlains
{
    class HangarOverflowException : Exception
    {
        public HangarOverflowException() : base("В ангарах нет свободных мест")
        { }
    }
}
