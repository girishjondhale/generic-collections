
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genaric_collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______list(product)_________");

            List<Product> p1 = new List<Product>();
            p1.Add(new Product { id = 1, name = "mobile", price = 10000 });
            p1.Add(new Product { id = 2, name = "bat", price = 1000 });
            p1.Add(new Product { id = 3, name = "tv", price = 20000 });

            // p1.AddRange(p1);

            p1.Remove(new Product { id = 2, name = "mobile", price = 15000 });

            p1.Insert(0, new Product { id = 4, name = "bike", price = 100000 });

            foreach (Product p in p1)
            {
                Console.WriteLine(p.PrintDetails());
            }
            Console.WriteLine("________list(int)_______________");

            List<int> p2 = new List<int>();
            p2.Add(5);
            p2.Add(6);
            foreach (int p in p2)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("________list(string)__________________");

            List<string> list = new List<string>();
            list.Add("aa");
            list.Add("bbb");
            list.Add("cc");

            list.Insert(2, "cd");

            list.Remove("bbb");

            list.AddRange(list);

            foreach (string s in list)
            {
                Console.WriteLine(s);

            }
            Console.WriteLine("___________stack_________________________");

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            //stack.Pop();
            stack.Peek();
            stack.Contains(12);

            foreach (int p in stack)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("____________queue____________________________");

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(50);
            queue.Enqueue(34);

            queue.Dequeue();

            queue.Peek();

            //queue.Clear();

            foreach (int r in queue)
            {
                Console.WriteLine(r);
            }




        }
    }
}
