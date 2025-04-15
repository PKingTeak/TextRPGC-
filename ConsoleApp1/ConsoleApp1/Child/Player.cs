using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp1;

namespace ConsoleApp1.Child
{
    
    public class Player : Unit
    {
        public Player()
        {
            State.Hp = 100;
            State.Mp = 50;
            State.Damage = 10;
            State.Gold = 800;
            State.Level = 1;
            State.defense = 5;
        }

        public override void Update() //컴파일러 가일부러 막았음 접근제한자 통일해야해 왜냐?? 부모 틱도 돌리니까
        {
            base.Update(); //이게 super 부모 함수 가져와서 사용
            ShowPlayerState();
          
            Console.Read();//화면 멈추기
            
        }

        public void ShowPlayerState()
        {
           
            base.PrintState();
          
            Console.WriteLine("0. 나가기");
            while (true)
            {
              string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        return;
                    default:
                        break;
                }
              
               
            }
            //여기서 Item.Tick해서 이전으로 반복문으로 돌아가는 방식 
        }

        

        public void AddItem(Item _item)
        {
            Items.Add(_item); //아이템 추가
            
        }
        public void ShowItemList()
        {
            Console.WriteLine("[아이템 목록]");
            foreach (Item item in Items)
            {
                if (!Items.Any())
                {
                    Console.WriteLine("아이템이 없습니다.");
                    return;
                }
                else 
                {
                   
                   Console.WriteLine($"아이템:{item.Name} \n|공격력"); //여기 item.data.damage이렇게
                }
            }
        }
        
        List<Item> Items = new List<Item>();

       // ItemData item;
       
    }
}
