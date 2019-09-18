using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitControlSample
{
    class Program
    {
        static void Main(string[] args)
        {
            byte valueBytes = 0b1111_0101;//dex:245

            //set to 0b1011_1111

            #region 使用二元邏輯運算子操作

            int sample = valueBytes;
            Console.WriteLine($"sample1 is {Convert.ToString(sample, 2)}");
            sample = sample - (1 << 6) + (1 << 3) + (1 << 1);
            Console.WriteLine("sample1 equal:" + (sample == 0b1011_1111));

            #endregion

            Console.WriteLine();

            #region 使用內建的BitArray操作

            BitArray sample2 = new BitArray(new byte[] { valueBytes });
            sample2.Set(1, true);
            sample2.Set(3, true);
            sample2.Set(6, false);
            byte[] result2 = new byte[1];
            sample2.CopyTo(result2, 0);
            Console.WriteLine($"sample2 is {Convert.ToString(result2.First(), 2)}");
            Console.WriteLine("sample2 equal:" + (result2.First() == 0b1011_1111));

            #endregion
        }
    }
}
