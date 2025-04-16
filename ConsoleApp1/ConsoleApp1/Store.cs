using ConsoleApp1.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Store //내부에서는 수정이가능하고 외부에서는 읽기만 가능하게 같은 프로젝트끼리만 접근이 가능하게 하는것
    {
        public Store()
        {
            Item Sword = new Item();
            Sword.Init(5,0,500,"단단한 검이다 무엇이든 벨수 있을꺼 같다");
            Sword.SettingName("강철 검");
            Sword.type = Item.ItemType.Weapon;
            
            Item armor = new Item();
            armor.Init(0,7,200,"질긴 가죽으로 만들어졌다 악취가 조금 난다.");
            armor.SettingName("가죽 갑옷");
            armor.type = Item.ItemType.Armor;
            
            shopitems.Add(Sword);
            shopitems.Add(armor);

        }
        private void Init()
        {
            Item ShopItem = new Item();
            

        }
        public void Update()
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine($"[보유골드] \n {player.GetPlayerGold()} G");
           
            showShopList();

            Console.Read(); //멈추기


        }

        private void showShopList()
        {
            Console.WriteLine("[아이템 목록]");
            foreach(Item item in shopitems)
            {
                item.ShowItemInfo();


            }


        }
        public void PlayerIn(Player _player)
        {
            player = _player; //플레이어 입장


        }


        //아이템을 구매하면 string타입으로 아이템을 반환하여 인벤토리에게 알려줄것이다. 
        //그리고 인벤토리에서 아이템 정보를 가지고 찾아주는 기능을 구현할 것임.

        Player player;
        private List<Item> shopitems = new List<Item>();
        
    }
}



/*
아이템 리스트를 순회하면서 모든 아이템의 showItemInfo메서드를 실행 시킬예정 

정식튜터님이 string으로 인벤토리에게 넘겨주고 관리하는 방식이 일반적이라고 하셨음 
일단 실험하고 그럼 인벤토리에서 관리하는 방식으로 옮길듯



*/

