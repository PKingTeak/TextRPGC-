using ConsoleApp1;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1.Child
{
    
    public class Item : Unit
    {

        public enum ItemType
        {
            Weapon = 0,
            Armor = 1,

            //추가
        }

        

        /// <summary>
        /// Unit으로 묶을꺼고 
        /// </summary>
        /// <param name="_Name"></param>

        public void SettingName(string _Name)
        {
            Name = _Name;
        }

        public void HasItem() 
        {
            equipment = true;
        }

        public void NoItem() 
        {
            equipment = false; 
        }

        public void ShowItemInfo()
        {
            switch(this.type)
            {
                case ItemType.Weapon :
                {
                if(this.equipment == true)
                {
                Console.WriteLine($"-{this.Name} \t| 공격력 +{this.State.Damage} \t| {this.State.Info}\t| [구매완료]");
                }
                else
                {
                Console.WriteLine($"-{this.Name} \t| 공격력 +{this.State.Damage} \t| {this.State.Info}\t| {this.State.Gold}G");
                }

                break;
                }

                case ItemType.Armor:
                {
                if(this.equipment == true)
                {
                    Console.WriteLine($"-{this.Name}\t| 방어력 +{this.State.defense}\t| {this.State.Info}\t| [구매완료]");
                }
                else
                {
                Console.WriteLine($"-{this.Name}\t| 방어력 +{this.State.defense}\t| {this.State.Info}\t| {this.State.Gold}G");

                }

                }
                break;
                default:
                Console.WriteLine("없는 정보입니다.");
                return;

            }


        }

        public bool equipment = false;
        public ItemType type;
        public string Name { get; private set; } //이름

    }
}
