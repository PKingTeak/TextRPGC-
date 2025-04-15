using ConsoleApp1.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Child.Item;

namespace ConsoleApp1
{
    public class Unit
    {
        public void SetName(string Name)
        {

            UnitName = Name;  //이름 셋팅
        }
        protected struct UnitState 
        {
           public int Hp;
           public int Mp;
           public int Damage;
           public int Level;
           public int defense;
           public int Gold;
            // public int MaxEXP;
            //경험치는 플레이어 만 있으면 될듯

        }

        protected virtual void LevelUP()
        {
            MaxExp = State.Level * 100;
        }
        
        public virtual void Update()
        {
            Console.Clear();
        }

        //프린트 함수를 만들어서 virtual
        //많이 쓰는
        public void PrintState()
        {
            Console.WriteLine($"레벨:{State.Level} \n이름:{UnitName} \n공격력:{State.Damage} \n방어력: {State.defense} \n체력: {State.Hp} \nGold: {State.Gold}");


        }

        public void AddItem(Item item)
        {
            switch (item.type)
            {
                case ItemType.Weapon:
                    {
                        this.State.Damage += item.State.Damage;
                        this.State.defense += item.State.defense;
                        this.State.Hp += item.State.Hp;

                    }
                    break;
                case ItemType.Armor:
                    {
                    }
                    break;

            }


        }


        public void Attack()
        { 
        
        }

        protected int MaxExp = 100;
        protected string UnitName = "";
        protected UnitState State;
    }
}
