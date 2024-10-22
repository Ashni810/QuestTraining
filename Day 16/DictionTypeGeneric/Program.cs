using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DictionTypeGeneric
{
    public class SimpleDictionary<TKey, TValue>
    {

        private Dictionary<TKey, TValue> _data = new Dictionary<TKey, TValue>();

       // public int Count => _data.Count;
        public void Add(TKey key, TValue value)
        {
            _data.Add(key, value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new SimpleDictionary<string, string>();
            data.Add("Name", "Ashni");
            Console.WriteLine("Key: Name, Value: Ashni");
        }
    }
}
