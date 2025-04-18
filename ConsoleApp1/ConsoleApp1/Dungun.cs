using ConsoleApp1.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    public class Dungun
    {
        public Dungun()
        {
            
            
        }



        public void Update()
        {
            //전투 시뮬레이션 
            while (true)
            {
              
                Console.WriteLine("===== 난이도를 선택해주세요 =====\n");
                Console.WriteLine("===== 1.고블린(매우쉬움) \t2.오크(중간) \t3.대왕슬라임(매우 어려움) \t4.???(못깰껄?) =====");
                Console.WriteLine("0번 나가기");
                player.ResetHP();
                string Input = Console.ReadLine();
                
                switch (Input)
                {
                    case "0":
                        return;
                    case "1":
                        {
                            dungunlevel = 0;
                        }
                        break;
                    case "2":
                        {
                            dungunlevel = 1;
                        }
                        break;
                    case "3":
                        {
                            dungunlevel = 2;
                        }
                        break;
                    case "4":
                        {
                            dungunlevel = 3;
                        }
                        break;

                }
                Battle();
                Console.Clear();
            }
            
        }


        private void Battle()
        {
            Monster CurMonster = monster[dungunlevel];
            while (player.GetHP() >= 0)
            {
                Console.Clear(); // 매 턴 화면 정리 

                Console.WriteLine("===== 전투 상태 =====");
                Console.WriteLine($"[플레이어] HP: {player.GetHP()}  |  [몬스터] HP: {CurMonster.GetHP()}"); //레벨 난이도 정할꺼임
                Console.WriteLine("===========================");

                Console.WriteLine("\n 플레이어의 턴!");
                Console.WriteLine("1. 일반 공격");
                Console.WriteLine("2. 스킬 공격 (2배 데미지)");

                Console.Write("선택 >> ");
                string input = Console.ReadLine();



                if (input == "2")
                {
                    player.UseSkill(CurMonster);


                }
                else
                {
                    player.Attack(CurMonster);
                }
                            

                if (CurMonster.GetHP() <=0)
                {
                    Console.WriteLine("\n몬스터를 처치했습니다!");
                    player.TakeGold(CurMonster.GetGold());
                    Console.WriteLine("\n결과창 넘기기 [Enter]");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("\n 몬스터의 반격!");
                CurMonster.Attack(player);

                if (player.GetHP()<=0)
                {
                    Console.WriteLine("\n플레이어가 쓰러졌습니다...");
                    break;
                }

                Console.WriteLine("\n[Enter]를 눌러 다음 턴으로 진행하세요...");
                Console.ReadLine();
            }


            Console.WriteLine("=== 전투 종료 ===");
        }


        public void PlayerIn(Player _player)
        {
            player = _player;
        }

        private Player player;
        private int dungunlevel = 0;
        private List<Monster> monster = new List<Monster>()
        {
            new Monster("고블린", 1),
            new Monster("오크", 2),
            new Monster("대왕슬라임", 3),
            new Monster("박경택",4)
        };



    }

}
