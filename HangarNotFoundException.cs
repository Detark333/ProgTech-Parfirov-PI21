using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlains
{
    class HangarNotFoundException : Exception
    {
        public HangarNotFoundException(int i) : base("Не найден самолет по месту " + i)
        { }
    }
}
