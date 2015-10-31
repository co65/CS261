using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace GameLibrary   
{
    public class AI
    {
        Game game1 = new Game();
        List<int> possibleNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        public int HowManyTimeToAnswer = 0;

        public string CreatAnswer(int aCount,int bCount)
        {
            List<int> numbers=new List<int>();
            if (HowManyTimeToAnswer == 0)//如果是第一次猜傳0A0B
            {
                numbers= game1.GenerateNumber();
                
            }

            return "d";
        }
        
    }
}
