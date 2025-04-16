using ConsoleApp1.Child;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class ItemDictionary
    
    {
        
        public static ItemDictionary Instance
        {//싱글톤
            get // 리턴해주는 느낌 
            {
                if (instance == null)
                {
                    instance = new ItemDictionary();
                }
                return instance;

                
            }
        
        
        }

        private void Init()
        {

            AllItem = new Dictionary<string, Item>();
        }
        private static Dictionary<string, Item> AllItem;
        private static ItemDictionary instance;


    }



}



