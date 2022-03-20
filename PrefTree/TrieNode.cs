using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefTree
{
    class TrieNode
    {
        public TrieNode[] elems = new TrieNode[26];
        public bool isEnd = false;

        public TrieNode()
        {
            for(int i=0; i<elems.Length;i++)
            {
                elems[i] = null;
            }
        }

    }

    class Trie
    {
        public TrieNode root = null;
        
        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode point = root;

            for (int i = 0; i < word.Length; i++)
            {
                char c = word.ElementAt(i);

                int index = c - (int)'a';

                if (point.elems[index] == null)
                {
                    point.elems[index] = new TrieNode();
                    point = point.elems[index];

                }
                else
                {
                    point = point.elems[index];
                }

            }
            point.isEnd = true;
        }

        public bool Search(string word)
        {
            TrieNode point = searchNode(word);
            if (point == null)
                { return false; }
            else
                {
                if(point.isEnd)
                { return true; }
                 }

        return false;
        }

        public TrieNode searchNode(string word)
        {
            TrieNode point = this.root;

            for(int i=0;i<word.Length;i++)
            {
                char c = word.ElementAt(i);

                int index = c - (int)'a';

                if(point.elems[index]!=null)
                {
                    point=point.elems[index];
                }
                else
                {
                    return null;
                }
            }

            if(point==this.root)
            {
                return null;
            }

            return point;
        }


        public bool StartsWith(string pref)
        {
            TrieNode point = searchNode(pref);
            if(point==null)
            { return false; }
            else
            { return true ;}

        }

        public TrieNode searchFromtheEnd(string postfix)
        {
            TrieNode point = this.root;

            for (int i = 0; i < point.elems.Length; i++)
            {
                if (point.elems[i] != null)
                { Console.WriteLine(i); }




                //for (int i = 0; i < postfix.Length; i++)
                //{
                //    char c = postfix.ElementAt(i);

                //    int index = c - (int)'a';

                //    if (point.elems[index]==null)
                //    {
                //        Console.WriteLine(index);
                //        //point = point.elems[index];
                //    }
                //    else
                //    {
                //        Console.WriteLine("found");
                //        return point;
                //    }
                //}

                if (point == this.root)
                {
                    return null;
                }
            }

            return null;
        }

        public bool EndsWith(string postfix)
        {
            TrieNode trie = searchFromtheEnd(postfix);
            if(trie==null)
            { return false; }
            else
            { return true; }
            
        }


    }

}
