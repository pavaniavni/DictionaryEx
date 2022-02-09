using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Generics
{
     class DictionaryEx
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of Dictionary");
            Dictionary<int, string> IN = new Dictionary<int, string>();
            Console.WriteLine("Enter name of languages : ");
            for (int i = 1; i < 5; i++)
            {
                IN.Add(i, Console.ReadLine());
            }
            foreach (var item in IN)
            {
                Console.WriteLine(item.Key + "====>" + item.Value);
            }

        }
    }
}
