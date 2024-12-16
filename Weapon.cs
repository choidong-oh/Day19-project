using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day19_과제
{
    internal class Weapon
    {
        private string WeaponName;
        private int WeaponPower;

        public string weaponName
        {
            get { return WeaponName; }
            set { WeaponName = value; }
        }

        public int weaponPower
        {
            get { return WeaponPower; }
            set { WeaponPower = value; }
        }

        public void IsKing()
        {
            Console.WriteLine("무기가 왕인가?");
        }




    }
}
