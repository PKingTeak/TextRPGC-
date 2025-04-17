using ConsoleApp1.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class ItemDictionary

    {

        public static ItemDictionary Instance
        {//싱글톤
            get // 리턴해주는 느낌 
            {
                if (instance == null)
                {
                    instance = new ItemDictionary();
                    instance.Init(); //생성과 동시에 초기화가 이루어지고 이제 아이템이 필요할때 여기서 정보를 가져오는 방식이다. 
                }
                return instance;


            }



        }


        public Item FindItem(string _key)
        {
            if (AllItem.ContainsKey(_key))
            {
                return AllItem[_key];
            }
            else
            {
                return null; //그냥 null이 가능한가?

            }

        }

        public void ShowAllItem()
        {
            foreach (var pair in AllItem)
            {
                pair.Value.ShowItemInfo();

            }
        }
      

        public List<Item> GetAllItem()
        {
            List<Item> Names = new List<Item>();
            foreach (var pair in AllItem.Values)
            {
                Names.Add(pair);
            }

            return Names;
        }

        public List<Item> HasAllItem()
        { 
            List<Item> Items  = new List<Item>();
            foreach (var pair in AllItem.Values)
            {
                if (pair.equipment == true)
                {
                    Items.Add(pair);
                }
            }
            return Items;
        }
       

        public void GetItem(string _ItemName)
        {
            FindItem(_ItemName).HasItem();
        }

        private void Init()
        {
            Item Sword = new Item();
            Sword.Init(2, 0, 600, "단단한 검이다 무엇이든 벨수 있을꺼 같다");
            Sword.SettingName("낡은 검");
            Sword.type = Item.ItemType.Weapon;


            Item Sword2 = new Item();
            Sword2.Init(5, 0, 1500, "어디선가 사용됐던거 같은 도끼입니다.");
            Sword2.SettingName("청동 도끼");
            Sword2.type = Item.ItemType.Weapon;


            Item armor = new Item();
            armor.Init(0, 7, 200, "질긴 가죽으로 만들어졌다 악취가 조금 난다.");
            armor.SettingName("가죽 갑옷");
            armor.type = Item.ItemType.Armor;

            Item armor2 = new Item();
            armor2.Init(0, 9, 200, "무쇠로 만들어져 튼튼한 갑옷입니다.");
            armor2.SettingName("가죽 갑옷");
            armor2.type = Item.ItemType.Armor;



            AllItem.Add("낡은검", Sword);
            AllItem.Add("청동 도끼", Sword2);
            AllItem.Add("가죽 갑옷", armor);
            AllItem.Add("무쇠 갑옷", armor2);

        }
        public static Dictionary<string, Item> AllItem = new Dictionary<string, Item>();
        private static ItemDictionary instance;


    }



}



