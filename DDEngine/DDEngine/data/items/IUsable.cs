using DDEngine.data.proficiencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.items
{
    public interface IUsable
    {
        List<Proficiency> Requirements { get; }
    }
}
