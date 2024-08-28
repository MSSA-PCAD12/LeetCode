using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
    public class RandomizedSet
    {
        
        private List<int> _list=new();
        private Dictionary<int, int> _dictionary=new();
        public RandomizedSet() { }

        public bool Insert(int val)
        {
            if (_dictionary.ContainsKey(val)) { return false; }
            else { _list.Add(val);
            _dictionary.Add(val, _list.Count-1);
                return true;
            }
        }

        public bool Remove(int val)
        {
            if (_dictionary.ContainsKey(val))
            {
                _dictionary.Remove(val);
                return true;
            }
            else { return false; }
        }
        public int GetRandom()
        {
            int randomNumber = new Random().Next(_dictionary.Count);
           return _dictionary.Keys.ElementAt(randomNumber);
        }
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
    public class RandomizedSet2
    {
        private List<int> _list = new();
        private Dictionary<int, int> _dictionary = new();
        public RandomizedSet2() { }

        public bool Insert(int val)
        {
            if (_dictionary.ContainsKey(val)) { return false; }
            else
            {
                _list.Add(val);
                _dictionary.Add(val, _list.Count - 1);
                return true;
            }
        }

        public bool Remove(int val)
        {
            if (_dictionary.ContainsKey(val))
            {
                _dictionary.Remove(val);
                return true;
            }
            else { return false; }
        }
        public int GetRandom()
        {
            int randomNumber = new Random().Next(_dictionary.Count);
            return _dictionary.Keys.ElementAt(randomNumber);
        }
    }

}
