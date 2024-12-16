using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_과제
{
    internal class CardDeck
    {
        //리스트,배열로 52개의 크기를 만들고
        //디션널리로 1~13의 a,j,q,k를 찾을수있게하고
        //52개 랜덤으로 돌리고
        //스택으로 본다
        //그리고 그걸 넣는다
     
        //리스트로 쓸지 스택으로 쓸지 고르라는건가??
        //아니면 둘다 쓸수있는건가?*****************

        //사용한거랑 사용안한거로 52장 들어가는 구조
        public List<Card> usedCards = new List<Card>(52);
        public List<Card> unusedCards = new List<Card>(52);

        Random Randomshuffle = new Random();
        int RandomTemp1;//인덱스에 들어가 바꾸는 일회용
        int RandomTemp2;//인덱스에 들어가 바꾸는 일회용
        int temp;//교환값 일회용


        //52개의 카드를 중복 없이 넣어라
        public CardDeck(Card card,Shape shape)
        {

            for (int j = 1; j <= 4; j++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    card = new Card();

                    card.CardNum = i;//1~13
                    card.Shapes = (Shape)j;//1~4 이넘
                    unusedCards.Add(card);
                    //unusedCards.Add(new Card { CardNum = i });
                }
               
            }

            shuffle();

        }

        //Console.WriteLine(carddeck.usedCards[51].CardNum);

        //52개의 카드 랜덤
        public void shuffle()
        {
            //ㅋㅋ
            //2개 인덱스 값을 랜덤으로 돌리고
            //랜덤으로 나온 두 수를 인덱스를 넣어
            //2개의 값을 바꿈
            //이걸500번 돌림
            for (int i = 0; i < 500; i++)
            {

                RandomTemp1 = Randomshuffle.Next(0, 52);
                RandomTemp2 = Randomshuffle.Next(0, 52);
                //카드넘버 변경
                temp = unusedCards[RandomTemp1].CardNum;
                unusedCards[RandomTemp1].CardNum = unusedCards[RandomTemp2].CardNum;
                unusedCards[RandomTemp2].CardNum = temp;
                //카드문양
                temp = (int)unusedCards[RandomTemp1].Shapes;
                unusedCards[RandomTemp1].Shapes = unusedCards[RandomTemp2].Shapes;
                unusedCards[RandomTemp2].Shapes = (Shape)temp;

            }
        }

        //맨위카드만 보임// 보이기만함
        public void ShowTopCard()
        {
            //list 사용시
            Console.Write("맨위카드는 : ");
            Console.Write(unusedCards[unusedCards.Count - 1].CardNum + " ");
            Console.WriteLine(unusedCards[51].Shapes);//unusedCards.Count - 1 ==51

        }

        //카드를 쌓는다 맨위카드를 usedcard로 넣음
        public void DrawCard()
        {
            usedCards.Add(unusedCards[51]);
            unusedCards.RemoveAt(unusedCards.Count-1);
        }
    }

}
