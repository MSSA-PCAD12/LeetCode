using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Trie
{
    public class Trie
    {
        class TrieNode
        {
            public char Val = '\0';
            public bool WordEnd = false;
            public List<TrieNode> Children;
            public TrieNode(char val, bool wordEnd = false)
            {
                this.Val = val;
                WordEnd = wordEnd;
                Children = new List<TrieNode>();
            }

        }

        TrieNode root;
        public Trie()
        {
            root = new TrieNode('\0');
        }

        public void Insert(string word)
        {
            var curr = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!curr.Children.Select(n => n.Val).Contains(word[i]))
                {
                    var childNode = new TrieNode(word[i], i == word.Length - 1);
                    curr.Children.Add(childNode);
                    curr = childNode;
                }
                else
                {
                    curr = curr.Children.Where(c => c.Val == word[i]).First();
                    if (i == word.Length - 1) curr.WordEnd = true;
                }
            }
        }

        public bool Search(string word)
        {
            var curr = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (curr.Children.Select(n => n.Val).Contains(word[i]))
                {
                    curr = curr.Children.Where(c => c.Val == word[i]).First();
                    if (curr == null) return false;
                }
                else
                { return false; }

            }
            return curr.WordEnd;
        }

        public bool StartsWith(string prefix)
        {
            var curr = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (curr.Children.Select(n => n.Val).Contains(prefix[i]))
                {
                    curr = curr.Children.Where(c => c.Val == prefix[i]).First();
                }
                else
                { return false; }
            }
            return true;
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */

    public class Trie2
    {

        List<string> words;
        public Trie2()
        {
            words = new List<string>();
        }

        public void Insert(string word)
        {
            words.Add(word);
        }

        public bool Search(string word) => words.Contains(word);

        public bool StartsWith(string prefix) =>
          words.Where(w => w.StartsWith(prefix)).Any();

    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}
