using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 赛码_股神
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            int pre = 0;
            int count = 0;
            int n = 100;
            string str = "1";
            for(int i = 1; i <=n; i++)
            {
                if (i == 1)
                {
                    pre += 1;
                }
                else
                {
                    if (count <pre)
                    {
                        sum += 1;
                        str += "+1";
                        count += 1;
                    }
                    else
                    {
                        sum -= 1;
                        str += "-1";
                        pre += 1;
                        count = 0;
                    }
                }
            }
            str += "="+sum.ToString();
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
