using System;
using System.Collections.Generic;
using System.Text;

namespace CodGeneretor
{
    class Dic<TKey, TValue>
    {
        private Dictionary<TKey, TValue> dictionary;

        public Dic() { 
            dictionary = new Dictionary<TKey, TValue>();
        }

        public bool ContainsKey(TKey key)
        {
            return dictionary.ContainsKey(key);
        }

        public void Set(TKey key, TValue value)
        {
            if (ContainsKey(key))
            {
                Console.WriteLine("Current Key already exist.");
                return;
            }
            dictionary.Add(key, value);
        }

        public TValue Get(TKey key)
        {
            if (!ContainsKey(key))
            {
                Console.WriteLine($"The key {key} doesn't exist.");
                return default;
            }
            else
            {
                return dictionary[key];
            }
        }

        public void ShowAll()
        {
            foreach(var element in dictionary)
            {
                Console.WriteLine($"Key: {element.Key}, Value: {element.Value}");
            }
        }
    }
}
