﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lara
{
    public class Core
    {
        public Dictionary<string, uint> Words;

        public Core()
        {
            Words = new Dictionary<string, uint>();
        }

        public void GetAllText(string folderPath, string format, SearchOption so, bool isVerbose)
        {
            if (folderPath == null) throw new ArgumentNullException("path");
            foreach (string file in Directory.EnumerateFiles(folderPath,
                String.IsNullOrWhiteSpace(format) ? "*" : String.Format("*.{0}", format),
                so))
            {
                if (isVerbose)
                    Console.WriteLine(Path.GetFileName(file));
                string[] wordtab = SplitWords(File.ReadAllText(file));
                foreach (var item in wordtab)
                {
                    if (Words.ContainsKey(item))
                        Words[item]++;
                    else
                        Words.Add(item, 1);
                }
            }
            Words = Words.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        private string[] SplitWords(string s)
        {
            //
            // Split on all non-word characters.
            // ... Returns an array of all the words.
            //
            return Regex.Split(s, @"\W+");
            // @      special verbatim string syntax
            // \W+    one or more non-word characters together
        }

        public decimal GetWordsTotal()
        {
            decimal total = Words.Sum(x => x.Value);
            return total;
        }
    }
}
