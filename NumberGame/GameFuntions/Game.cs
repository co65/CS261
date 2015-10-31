using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Game
    {
        
        public List<int> answer = new List<int>();
        List<int> boxAnswer = new List<int>();
        private Random rnd = new Random();
        int aCount = 0;
        int bCount = 0;
        //產生4個不重複的數字
        public List<int> GenerateNumber()
        {
            List<int> numbers = new List<int>();

            do
            {
                int number = rnd.Next(1, 10);
                if (!this.IsInAnswer(number, numbers))
                    numbers.Add(number);
            } while (numbers.Count < 4);
            return numbers;
        }

        //檢查數字有沒有重復
        private bool IsInAnswer(int number, List<int> numbers)
        {
            for (int index = 0; index < numbers.Count; index++)
            {
                if (number == numbers[index])
                {
                    return true;
                }
            }
            return false;
        }
        
        //傳入4個數字的答案,回傳幾 A 幾 B 的結果
        public string GetResult(List<int> userAnswer)
        {
            
            string result = "";
            for (int userAnswerIndex = 0; userAnswerIndex < 4; userAnswerIndex++)
            {
                for (int answerIndex = 0; answerIndex < 4; answerIndex++)
                {
                    if (userAnswer[userAnswerIndex] == this.answer[answerIndex])
                    {
                        if (userAnswerIndex == answerIndex)
                            aCount++;
                        else
                            bCount++;
                    }
                }
            }
        
            return result + string.Format("\n{0}A{1}B", aCount, bCount);
            
        }

        //將int的數字轉換為字串
        public string ConvertNumbersToString(List<int> numbers)
        {
            string result = "";
            for (int index = 0; index < numbers.Count; index++)
                result += numbers[index].ToString();

            return result;
        }

        //猜一次數字
        public string guestTheAnswer(string textOfBox)
        {
            boxAnswer.Clear();
            for (int index = 0; index <= 3; index++)
            {
                boxAnswer.Add(Convert.ToInt16(textOfBox.Substring(index, 1)));//將BOX的字串轉成List物件
            }
            return this.GetResult(boxAnswer);
         
        }
    }
}
