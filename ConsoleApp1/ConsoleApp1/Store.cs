using ConsoleApp1.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        
    }
}
