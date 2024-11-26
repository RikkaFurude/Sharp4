using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp4
{
    internal class collections
    {
        public static List<int> One(List<int> list1, List<int> list2)
        {

            if (list1[0] < list1[1])
            {
                int i = 0, j = 0;
                while (j < list2.Count)
                {
                    while (i < list1.Count && list1[i] <= list2[j])
                    {
                        i++;
                    }
                    list1.Insert(i, list2[j]);
                    j++;
                }
                return list1;
            }
            else
            {
                int i = 0, j = 0;
                while (j < list2.Count)
                {
                    while (i < list1.Count && list1[i] >= list2[j])
                    {
                        i++;
                    }
                    list1.Insert(i, list2[j]);
                    j++;
                }
                return list1;
            }
        }
        public static void Two(LinkedList<int> linkedlist)
        {
            int count = 0;
            if (linkedlist.Count < 3)
            {
                Console.WriteLine('0');
            }
            else
            {
                var cur = linkedlist.First.Next;
                while (cur.Next != null)
                {
                    if (cur.Previous.Value == cur.Next.Value)
                    {
                        count++;
                    }
                    cur = cur.Next;
                }
                Console.WriteLine(count);
            }
        }
        public static void Three(HashSet<string> menu, List<HashSet<string>> orders)
        {
            HashSet<string> all = new HashSet<string>(orders[0]);
            foreach (var item in orders)
            {
                all.IntersectWith(item);
            }
            HashSet<string> some = new HashSet<string>();
            foreach (var item in orders)
            {
                some.UnionWith(item);
            }
            HashSet<string> none = new HashSet<string>(menu);
            none.ExceptWith(some);
            Console.Write("Меню : ");
            foreach (var item in menu)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Позиции которые заказали все : ");
            foreach (var item in all)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Позиции которые заказали хотя бы раз : ");
            foreach (var item in some)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Позиции которые ни разу не заказали : ");
            foreach (var item in none)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static HashSet<char> MMM(string In, HashSet<char> sogl)
        {
            StreamReader sr = new StreamReader(In, Encoding.GetEncoding("windows-1251"));
            string line = sr.ReadLine();
            HashSet<char> single = new HashSet<char>();
            HashSet<char> multi = new HashSet<char>();
            while (line != null)
            {
                line = line.ToLower();
                for (int i = 0; i < line.Length; i++)
                {
                    if (sogl.Contains(line[i]))
                    {
                        if (!(single.Contains(line[i])))
                        {
                            single.Add(line[i]);
                        }
                        else
                        {
                            multi.Add(line[i]);
                        }
                    }
                }
                line = sr.ReadLine();
            }
            single.ExceptWith(multi);
            sr.Close();
            return single;
        }
    }
}
