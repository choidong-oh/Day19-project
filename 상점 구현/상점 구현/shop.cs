using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상점_구현
{
    internal class shop
    {
        public List<item>itemshop  = new List<item>();
        public void addshop(item item1)
        {
            itemshop.Add(item1);


        }

        public void showshop()
        {
            foreach (item ele in itemshop)
            {
                Console.WriteLine(ele.name+" : "+ ele.price+"원");

            }

        }

    }
}
