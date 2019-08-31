using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.engine
{
    public interface IDice
    {
        int D { get; set; }

        int Roll();
    }
}
