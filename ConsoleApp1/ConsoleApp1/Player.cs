using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    
    internal class Player : Unit
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


        public void ShowPlayerState()
        {
            Console.WriteLine($"레벨: {State.Level}\n이름: {this.UnitName}\n체력: {State.Hp}\nMp: {State.Mp}\n공격력: {State.Damage}\n방어력: {State.defense}\nGold: {State.Gold}");

        }

        private double MaxExp = 100;//1레벨 경험치 통 100; 레벨을 곱해서 점점 늘어날 예정

        public void GetItem(Item _item)
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
                   // item.data.Testnum = 100;
                    Console.WriteLine($"아이템:{item.Name} \n|공격력+{item.data.Testnum}"); //여기 item.data.damage이렇게
                }
            }
        }
        
        List<Item> Items = new List<Item>(); 
       
    }
}
