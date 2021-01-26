using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListsDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myFirstDictionary = new Dictionary<int, string>();

            myFirstDictionary.Add(1, "Chris");
            myFirstDictionary.Add(2, "Jen");
            myFirstDictionary.Add(4, "Derrick");
            myFirstDictionary.Add(3, "Megan");
            myFirstDictionary.Add(6, "Nasir");
            myFirstDictionary.Add(5, "JC");

            P("Print out our dictionary\n");

            foreach (var d in myFirstDictionary)
            {
                P($"{d.Key}: {d.Value}");
            }

            P("\nGet value by a key");

            P(myFirstDictionary[4]); // Derrick

            P("\nLet's sort the dictionary by alphabetical order");

            foreach (var d in myFirstDictionary.OrderBy(d => d.Value))
            {
                P($"{d.Key}: {d.Value}");
            }

            P("\nThe order of the dictionary is not permanently change when I used OrderBy above");

            foreach (var d in myFirstDictionary)
            {
                P($"{d.Key}: {d.Value}");
            }

            P($"\n#########################################\r\n");

            SortedList<int, string> myFirstSortedList = new SortedList<int, string>()
            {
                {1,"Chris" },
                {2,"Jen" }
            };

            myFirstSortedList.Add(4, "Alex");
            myFirstSortedList.Add(3, "Sam");

            foreach (var s in myFirstSortedList)
            {
                P($"{s.Key}: {s.Value}");
            }

            P($"\nGet the value at key 2: {myFirstSortedList[2]}"); // Jen

            bool existsAtKey = myFirstSortedList.ContainsKey(3);
            P(existsAtKey.ToString());

            myFirstSortedList.Remove(3);
            existsAtKey = myFirstSortedList.ContainsKey(3);
            P(existsAtKey.ToString());

            bool isAlexHere = myFirstSortedList.ContainsValue("Alex");
            P(isAlexHere.ToString());

            Console.ReadLine();
        }

        static void P(string value)
        {
            Console.WriteLine(value);
        }
    }
}
