using ConsoleApp1;
using System;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.InteropServices;

namespace TextRPG
{
  

    class RPGManager
    {
      

        static void Main(string[] args)
        {
            //여기가 이제 실행 단계 
            Player player = new Player();
       
            Console.WriteLine("이름을 입력해주세요 ");

            if (player == null)
            {
                return;
            }
            string name = Console.ReadLine();
            player.SetName(name);

            //본게임 시작
            Console.WriteLine("TEXT RPG게임 세계에 오신걸 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\r\n\r\n1. 상태 보기\r\n2. 인벤토리\r\n3. 상점");
            Console.WriteLine("원하시는 행동을 입력해주세요. \n >>");
            int Input = 0;
            //Test
            Item Testitem = new Item(10, 10, false, "참나무로 만들어진 검이다.");
            Testitem.SettingName("나무검");
            player.GetItem(Testitem);
            //

            do
            {
              
                Input = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (Input)
                {
                    case 1: //상태
                        player.ShowPlayerState();
                        break;
                    case 2://인벤토리
                        
                        player.ShowItemList();
                        break;
                    case 3://상점
                        break;
                    default: 
                        Console.WriteLine("잘못된 입력입니다. >>");
                        break;



                }
                Console.WriteLine("나가기 0");
                Console.WriteLine("원하시는 행동을 입력해주세요. \n >>");

            }
            while (Input != 0); //0은 무조건 나가기 버튼


            



            
           // Battle battle = new Battle();
           // battle.BattleStart();

           // Game game = new Game();
           // game.Update(); 이렇게 사용가능 
        }


      
    }

 
}

