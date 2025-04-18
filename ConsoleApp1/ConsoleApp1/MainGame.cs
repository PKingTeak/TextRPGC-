using ConsoleApp1;
using ConsoleApp1.Child;
using System;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.InteropServices;
using static ConsoleApp1.Unit;

namespace TextRPG
{
  

    class RPGManager
    {


        static void Main(string[] args)
        {
            //여기가 이제 실행 단계 
            Player player = new Player();
            Store store = new Store();
            Inventory inventory = new Inventory();
            ItemDictionary itemDictionary = ItemDictionary.Instance;
            Dungun dungun = new Dungun();
            PlayerData savedata = new PlayerData();



            Console.WriteLine("이름을 입력해주세요 ");
            Console.WriteLine("저장된 데이터가 있으면 1번을 눌러주세요");
            

            if (player == null)
            {
             
                return;
            }
            string name = Console.ReadLine();
            if (name == "1")
            {
                savedata = SaveSystem.LoadSystem();
                player = savedata.ApplyData();
            }
            else 
            {
                player.SetName(name);
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("TEXT RPG게임 세계에 오신걸 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\r\n\r\n1. 상태 보기\r\n2. 인벤토리\r\n3. 상점\r\n4. 던전\r\n0. 저장");
                Console.WriteLine("원하시는 행동을 입력해주세요. \n >>");
                string Input = Console.ReadLine();
                switch (Input)
                {
                    case "0":
                        SaveSystem.SavePlayerData(player);
                        return;
                    case "1": //상태
                        player.Update();
                        break;
                    case "2"://인벤토리
                        inventory.Update();
                        break;
                    case "3"://상점
                        store.PlayerIn(player);
                        store.Update();
                        break;
                    case "4":
                        dungun.PlayerIn(player);
                        dungun.Update();
                        break;
                    default: 
                        Console.WriteLine("잘못된 입력입니다. >>");
                        break;



                }
                Console.WriteLine("나가기 0");
                Console.WriteLine("원하시는 행동을 입력해주세요. \n >>");

            }
           


            



            
           // Battle battle = new Battle();
           // battle.BattleStart();

           // Game game = new Game();
           // game.Update(); 이렇게 사용가능 
        }


      
    }

 
}

