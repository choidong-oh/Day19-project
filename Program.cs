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
            //카드덱
            //1리스트로 쓸지 스택으로 쓸지 고르라는건가?
            //2아니면 둘다 쓸수있는건가?*****************

            //의문??
            //대충 list는 배열, dictionary는 찾는거, 


            //1번 배열
            //Player player = new Player();
            //Weapon weapon = new Weapon();
            //UsableItem[] item = new UsableItem[3];

            //이거왜함???
            //넣는걸 할당안햇음
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

            //Player player = new Player();
            //UsableItem item = new UsableItem(); //애를 써야댐? 리스트에서 할당 한거인가?
            //List<UsableItem> inventory = new List<UsableItem>();


            ////이거 결과값?? 이 왜이렇게 나오나
            //item.Name = "총";
            //inventory.Add(item);
            //item.Name = "권총";
            //inventory.Add(item);
            //item.Name = "칼";
            //inventory.Add(item);

            //Console.WriteLine(inventory[0].Name);
            //Console.WriteLine(inventory[1].Name);
            //Console.WriteLine(inventory[2].Name);


            //??이거왜함 최종// 똑같은걸 할당한거 또 해야대는지
            //Enemy tempEnemy = new Enemy();
            //tempEnemy.Name = "garon";
            //myEnum.Add(tempEnemy);

            //tempEnemy = new Enemy();
            //tempEnemy.Name = "Kronya";
            //myEnum.Add(tempEnemy);



            //카드셔플
            //디셔널리 안넣엇음
            //근데 굳이 쓸필요가 잇나? 11이면 j, 12면 q 이런식으로 if문 만들면 돼지안나?
            //Card card = new Card();
            //Shape shape = new Shape();


            //CardDeck carddeck = new CardDeck(card, shape);

            //carddeck.ShowTopCard();//사용하지 않는 맨위카드
            //carddeck.DrawCard();//사용한걸 빼서 담아둠

            ////if (carddeck.unusedCards[5].CardNum == 11)
            ////{
            ////    carddeck.unusedCards[5].CardNum = (int)jqk.j;
            ////}

            ////사용하지 않는거 출력
            //for (int i = 0; i < carddeck.unusedCards.Count; i++)
            //{
            //    Console.Write($"count : {i + 1} \t");
            //    if (carddeck.unusedCards[i].CardNum == 11)
            //    {
            //        Console.Write("J\t");
            //    }
            //    else if(carddeck.unusedCards[i].CardNum == 12)
            //    {
            //        Console.Write("Q\t");
            //    }
            //    else if (carddeck.unusedCards[i].CardNum == 13)
            //    {
            //        Console.Write("K\t");
            //    }
            //    else
            //    {
            //        Console.Write(carddeck.unusedCards[i].CardNum + "\t");
            //    }
            //    Console.WriteLine(carddeck.unusedCards[i].Shapes);

            //}

            //Console.WriteLine("===================================");
            ////사용한거 출력
            //for (int i = 0; i < carddeck.usedCards.Count; i++)
            //{
            //    Console.Write($"count : {i + 1} ");
            //    Console.Write(carddeck.usedCards[i].CardNum);
            //    Console.WriteLine(carddeck.usedCards[i].Shapes);
            //}


            VendingMachine vendingMachine = new VendingMachine();
           

            vendingMachine.addMilk(new Milk() { shelfLife = 12});
            vendingMachine.addMilk(new Milk() { shelfLife = 5});
            vendingMachine.addMilk(new Milk() { shelfLife = 7});
            vendingMachine.addMilk(new Milk() { shelfLife = 8});
            

            vendingMachine.DequeueMilk();
            vendingMachine.DequeueMilk();
            vendingMachine.DequeueMilk();
            vendingMachine.DequeueMilk();
            








        }







    }
    }

