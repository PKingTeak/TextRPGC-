using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Stage
    {

        //각각 클래스로 만들어서 상점, 던전, 장소들 플레이어 
        //클래스를 가지고 있고 싶어요
        //자료형[크기]
        //List로 담아서 사용
        //List<장소> choice;
        //C(부모)  a(아들), b(아들)
        //보통 리스트로 담지만 부모의 클래스를 담아서 자식들을 참조하는건 보기힘든구조다.. 
        //부모를 담는구조는 생소한 구조이다. 여러명이면 A나 B를 각자 담아서 사용 
        List<Unit> units = new List<Unit>(); //이렇게 하면 받을수 있다. 
        Player player = new Player();

        //몬스터가 수가 많으면 차라리 플레이어를 받지말고 몬스터를 받아서 통일해서 관리하자
        //같은구조에서 여러개를 사용하는것인데 부모는 같지만 Player는 하나만 쓸꺼면 왜담는지 ? 약간 불필요한거 같다. 
       // units.Add(player); //0번은 플레이어 고정시켜서 


        
    }
}
