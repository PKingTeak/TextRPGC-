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

    

        private void ShowInventory()
        {
            Myinventory = ItemDictionary.Instance.HasAllItem(); 
            foreach (var item in Myinventory)
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

        public List<Item> GetPlayerItems()
        {
            return Myinventory;
        }

        private bool showNum = false;
        List<Item> Myinventory = new List<Item>();
        //아이템 이름으로 찾는 경우가 많기 때문에 
        //value값에 따라 아이템을 
        //키값이 아이템 int 값인데 
        //키를이름으로 하고 아이템을 값으로 하는게 좋은구조이다. 
        //Key string value item으로 변경하기 
    }
}
