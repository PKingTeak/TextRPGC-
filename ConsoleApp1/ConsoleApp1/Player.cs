using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player : Unit
    {
        public Player()
        {
            State.Hp = 100;
            State.Mp = 50;
            State.Damage = 10;
            State.Gold = 800;
        }


        public void ShowPlayerState()
        {
            Console.WriteLine($"이름 {this.UnitName} \n체력: {State.Hp}\n Mp: {State.Mp}\n공격력: {State.Damage}\nGold: {State.Gold}");

        }

        private double MaxExp = 100;//1레벨 경험치 통 100; 레벨을 곱해서 점점 늘어날 예정

       
    }
}
