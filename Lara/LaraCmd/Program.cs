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
            //lara.GetAllText(@"C:\Users\alois\Documents\GitHub\Lara\Lara\LaraCmd\", "cs", System.IO.SearchOption.AllDirectories, true);
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("=========== Power by Lara ===========");
            Console.WriteLine("=========== Made by Alois ===========");
            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < lara.Words.Count && i < 10; i++)
            {
                Console.WriteLine(String.Format("{0,-8}\t{1,-8}\t{2,4}",
                    lara.Words.ElementAt(i).Value.ToString(),
                    lara.Words.ElementAt(i).Key.ToString(),
                    (lara.Words.ElementAt(i).Value / lara.GetWordsTotal() * 100).ToString("0.00") + "%"));
            }
            Console.WriteLine(String.Format("Count{0,32}\nTotal{1,32}\r\n", lara.Words.Count, lara.GetWordsTotal()));
            Console.WriteLine("=====================================");
            Console.ReadLine();
        }
    }
}
