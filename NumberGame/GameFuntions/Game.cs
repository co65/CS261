using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Game
    {
        public int guestTimes = 0;
        public List<int> alearlyGuestNumber = new List<int>();
        //List<int> firstGuestUserAnswer = new List<int>();
        
        public List<int> possibleNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        public List<int> impossibleNumber = new List<int>();

        public List<int> answer = new List<int>();
        public List<int> userAnswer = new List<int>();
        private Random rnd = new Random();

        public List<int> aCountHistory = new List<int>();
        public List<int> bCountHistory = new List<int>();

        public int aCount = 0;
        public int bCount = 0;
        //int HowManyTimeToAnswer = 0;

        //產生4個不重複的亂數
        public List<int> GenerateNumber(){
            List<int> numbers = new List<int>();
            do{
                int number = rnd.Next(1, 10);               //產生1~10其中一個亂數
                if (!this.IsInAnswer(number, numbers))      //檢查這數字沒有在答案裡的話
                    numbers.Add(number);                    //把亂數加到答案裡
            } while (numbers.Count < 4);                    //做4次
            return numbers;                                 //回傳4個沒有重複的亂數
        }

        //產生4個不重複的亂數<重載>
        public List<int> GenerateNumber(List<int> alearlyGuestedNumber){
            List<int> numbers = new List<int>();
            do{
                int number = rnd.Next(1, 10);                           //產生1~10其中一個亂數
                if (!this.IsInAnswer(number, alearlyGuestedNumber)) {   //檢查這數字沒有在答案裡的話
                    numbers.Add(number);                                //把亂數加到答案裡
                    alearlyGuestedNumber.Add(number);
                }   
            } while (numbers.Count < 4);                            //做4次
            return numbers;                                         //回傳4個沒有重複的亂數
        }

        //檢查數字有沒有重復
        private bool IsInAnswer(int number, List<int> numbers){
            for (int index = 0; index < numbers.Count; index++) {   //用把亂數用迴圈跟答案的數字比對一回
                if (number == numbers[index]) {                     //若亂數等於答案回傳TRUE 否則回傳FALSE
                    return true;
                }
            }
            return false;
        }
        
        //傳入4個數字的答案,回傳幾 A 幾 B 的結果
        public string GetResult(List<int> userAnswer){
            string result = "";
            for (int userAnswerIndex = 0; userAnswerIndex < 4; userAnswerIndex++){
                for (int answerIndex = 0; answerIndex < 4; answerIndex++){
                    if (userAnswer[userAnswerIndex] == this.answer[answerIndex]){
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
        public string ConvertNumbersToString(List<int> numbers){
            string result = "";
            for (int index = 0; index < numbers.Count; index++)
                result += numbers[index].ToString();
            return result;
        }

        //清除相關參數
        public void cleanAnswerAndCounts(){
            guestTimes = 0;
            alearlyGuestNumber.Clear();
            possibleNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            impossibleNumber.Clear();
            answer.Clear();
            userAnswer.Clear();
            userAnswer.Clear();
            aCount = 0;
            bCount = 0;
            
        }


        //遊戲結束
        public void end() {

        }
        
    }
}
