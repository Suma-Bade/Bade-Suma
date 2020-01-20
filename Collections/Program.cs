using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
              a1.Add(5);    
                a1.Add(2.33);
                a1.Add("suma");
                       foreach (var val in a1)
                Console.WriteLine(val);
            Queue qlist = new Queue();
            qlist.Enqueue(1);
            qlist.Enqueue("arun");
            qlist.Enqueue('c');
            Console.WriteLine(qlist.Dequeue());
            foreach (var val in a1)
                Console.WriteLine(val);
            Stack slist = new Stack();
            slist.Push(23);
            slist.Push("hello");
            slist.Push(23.123);
            Console.WriteLine(slist.Pop());
            Console.WriteLine(slist.Peek());
            foreach (var s in slist)
                Console.WriteLine(s);
            Hashtable ht = new Hashtable();
            ht.Add(1, "Chennai");
            ht.Add('a', 10000);
            ht.Add("str", 34);
            foreach(var x in ht.Keys)
            {
                Console.WriteLine(x);
                Console.WriteLine(ht[x]);
            }
            List<int> list = new List<int>();
            list.Add(10);
            list.Add('a');
            list.Add(32);
            foreach (int x in list)
                Console.WriteLine(x);
            Queue<string> gqlist = new Queue<string>();
            gqlist.Enqueue("1");
            gqlist.Enqueue("arun");
            gqlist.Enqueue("c");
            Console.WriteLine(gqlist.Dequeue());
            foreach (var x in gqlist)
                Console.WriteLine(x);
            Stack<float> gslist = new Stack<float>();
            gslist.Push(23);
            gslist.Push(54.8f);
            gslist.Push(23.123f);
            Console.WriteLine(gslist.Pop());
            Console.WriteLine(gslist.Peek());
            foreach (var s in gslist)
                Console.WriteLine(s);
            HashSet<int> hs = new HashSet<int>();
            Console.WriteLine("hash set");
            hs.Add(100);
            hs.Add(65);
            hs.Add(100);
            hs.Add(75);
            foreach (var x in hs)
            {
                Console.WriteLine(x);
                
            }
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "raj");
            dt.Add(2, "radha");
            dt.Add(3, "Krishna");
            foreach(KeyValuePair<int,string> k in dt)
            {
                Console.WriteLine(k.Key);
                Console.WriteLine(k.Value);
            }
            Dictionary<string,int> emp = new Dictionary<string,int>();
            emp.Add("Sony",23000);
            emp.Add("Dolly",45000);
            emp.Add("Aarush",67000);
            foreach (KeyValuePair<string,int> k in dt)
            {
                Console.WriteLine(k.Key);
                Console.WriteLine(k.Value);
            }
            Console.ReadLine();

        }
    }
}
