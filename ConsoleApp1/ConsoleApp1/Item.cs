using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    //
    public class Item //같은 어셈블리 어에서만 가능
    {

        public Item(int _dameage, int _amor , bool _isOwn, string _info)
        {
            
           data.SetItemData(_dameage);
         

        }

        
        public struct ItemData
        {
            //선언과 동시에 정했기 때문에 friend기능은 없을듯 하다. 

            private int damage;
            private int amor;
            private bool isOwn;
            private string info;

         


            public void SetItemData(int _damgae)
            {
                damage = _damgae;
            }
        }
        
         
        /// <summary>
        /// Unit으로 묶을꺼고 
        /// </summary>
        /// <param name="_Name"></param>

        public void SettingName(string _Name)
        {
            Name = _Name;
        }

       
        


        public ItemData data;
        public string Name { get; private set; } //이름

    }
}
