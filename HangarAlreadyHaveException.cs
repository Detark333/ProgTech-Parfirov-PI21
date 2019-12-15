using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlains
{
    public class HangarAlreadyHaveException : Exception
    {
        public HangarAlreadyHaveException() : base("На парковке уже есть такой самолет")
        { }
    }
}
