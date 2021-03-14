using System;

namespace H.W__09._03__New_Dictionary_List
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            Console.WriteLine("List");

            Console.WriteLine("Добавление: ");

            list.Add(10);

            list.Add(24);

            list.Add(26);


            Console.WriteLine("Поиск по индексу ");
            Console.WriteLine(list.FindByIndex(0));

            int[] arr = { 1, 2, 3, 4, 5 };
            list.AddRange(arr);
            list.Insert(1, 1111);
            Console.WriteLine("Все элементы: ");
            list.ShowAllElements();

            Console.WriteLine("\nDictionary");

            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            Console.WriteLine("Добавление: ");
            dictionary.Add("Person ", "Akmal");
            dictionary.Add("Car ", "Tayota");
            Console.WriteLine("Поиск по ключу:  ");

            Console.WriteLine();
            Console.WriteLine(dictionary.FindElementByKey("Person: "));

            Console.WriteLine("Все элементы: ");
            Console.ResetColor();
            dictionary.ShowAllElements();
        }
    }
}
