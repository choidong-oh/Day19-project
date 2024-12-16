using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_과제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //??이거왜함?
            //?? 이거왜함 최종
            //2번??
            //이거 결과값??이 왜이렇게 나오나
            //카드덱
            //1리스트로 쓸지 스택으로 쓸지 고르라는건가?
            //2아니면 둘다 쓸수있는건가?*****************

            //대충 list는 배열, dictionary는 찾는거, 


            //1번 배열
            //Player player = new Player();
            //Weapon weapon = new Weapon();
            //UsableItem[] item = new UsableItem[3];

            //이거왜함???
            //item[0] = new UsableItem();
            //item[1] = new UsableItem();
            //item[2] = new UsableItem();

            //item[0].Name = "총";
            //item[0].Price = 5;
            //item[0].Volum = 100;

            //item[1].Name = "권총";
            //item[1].Price = 2;
            //item[1].Volum = 100;

            //item[2].Name = "칼";
            //item[2].Price = 1;
            //item[2].Volum = 100;

            //player.AddItem(item[0]);
            //player.AddItem(item[1]);
            //player.AddItem(item[2]);
            //player.ShowInven();

            //2번 list

            Player player = new Player();
            UsableItem item = new UsableItem(); //애를 써야댐? 리스트에서 할당 한거인가?
            List<UsableItem> inventory = new List<UsableItem>();


            //이거 결과값?? 이 왜이렇게 나오나
            item.Name = "총";
            inventory.Add(item);
            item.Name = "권총";
            inventory.Add(item);
            item.Name = "칼";
            inventory.Add(item);

            Console.WriteLine(inventory[0].Name);
            Console.WriteLine(inventory[1].Name);
            Console.WriteLine(inventory[2].Name);


            //??이거왜함 최종// 똑같은걸 할당한거 또 해야대는지
            //Enemy tempEnemy = new Enemy();
            //tempEnemy.Name = "garon";
            //myEnum.Add(tempEnemy);

            //tempEnemy = new Enemy();
            //tempEnemy.Name = "Kronya";
            //myEnum.Add(tempEnemy);



            //카드셔플
            Card card = new Card();
            Shape shape = new Shape();

            CardDeck carddeck = new CardDeck(card,shape);
            
            carddeck.ShowTopCard();//사용하지 않는 맨위카드
            carddeck.DrawCard();//사용한걸 빼서 담아둠


            int count = 1;//가독성
            //사용하지않는거출력
            foreach (var ele in carddeck.unusedCards)
            {
                
                Console.Write("count : "+count+" ");
                Console.Write(ele.CardNum);
                Console.WriteLine(ele.Shapes);
                count++;
            }
            Console.WriteLine("======================================");
            //사용한거 출력
            foreach (var ele in carddeck.usedCards)
            {
                Console.Write(ele.CardNum);
                Console.WriteLine(ele.Shapes);
            }







        }
    }
}
