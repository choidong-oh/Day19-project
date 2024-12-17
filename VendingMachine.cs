using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_과제
{
    internal class VendingMachine
    {
        //우유 집어넣는 메소드
        //우유 꺼내는 메소드 // 유통기한 몇 큐 남아있는 개수
        //우유가 없을때? 의미

        //en이추가 d어저쩌구가 빼기
        Queue<Milk> totalmilk = new Queue<Milk>();


        //빼다
        public void DequeueMilk( )
        {

            if(totalmilk.Count == 0)
            {
                Console.WriteLine("다 팔렸음");
            }
            else
            {
                
                Milk temp = totalmilk.Dequeue();


                Console.WriteLine("우유 유통기한은 : " + temp.shelfLife);
                Console.Write("큐에 남아있는 갯수 : ");
                Console.WriteLine(totalmilk.Count);

            }
            
            
            
            

            




        }

        //추가하다
        public void addMilk(Milk milk)
        {
            
            totalmilk.Enqueue(milk);



        }













    }
}
