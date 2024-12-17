using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_과제
{
    internal class Gun
    {
        List<Bullet> bullets;
        List<Grenade> grenades;
        Dictionary<string, Projectile> Item;

        Projectile projectile = new Bullet();
        Projectile projectile1 = new Grenade();

        public Gun()
        {
            bullets = new List<Bullet>();
            grenades = new List<Grenade>();
            Item = new Dictionary<string, Projectile>();


            Item.Add("Bullet", projectile);
            Item.Add("Grenade", projectile1);
        }




        //dic.Add(100,100)
        //dic[100] 찾음

        //질문 반환하면 어따씀?? 
        public Projectile Show(string answer)
        {
            if (answer == "Bullet")
            {
                Console.WriteLine("Bullet 반환됌");
                return projectile;
            }
            if (answer == "Grenade")
            {
                Console.WriteLine("Grenade 반환됌");
                return projectile1;
            }


            return projectile1;
        }




    }
}
