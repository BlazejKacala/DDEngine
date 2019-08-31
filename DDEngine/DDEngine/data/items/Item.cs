using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.items
{
    public abstract class Item
    {
        public string Name { set; get; }
        public string Description { set; get; }
        public float Weight { set; get; }
        public int Price { set; get; }

    }
}
