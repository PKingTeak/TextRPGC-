using ConsoleApp1.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
//왜 처음에는 오류가 뜨는걸까??
//비쥬얼 스튜디오 내부에서 기본적인것들은 바로 using이 되지만
//좀더 무거운 라이브러리들은 패키지 필요할때마다 다운받아서 사용
//회색은 쓴다고 선언하고 안쓴거다. 
//Install-Package Newtonsoft.Json 해줘야 패키지가 된다. 
//도구 - 패키지 관리자 - 패키지관리자 콘솔 - 하고 명령어를 치게 되면 된다. 

namespace ConsoleApp1
{
    public class Store //내부에서는 수정이가능하고 외부에서는 읽기만 가능하게 같은 프로젝트끼리만 접근이 가능하게 하는것
    {
        public Store()
        {

            shopitems = ItemDictionary.Instance.GetAllItem();



        }
        private void Init()
        {
            Item ShopItem = new Item();


        }
        public void Update()
        {
            
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("상점");
                    Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                    Console.WriteLine();
                    Console.WriteLine($"[보유골드] \n {player.GetGold()} G");
                    ItemDictionary.Instance.ShowAllItem();

                    

                    Console.WriteLine("나가기 0");
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    { 
                        //이러면 이 값이 문자열이 NULL이 아닐때만 호출해주는것이다. 
                    }


                    if (int.TryParse(input, out int result))  
                    { 
                        
                    
                    int itemindex = result - 1; //근데 문자가 아닐 경우 그냥 리턴할꺼임 //질문 이거 이상한값 들어오면 터짐 질문

                    if (input == "0")
                    {
                        return;
                    }

                    if (itemindex < shopitems.Count && player.GetGold() >= shopitems[itemindex].GetGold())
                    {

                        if (shopitems[itemindex].equipment == true)
                        {
                            Console.WriteLine("이미 구매한 아이템 입니다.");
                            continue;
                        }
                        player.AddItem(shopitems[itemindex]); // 돈이 가격만큼 있다면 구매가능 하지만 없으면 구매 불가능
                        shopitems[itemindex].HasItem();
                        


                    }
                    else if (itemindex < shopitems.Count && player.GetGold() < shopitems[itemindex].GetGold())
                    {

                        Console.WriteLine("구매가 불가능합니다.");
                    }
                    else
                    {
                        Console.WriteLine("잘못된 값을 입력하였습니다.");
                    }

                    }
                    //멈추기


                }

            }
        }

       
        public void PlayerIn(Player _player)
        {
            player = _player; //플레이어 입장


        }


        //아이템을 구매하면 string타입으로 아이템을 반환하여 인벤토리에게 알려줄것이다. 
        //그리고 인벤토리에서 아이템 정보를 가지고 찾아주는 기능을 구현할 것임.

        Player player;
        private List<Item> shopitems = new List<Item>();

    }
}



/*
아이템 리스트를 순회하면서 모든 아이템의 showItemInfo메서드를 실행 시킬예정 

정식튜터님이 string으로 인벤토리에게 넘겨주고 관리하는 방식이 일반적이라고 하셨음 
일단 실험하고 그럼 인벤토리에서 관리하는 방식으로 옮길듯



*/

