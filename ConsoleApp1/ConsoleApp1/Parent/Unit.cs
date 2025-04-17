using ConsoleApp1.Child;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

        public void Init(string _job, int _hp , int _mp , int _damage, int _level , int _defense , int _gold)
        {
                State.Job = _job;
                State.Hp = _hp;
                State.Mp = _mp;
                State.Damage = _damage;
                State.Level = _level;
                State.defense = _defense;
                State.Gold = _gold;


        }

        public void Init(int _damage =0 ,int _defense =0,int _gold =0, string _info ="정보 없음")
        {
            State.Damage = _damage;
            State.defense = _defense;
            State.Gold = _gold;
            State.Info = _info; //정보 셋팅 완료 
        }   
        protected struct UnitState 
        {

           public string Job;
           public int Hp;
           public int Mp;
           public int Damage;
           public int Level;
           public int defense;
           public int Gold;

           public string Info;
            // public int MaxEXP;
            //경험치는 플레이어 만 있으면 될듯

        }

        protected virtual void LevelUP()
        {
            MaxExp = State.Level * 100;
        }

        public int GetGold()
        {
            return State.Gold;

        }
        
        public virtual void Update()
        {
            Console.Clear();
        }

        //프린트 함수를 만들어서 virtual
        //많이 쓰는
        public void PrintState()
        {
            Console.WriteLine($"직업:{State.Job} \n레벨:{State.Level} \n이름:{UnitName} \n공격력:{State.Damage} \n방어력: {State.defense} \n체력: {State.Hp} \nGold: {State.Gold}");


        }

        public void StateUP(Item item)
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
                        this.State.Damage += item.State.Damage;
                        this.State.defense += item.State.defense;
                        this.State.Hp += item.State.Hp;
                        
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
