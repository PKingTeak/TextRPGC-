using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Unit
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
        protected string UnitName = "";
        protected UnitState State;
    }
}
