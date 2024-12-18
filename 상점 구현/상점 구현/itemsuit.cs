using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 상점_구현
{
    internal class item
    {
        public string name;
        public int power;
        public int price;
        public bool availsuit = false;//장착했나?


        public item(string name123, int power123, int price123)
        {
            this.name = name123;   
            this.power = power123;  
            this.price = price123;

        }
        public item()
        {
            

        }



    }

    class inventory : itemsuit
    {
        public int totalmoney = 85000;
        public List<item>items = new List<item>();
        public void add(item item1)
        {
            items.Add(item1);
        }
        
        

        public void showinven()
        {
            foreach (item ele in items)
            {
                Console.WriteLine(ele.name);
            }


        }


    }





    //이걸 생성하면 상자안에 item.availsuit이 true로 반환?
    internal class itemsuit
    {
        //장비창리스트만들고 인벤토리리스트를만들고 장비창=인벤토리이렇게 할당?
        //원하는거추가 인벤토리아이템제거
        //inventory inventory1 = new inventory();
        public List<item> items = new List<item>();
        List<itemsuit> itemsuits = new List<itemsuit>();//장비창 담는

        //List<List<item>> itemsuits1 = new List<List<item>>();


        //public bool[] availsuits = new bool[10];  //임시로 10개담는

        public void suitremove(item item1)
        {
            //장비창 = 인벤토리
            itemsuits1.Add(item1);
            items.Remove(item1);

        }

        public void showitemsuit()
        {
            foreach (var ele in itemsuits)
            {
                Console.WriteLine(ele);
            }
        }


    }
}
