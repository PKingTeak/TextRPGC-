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
            Console.WriteLine("아무키를 눌러주세요. 나가기");
            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        return;
                    default:
                        return;
                }


            }
           // Console.Read();//화면 멈추기
            
        }

        public void ShowPlayerState()
        {
           
            base.PrintState();
            //여기서 Item.Tick해서 이전으로 반복문으로 돌아가는 방식 
        }

       

        public void AddItem(Item _item)
        {

            StateUP(_item);
            State.Gold -= _item.GetGold(); //골드 차감
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

        
        
        List<Item> Items = new List<Item>(); //직접 착용하고 있는 아이템 
        Inventory inventory = new Inventory(); //인벤토리에 가지고 있는 아이템 
       
       
    }
}
