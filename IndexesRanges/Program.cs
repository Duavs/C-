using System;

namespace DeconstructTuples
{
    class Program
    {
        public string[] words = new string[]
        {
            "apple",
            "banana",
            "cherry",
            "date",
            "elderberry",
            "fig",
            "grape"
        };

        // Accessing elements using index
        public void PrintWordUsingIndex()
        {
            Console.WriteLine(words[1]); // banana
        }
        // Accessing elements relative to the last element using range. it starts with 1 index not 0
        public void PrintWordUsingLastRange()
        {
            Console.WriteLine(words[^1]); // grape
        }
        // Accessing elements using range operator (..)
        public void PrintWordUsingRange()
        {
            string[] range1 = words[1..4]; // This will get elements from index 1 to 3 (4 is exclusive)
            Console.WriteLine("------Return from index 1 to 3------");
            foreach (var word in range1)
            {
                Console.WriteLine($"{string.Join(", ", word)}");
            }

          var range2 = words[..]; // This will get all elements in the array
          Console.WriteLine("------Return All Element in Array------");
            foreach (var word in range2)
            {
                Console.WriteLine($"{string.Join(", ", word)}");
            }
            
            var range3 = words[2..]; // This will get elements from index 2 to the end of the array
            Console.WriteLine("------Return from index 2 to end of array------");
            foreach (var word in range3)
            {
                Console.WriteLine($"{string.Join(", ", word)}");
            }
            
            var range4 = words[..5]; // This will get elements from the start of the array to index 4
            Console.WriteLine("------Return from start of array to index 4------");
            foreach (var word in range4)
            {
                Console.WriteLine($"{string.Join(", ", word)}");
            }
            
            //Indexes and ranges can be variables too
            Index idx = ^4; // This will get the 4th element from the end of the array
            Console.WriteLine(words[idx]);
            
            Range rng = 3..^1; // This will get elements from index 3 to the 2nd last element
            words = words[rng];
            Console.WriteLine("------Return from index 3 to 2nd last element------");
            foreach (var word in words)
            {
                Console.WriteLine($"{string.Join(", ", word)}");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.PrintWordUsingIndex();
            p.PrintWordUsingLastRange();
            p.PrintWordUsingRange();
        }
    }
}