using System;
using System.IO;
using System.Text;
using static System.Net.WebRequestMethods;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;




namespace Sharp4
{

    class Program
    {
        static void Main()
        {
            string DZ;
            Console.Write("Введите задание: ");
            DZ = Console.ReadLine();
            switch (DZ)
            {

                //1
                case ("1"):
                    List<int> list1 = new List<int> { 1,6,7,15,19 };
                    List<int> list2 = new List<int> { };
                    list1 = collections.One(list1, list2);
                    for (int i = 0; i < list1.Count; i++)
                        Console.Write(list1[i] + " ");
                    Console.WriteLine();
                    break;
                //2
                case ("2"):
                    LinkedList<int> linkedlist = new LinkedList<int>(new int[] { });
                    collections.Two(linkedlist);
                    break;
                //3
                case ("3"):
                    HashSet<string> menu = new HashSet<string> { "Пицца", "Салат", "Суп", "Бургер", "Паста", "Суши","Багет","Шаурма"};
                    List<HashSet<string>> orders = new List<HashSet<string>>()
        {
            new HashSet<string> { "Пицца", "Салат", "Суп","Шаурма" },
            new HashSet<string> { "Пицца", "Паста", "Суп", "Бургер" },
            new HashSet<string> { "Пицца", "Салат", "Суп", "Багет", "Суши" },
        };
                    collections.Three(menu, orders);
                    break;
                //4
                case ("4"):
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    string Input = "note1.exe";
                    try
                    {
                        StreamReader check = new StreamReader(Input);
                    }
                    catch
                    {
                        Console.Write("Такой путь не может существовать");
                        break;
                    }
                    HashSet<char> sogl = new HashSet<char>("бвгджзйклмнпрстфхцчшщ");

                    HashSet<char> otvet = new HashSet<char>();
                    otvet = collections.MMM(Input, sogl);
                    Console.Write("Уникальные согласные : ");
                    foreach (var item in otvet)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    break;
            }
        }
    }
}