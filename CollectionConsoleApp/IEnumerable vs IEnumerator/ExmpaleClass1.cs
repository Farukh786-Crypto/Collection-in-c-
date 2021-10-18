using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CollectionConsoleApp.IEnumerable_vs_IEnumerator
{
    class ExmpaleClass1
    {
        static void Main(string[] args)
        {
            List<int> oyears = new List<int>();
            oyears.Add(1990);
            oyears.Add(1991);
            oyears.Add(1992);
            oyears.Add(1993);
            oyears.Add(2001);

            IEnumerable<int> ienum=(IEnumerable<int>)oyears;

            foreach (var item in ienum)
            {
                Console.WriteLine(item);
            }


            IEnumerator<int> ienumerator = oyears.GetEnumerator();
            while (ienumerator.MoveNext())
            {
                Console.WriteLine(ienumerator.Current.ToString());
            }

            Console.ReadKey();
        }
    }
}
