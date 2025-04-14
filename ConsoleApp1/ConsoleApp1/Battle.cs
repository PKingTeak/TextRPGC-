using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Battle
    {
        public bool BattleStart()
        {
            string[] Choice = { "가위", "바위", "보" };
            string PlayerInput = "";
            string ComputerInput = " ";
            while (PlayerInput != ComputerInput)
            {
                ComputerInput = Choice[new Random().Next(0, 3)];
                Console.WriteLine("가위바위보!");
                PlayerInput = Console.ReadLine();
                if (PlayerInput == ComputerInput)
                {
                    Console.WriteLine("비겼습니다.");
                }
                else if ((PlayerInput == "가위" && ComputerInput == "보") ||
                (PlayerInput == "바위" && ComputerInput == "가위") ||
                (PlayerInput == "보" && ComputerInput == "바위"))
                {
                    Console.WriteLine("플레이어 승리!");
                }
                else
                {
                    Console.WriteLine("컴퓨터 승리!");
                }
            }
            return false;
        }
    }
}

        