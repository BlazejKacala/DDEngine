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
        public float Width { get; set; }
        public float Height { get; set; }
        public List<Player> Party { get; set; }
        public List<Player> Opponents { get; set; }

        public List<Character> PartyCharacters()
        {
            return Party.Select(x => x.Character).ToList();
        }
        public List<Character> OppositeCharacters()
        {
            return Party.Select(x => x.Character).ToList();
        }
    }
}
