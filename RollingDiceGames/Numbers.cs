using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDiceGames
{
    class Numbers
    {
        private int count = 0;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        Random rand = new Random();
        int GenerateLength()
        {
            return rand.Next(2, 5);
        }
        public List<int> GenerateNumbers()
        {
            List<int> numbers = new List<int>();
            int length = GenerateLength();

            for (int i = 0; i < length; i++)
                numbers.Add(rand.Next(1, 100));

            numbers.Add(0);
            return numbers;
        }
        public void Check(List<int> list)
        {
            int increase, decrease;
            increase = Increase(list);
            decrease = Decrease(list);
            if (increase == 1 || decrease == 1)
                count++;
        }
        int Increase(List<int> list)
        {
            int inc = list[0];
            for (int i = 1; i < list.Count - 1; i++)
            {
                if (list[i] > inc)
                {
                    inc = list[i];
                    if (i == list.Count - 2)
                        return 1;
                }
                else
                    return 0;
            }
            return 1;
        }
        int Decrease(List<int> list)
        {
            int dec = list[0];
            for (int i = 1; i < list.Count - 1; i++)
            {
                if (list[i] < dec)
                {
                    dec = list[i];
                    if (i == list.Count - 2)
                        return 1;
                }
                else
                    return 0;
            }
            return 1;
        }
    }
}
