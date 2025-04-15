using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GameManager
    {
        static GameManager instance;

        GameManager()
        {
            if (instance == null)
            { 
                GameManager.instance = new GameManager();
            }
        }

        /*
         * 
        public static string Choice(string _Input)
        {
            return _Input;
        }
         */
         //에러가 생겼을때 협업에서 
      
        //저장이나 설정같이 전체적으로 게임내에서 도와주는 역할을 함. 
    }
}
