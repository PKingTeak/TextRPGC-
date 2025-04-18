using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Child;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ConsoleApp1
{


    [Serializable]
    public class PlayerData
    {
        public string Name { get; set; }
        public int MaxHp { get; set; }
        public int Mp { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
        public int Defense { get; set; }
        public int Gold { get; set; }
        public int Luck { get; set; }

        public List<string> UserItemID { get; set; } = new List<string>();

        public void MoveToData(Player _player)
        {
            Name = _player.GetName();
            MaxHp = _player.PlayerGetMaxHp();
            Mp = _player.PlayerGetMp();
            Damage = _player.PlayerGetDamage();
            Level = _player.PlayerGetLevel();
            Defense = _player.PlayerGetDefense();
            Gold = _player.PlayerGetGold();
            Luck = _player.PlayerGetLuck();

            //아이템은 나중에 해보자..
        }
        public Player ApplyData()
        {
          Player player = new Player(Name,MaxHp,Damage,Level, Defense, Gold ,Luck);

           return player;

        }

    };
    internal class SaveSystem
    {
        private static string SavePath = "Player_Save.json";

        //기본으로 저장하는 방식이 존재하기 때문에 
        //경로는 내부적으로 알아서 처리해 준다. 
        //지금은 로컬로만 하기 때문에 Json 을 사용 
        //나중에 -> 서버가 있기 때문에 서버에 데이터를 올리고 그 제공하는 함수를 받아서 사용하여 경로를 지정해주는 것이다. 
        //

        public static void SavePlayerData(Player _player)
        {
            PlayerData data = new PlayerData(); //내부에서 만들어
            data.MoveToData(_player);

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(SavePath, json);
            Console.WriteLine("저장완료");
           //파일 관련된에들은 경로에 대한 정보가 보통 없다. 
        }

        public static PlayerData LoadSystem()
        {
            if (!File.Exists(SavePath))
            {
                Console.WriteLine("저장된 파일이 없습니다");
                return null;
            }

            string json = File.ReadAllText(SavePath);
            PlayerData data = JsonConvert.DeserializeObject<PlayerData>(json);
            
            Console.WriteLine("플레이어 데이터 불러오기");
            return data;

        }
       

        //클래스를 -> Text(Json.file) ->파일저장 ->TEXt->클래스로 가져오는 느낌.

       
    }
    //직렬화 하는 이유는 클래스를 그냥 저장하는건 불가능해서 문서화 해서 하기위해서 [Serializable]로 명시해주는것
    /*
     * 제이슨이라는 거에 저장을 하는데 JsonConvert 제이슨 파일로 변경함 근데 이때 직렬화를 해서 함수를 사용하는 걸 사용하는데 
     * 플레이어가 없는 상태에서는 객체가 없기때문에 직접 만들어주고 세이브 하는 방식. 
     * 필요한게 경로 + 저장할 데이터인데 
     * 
     */
}
