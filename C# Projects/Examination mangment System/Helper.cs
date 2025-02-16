using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_mangment_System
{
    static class Helper
    {

        public static HashSet<int> UniqueValue = new HashSet<int>();
        public static bool GetUniqueValue(int count, out int output)
        {
            var random = new Random();
            int RandomIndex;
            bool flag = false;
            do
            {
                RandomIndex = random.Next(count);
                output = RandomIndex;
                flag = UniqueValue.Add(RandomIndex);
            } while (!flag);

            return flag;
        }


    }
}
