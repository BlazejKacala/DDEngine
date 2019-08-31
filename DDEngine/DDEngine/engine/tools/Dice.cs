using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.engine
{
    public class Dice : IDice
    {

        private int dice;
        private readonly Random random;

        public int D { get => dice; set => this.dice = value; }

        public Dice(int sides)
        {
            D = sides;
            random = new Random();
        }

        public int Roll()
        {
            return random.Next(D - 1) + 1;
        }
    }
}
