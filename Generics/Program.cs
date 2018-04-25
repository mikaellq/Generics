using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection<int> collection = new Collection<int>();
            collection.Add(55);
            collection.Add(67);
            collection.Add(93);
            Console.WriteLine(collection.ShowList());

            Collection<double> collection2 = new Collection<double>();
            collection2.Add(3.14);
            collection2.Add(0.987654321);
            collection2.Add(123.456);
            Console.WriteLine(collection2.ShowList());

            Collection<string> collection3 = new Collection<string>();
            collection3.Add("abc");
            collection3.Add("DEF");
            collection3.Add("aQzWxRcT");
            Console.WriteLine(collection3.ShowList());
            Console.ReadKey();
        }

        public class Collection<T>
        {
            List<T> list;

            public Collection()
            {
                list = new List<T>();
            }

            public void Add(T item)
            {
                list.Add(item);
            }

            public void Remove(T item)
            {
                list.Remove(item);
            }

            public string ShowList()
            {
                string s = "";
                foreach (var item in list)
                {
                    s = s + "\n" + item;
                }
                return s;
            }
        }
    }
}

