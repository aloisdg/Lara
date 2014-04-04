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
                Console.WriteLine(String.Format("{0}\t{1}", lara.Words.ElementAt(i).Value.ToString(), lara.Words.ElementAt(i).Key.ToString()));
            }
            Console.ReadLine();
        }
    }
}
