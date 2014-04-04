using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaraCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Lara.Core lara = new Lara.Core();
            lara.GetAllText(@"C:\Users\alois\Downloads\DotNetReferenceSource\Source", "cs", System.IO.SearchOption.AllDirectories, true);
            for (int i = 0; i < lara.Words.Count && i < 10; i++)
            {
                Console.WriteLine(String.Format("{0}\t{1}\t{2}",
                    lara.Words.ElementAt(i).Value.ToString(),
                    lara.Words.ElementAt(i).Key.ToString(),
                    (lara.Words.ElementAt(i).Value / lara.GetWordsTotal() * 100).ToString("0.00") + " %"));
            }
            Console.WriteLine(lara.Words.Count);
            Console.ReadLine();
        }
    }
}
