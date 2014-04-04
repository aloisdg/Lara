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
            lara.GetAllText(@"C:\Users\alois\Documents\GitHub\Lara\Lara\LaraCmd\", "cs", false);
            foreach (var item in lara.Words)
            {
                Console.WriteLine(String.Format("{0}\t{1}", item.Value.ToString(), item.Key.ToString()));
            }
            Console.ReadLine();
        }
    }
}
