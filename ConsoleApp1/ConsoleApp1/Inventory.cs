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
            //Myinventory.Add( 10); //바로 넣을때 생성하면서 값을 넣어주는 방식을 자주 사용한다. 
            if(Myinventory.ContainsKey(_item))
            {
                Myinventory[_item] +=1; //값증가

            }
            else
            {

            Myinventory.Add(_item, 1);
            }
            //딕셔너리를 넣을때 다른 방식을 사용해서 넣어야한다. 
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
        //아이템 이름으로 찾는 경우가 많기 때문에 
        //value값에 따라 아이템을 
        //키값이 아이템 int 값인데 
        //키를이름으로 하고 아이템을 값으로 하는게 좋은구조이다. 
        //Key string value item으로 변경하기 
    }
}
