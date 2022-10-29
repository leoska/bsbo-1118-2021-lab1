using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBO_1118_2021_lab1
{
    internal class Item
    {
        public int value = 0;
        public Item next = null;

        public Item(int value, Item next)
        {
            this.value = value;
            this.next = next;
        }
    }

}
