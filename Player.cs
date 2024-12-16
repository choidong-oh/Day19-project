using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_과제
{
    internal class Player
    {
        List<UsableItem> inventory = new List<UsableItem>();
        List<Weapon> weapons = new List<Weapon>();
        
        //유료결제여부
        bool cashpayment = false;//조건 아직 안맏늠
        public bool Cashpayment
        {
            get { return cashpayment; }
            set { cashpayment = value; }
        }

        //item 추가한다
        public void AddItem(UsableItem usableItem)
        {

            if (cashpayment == true)
            {
                inventory.Add(usableItem);
            }
            else if (cashpayment == false)
            {
                if (inventory.Count < 30)
                {
                    inventory.Add(usableItem);
                }
                else if (inventory.Count >= 30)
                {
                    Console.WriteLine("30초과 했습니다");
                }
            }
        }

        //무기 추가한다
        public void AddWeapon(Weapon weapon)
        {
            if (cashpayment == true)
            {
                weapons.Add(weapon);
            }
            else if (cashpayment == false)
            {
                if (weapons.Count < 30)
                {
                    weapons.Add(weapon);
                }
                else if (weapons.Count >= 30)
                {
                    Console.WriteLine("30초과 했습니다");
                }
            }
        }

        //보유중인 아이템 출력
        public void ShowInven()
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.Write(inventory[i].Name+ "\t");
                Console.Write(inventory[i].Price+ "\t");
                Console.Write(inventory[i].Volum+ "\t");
                Console.WriteLine();
            }
        }
        
        //보유중인 무기 출력
        public void ShowWeapon()
        {
            for (int i = 0; i < weapons.Count; i++)
            {
                Console.Write(weapons[i] + "\t");
            }
        }




        public void UseMyItem()
        {
            int answer;
            Console.WriteLine("무기 목록을 보려면 1번을");
            Console.WriteLine("사용 가능한 아이템 목록을 보려면 2번을 눌러주세요");
            answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                ShowInven();
            }
            else if (answer == 2)
            {
                ShowWeapon();
            }
        }

        
    }
}
