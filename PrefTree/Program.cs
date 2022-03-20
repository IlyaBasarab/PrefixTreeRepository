using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.Insert("word");

            Console.WriteLine(trie.StartsWith("wo"));

            //Console.WriteLine(trie.EndsWith("rd"));

        }
    }
}
