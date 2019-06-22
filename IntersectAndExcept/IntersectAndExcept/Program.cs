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
            var a = new List<string>() { "as", "s", "ew", "asd", "vlad" };
            var b = new List<string>() { "vlad", "as", "3", "ew" };
            var test = Intersect2(a,b);
            PrintWords(test);
            Console.WriteLine();
            var test2 = Except2(a,b);
            PrintWords(test2);
            Console.ReadKey();
        }
        static IEnumerable<string> Intersect2 (List<string> firstStringNew, List<string> secondStringNew)
        {
            List<string> intersectList = new List<string>();
            for (int i = 0; i < firstStringNew.Count; i++)
            {
                for (int j = 0; j < secondStringNew.Count; j++)
                {
                    if (firstStringNew[i] == secondStringNew[j])
                    {
                        intersectList.Add(firstStringNew[i]);
                    }
                }
            }
            return intersectList.Distinct();
        }
        static IEnumerable<string> Except2 (List<string> firstStringNew, List<string> secondStringNew)
        {
            List<string> exceptList = new List<string>();
            for (int i = 0; i<firstStringNew.Count; i++)
            {
                var breakExcept = false;
                for (int j = 0; j<secondStringNew.Count; j++)
                {
                    if (firstStringNew[i] == secondStringNew[j])
                    {
                        breakExcept = true;
                        break;
                    }
                }
                if (!breakExcept)
                {
                    exceptList.Add(firstStringNew[i]);
                }
            }
            return exceptList.Distinct();
        }
        private static void PrintWords(IEnumerable<string> words)
        {
            foreach (var item in words)
                Console.WriteLine(item);
        }
    }
}
