using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day19_과제
{
    internal class UsableItem
    {
        private string _name;
        private int _price;
        private int volum;
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Volum
        {
            get { return volum; }
            set { volum = value; }
        }


        public void IsKing()
        {
            Console.WriteLine("");
        }




    }
}
