using System;
using System.Collections.Generic;

namespace KonzolnaAplikacija
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList myList = new IntegerList(3);
            //ListExample(myList);

            IGenericList<int> myGenericListInteger = new GenericList<int>();
            //GenericListExampleInteger(myGenericListInteger);

            IGenericList<String> myGenericList = new GenericList<string>();
            //GenericListExampleString(myGenericList);


            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add(" Hello ");
            stringList.Add(" World ");
            stringList.Add("!");
            // foreach
            foreach (string value in stringList)
            {
                Console.WriteLine(value);
            }
            // foreach without the syntax sugar
            IEnumerator<string> enumerator = stringList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                string value = (string)enumerator.Current;
                Console.WriteLine(value);
            }


            Console.Read();
            
        }

        public static void ListExample(IIntegerList listOfIntegers)
        {
            listOfIntegers.Add(1); // [1]
            listOfIntegers.Add(2); // [1 ,2]
            listOfIntegers.Add(3); // [1 ,2 ,3]
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
            listOfIntegers.RemoveAt(0); // [2 ,3 ,4 ,5]
            listOfIntegers.Remove(5); //[2 ,3 ,4]

            Console.WriteLine(listOfIntegers.Count); // 3
            Console.WriteLine(listOfIntegers.Remove(100)); // false
            Console.WriteLine(listOfIntegers.RemoveAt(5)); // false
            listOfIntegers.Clear(); // []
            Console.WriteLine(listOfIntegers.Count); // 0
        }

        public static void GenericListExampleInteger(IGenericList<int> list)
        {
            list.Add(1); // [1]
            list.Add(2); // [1 ,2]
            list.Add(3); // [1 ,2 ,3]
            list.Add(4); // [1 ,2 ,3 ,4]
            list.Add(5); // [1 ,2 ,3 ,4 ,5]
            list.RemoveAt(0); // [2 ,3 ,4 ,5]
            list.Remove(5); // [2 ,3 ,4]
            Console.WriteLine(list.IndexOf(4)); // 2
            Console.WriteLine(list.Contains(3));// true
            Console.WriteLine(list.GetElement(0)); // 2
            Console.WriteLine(list.Count); // 3
            Console.WriteLine(list.Remove(100)); // false
            Console.WriteLine(list.RemoveAt(5)); // false
            list.Clear(); // []
            Console.WriteLine(list.Count); // 0
            Console.Read();
        }

        public static void GenericListExampleString(IGenericList<String> list)
        {            
            list.Add("a"); // [a]
            list.Add("b"); // [a ,b]
            list.Add("c"); // [a ,b ,c]
            list.Add("d"); // [a ,b ,c ,d]
            list.Add("e"); // [a ,b ,c ,d ,e]
            list.RemoveAt(0); // [b ,c ,d ,e]
            list.Remove("e"); // [b ,c ,d]
            Console.WriteLine(list.IndexOf("d")); // 2
            Console.WriteLine(list.Contains("c"));// true
            Console.WriteLine(list.GetElement(0)); // b
            Console.WriteLine(list.Count); // 3
            Console.WriteLine(list.Remove("100")); // false
            Console.WriteLine(list.RemoveAt(5)); // false
            list.Clear(); // []
            Console.WriteLine(list.Count); // 0
            
            
        }
    }
}
