using ConsoleApp1.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inventory
    {
        public Inventory()
        {

        }
        public void Update()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("[아이템 목록]");
                ShowInventory();
                Console.WriteLine("1. 장착관리 \n0. 나가기");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    return;
                }
                else if (input == "1")
                {
                    if (showNum == false)
                    {
                        Console.WriteLine("장착할 아이템 번호를 입력해 주세요");


                    }


                }

            }

        }

        public void AddItemToInv(Item _item)
        {
            if(Myinventory.ContainsKey(_item))
            {
                Myinventory[_item] +=1; //값증가

            }
            else
            {

            Myinventory.Add(_item, 1);
            }
        }

        private void ShowInventory()
        {
            foreach (var item in Myinventory.Keys)
            {

                if (showNum == true)
                {

                    Console.Write("G");
                    item.ShowItemInfo();

                }
                else
                {
                    item.ShowItemInfo();
                }

            }


        }

        private bool showNum = false;
        Dictionary<Item, int> Myinventory = new Dictionary<Item, int>();
    }
}
