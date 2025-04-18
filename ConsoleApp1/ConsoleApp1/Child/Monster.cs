using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Child
{
    internal class Monster : Unit
    {
        public Monster(string _Name,int _level) 
        {
            Init(_Name, 100, 0, 10, 1, 0, 100 , _level);
            this.State.Level = _level;  //이러면 됨
            LevelUP();
        }


        

    }
}
