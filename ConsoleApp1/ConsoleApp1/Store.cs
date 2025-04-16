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
        private List<Item> shopitems = new List<Item>();
        public Store()
        {
            Item Sword = new Item();
            Sword.SettingName("강철 검");
            Sword.type = Item.ItemType.Weapon;
            Sword.HasItem();
            Item armor = new Item();
            armor.SettingName("가죽 갑옷");
            armor.type = Item.ItemType.Armor;
            armor.HasItem();

            shopitems.Add(Sword);
            shopitems.Add(armor);

        }

        public void Update()
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine($"[보유골드] \n {player.GetPlayerGold()} G");
           
            Console.WriteLine();

            Console.Read(); //멈추기


        }

        public void PlayerIn(Player _player)
        {
            player = _player; //플레이어 입장


        }

        Player player;
        
    }
}
