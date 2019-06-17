using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectAndExcept
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<string>() { "as", "s", "ew", "asd" };
            var b = new List<string>() { "as", "3", "ew" };
            var test = Intersect2(a,b);
            PrintWords(test);
            var test2 = Except2(a,b);
            PrintWords(test2);
            Console.ReadKey();
        }
        static IEnumerable<string> Intersect2 (List<string> firstStringNew, List<string> secondStringNew)
        {
            List<string> intersect2 = new List<string>();
            for (int i = 0; i < firstStringNew.Count; i++)
            {
                for (int j = 0; j < secondStringNew.Count; j++)
                {
                    if (firstStringNew[i] == secondStringNew[j])
                    {
                        intersect2.Add(firstStringNew[i]);
                    }
                }
            }
            return intersect2.Distinct();
        }
        static IEnumerable<string> Except2 (List<string> firstStringNew, List<string> secondStringNew)
        {
            List<string> intersect2 = new List<string>();
            for (int i = 0; i < firstStringNew.Count; i++)
            {
                for (int j = 0; j < secondStringNew.Count; j++)
                {
                    if (firstStringNew[i] == secondStringNew[j])
                    {
                        break;
                    }
                    else if (firstStringNew[i] != secondStringNew[secondStringNew.Count - 1])
                    {
                        intersect2.Add(firstStringNew[i]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return intersect2.Distinct();
        }
        private static void PrintWords(IEnumerable<string> words)
        {
            foreach (var item in words)
                Console.WriteLine(item);
        }
    }
}
