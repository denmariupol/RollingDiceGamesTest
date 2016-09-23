using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDiceGames
{
    class Numbers
    {

        Random rand = new Random();
        int GenerateLength()
        {
            return rand.Next(3, 10);
        }
        public List<int> GenerateNumbers()
        {
            List<int> numbers = new List<int>();
            int length = GenerateLength();

            for (int i = 0; i < length; i++)
                numbers.Add(rand.Next(1, 10));

            return numbers;
        }
        public void Check(List<int> list)
        {
            int firstNum , secondNum;

            for(int i = 0;i < list.Count;i++)
            {
                firstNum = list[i];
                secondNum = list[i + 1];
                if (secondNum > firstNum)
                {

                }
            }
        }
        
    }
}
