using DDEngine.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.engine
{
    public class Battlefield
    {
        float Width { get; set; }
        float Height { get; set; }
        List<Player> Party { get; set; }
        List<Player> Opponents { get; set; }
    }
}
