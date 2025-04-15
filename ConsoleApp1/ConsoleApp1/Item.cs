using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    
    internal class Item
    {

        public Item(int _dameage, int _amor, bool _isOwn, string _info)
        {
            
           // data.Testnum = _dameage;
           // data.amor = _amor;
           // data.isOwn = _isOwn;
           // data.info = _info;
        }
        public struct ItemData
        {
            //선언과 동시에 정했기 때문에 friend기능은 없을듯 하다. 

            private int damage;
            public int amor
            {
                get { return damage; }
                private set { damage = value; }
            }
            private bool isOwn;
            private string info;

            public int Testnum
            {
                get { return damage; }
               private set { Testnum = value; }

            } //프로퍼티

        }
        
         


        public void SettingName(string _Name)
        {
            Name = _Name;
        }

        


        public ItemData data;
        public string Name { get; private set; } //이름

    }
}
