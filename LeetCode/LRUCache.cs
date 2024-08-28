using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LRUCache
    {
        private LinkedList<int?> _cache;
        private Dictionary<int, LinkedListNode<int?>> _index;
        private int _capacity;
        public LRUCache(int capacity)
        {
            _cache = new LinkedList<int?>();
            _index = new Dictionary<int, LinkedListNode<int?>>();
            _capacity = capacity;
            //int? i = null;
           
        }

        public int Get(int key)
        {
            if (!_index.TryGetValue(key, out LinkedListNode<int?>? node)) { return -1; }//return -1 when the key is not found
            if (!node.Value.HasValue) { return -1; }
            _cache.Remove(node);
            _cache.AddFirst(node);
            return node.Value!.Value;
            
        }

        public void Put(int key, int value)
        {
            if (_index.ContainsKey(key) && !_index[key].Value.HasValue) { _index.Remove(key); }
            // if Put supply a key that hasn't been deleted, delete it now.

            LinkedListNode<int?> node = new LinkedListNode<int?>(value);
          
            if (_index.TryAdd(key, node)) // this key is new to the dictionary
            {
                if (_cache.Count + 1 > _capacity)
                    //check if the _cache is full, if _cache.Count+1 is > than _capacity,we need to evict the oldest node
                {
                    _cache.Last!.Value = null;//set the last node value to null
                    _cache.RemoveLast();
                }
                _cache.AddFirst(node);
            }
            else // this key exists so update the node value and bring it the front of the cache.
            {
                node = _index[key];
                node.Value = value;
                _cache.Remove(node);
                _cache.AddFirst(node);
            }
        }
    }
}
