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
        public int Check(List<int> list)
        {
            int nonSawElem = 0;
            for (int i = 1;i < list.Count - 1;i++)
            {
                nonSawElem = CheckElem(list, i);
              
                if (nonSawElem != 0)
                    break;
            }
            return nonSawElem;  
        }

        int CheckElem(List<int> list,int i)
        {
            if (list[i] > list[i - 1] && list[i] > list[i + 1])
                return 0;
            else if (list[i] < list[i - 1] && list[i] < list[i + 1])
                return 0;
            else if (list[i] == list[i - 1] || list[i] == list[i + 1])
                return list[i];
            else
                return list[i + 1];
        }

        
    }
}
