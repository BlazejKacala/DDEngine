using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data
{
    public enum Morality
    {
        Good,
        Neutral,
        Evil
    }

    public enum Order
    {
        Lawful,
        Neutral,
        Chaotic
    }
    public class Alignment
    {
        Morality Morality { get; set; }

        Order Order { get; set; }

        Alignment(Morality morality, Order order)
        {
            this.Morality = morality;
            this.Order = order;
        }

    }
}
