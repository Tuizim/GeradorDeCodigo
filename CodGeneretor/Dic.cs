using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodGeneretor
{
    class Dic 
    {
        private Dictionary<string, string> dictionary;

        public Dic() { 
            dictionary = new Dictionary<string, string>();
        }

        public bool ContainsKey(string key)
        {
            return dictionary.ContainsKey(key);
        }

        public void Set(string key, string value)
        {
            if (ContainsKey(key))
            {
                Console.WriteLine("Current Key already exist.");
                return;
            }
            dictionary.Add(key, value);
        }

        public string Get(string key)
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
