using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상점_구현
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //질문
            //int asd = 10;
            //console(" "+ asd) , console(" ", asd) // ,는 몬가


            //int answer;
            //Console.WriteLine("         [상점 구현 프로그램]");
            //Console.WriteLine();
            //Console.WriteLine("   해당하는 숫자의 키를 누르시오");
            //Console.WriteLine();
            //Console.WriteLine("1. 장비창  2. 인벤토리  3. 상점  4.종료");
            ////answer = int.Parse(Console.ReadLine());

            ////Console.WriteLine("현재 장착중인 장비 : " + wepon.weponname);
            //Console.WriteLine("/////////////////////////////////////////");



            shop shop = new shop();
            item item1 = new item("무기1", 10, 5000);
            item item2 = new item("방어구1", 5, 2000);
            item item3 = new item("악세1", 2, 1000);
            
            inventory inventory = new inventory();

            //상점에 아이템 추가함
            shop.addshop(item1);
            shop.addshop(item2);
            shop.addshop(item3);

            Console.WriteLine();
            Console.WriteLine("상점에는 ");
            shop.showshop();
            Console.WriteLine();

            Console.WriteLine("내 소지돈 : "+inventory.totalmoney+ "원");


            //임의로 
            //나중에는 구입하면 추가하는걸로해야댈듯
            //인벤에 추가함
            inventory.add(item1);
            inventory.add(item2);
            inventory.add(item3);
            inventory.add(item1);
            inventory.add(item1);



            Console.WriteLine("인벤에");
            inventory.showinven();






        }
    }
}
