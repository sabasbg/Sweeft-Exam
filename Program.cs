using System;
using System.Collections.Generic;
using System.Linq;

namespace Sweeft_Exam
{
    class Program
    {

        public static Boolean isPalindrome(string name)
        {
            string first = name;
            char[] array = name.ToCharArray();
            Array.Reverse(array);

            string temp = new string(array);
            string second = temp;

            return first.Equals(second);
        }
        static Boolean isProperly(String sequence)
        {
            List<char> sequences = new List<char>();
            int LastElement;
            Boolean result = true;
            int i = 1;
            int j;

            foreach (var item in sequence)
            {
                sequences.Add(item);
            }
            LastElement = sequences.Count;
            if (sequences.ElementAt(0) == sequences.ElementAt(LastElement - 1))
                result = false;

            for (i = 1; i <= LastElement - 3; i++)
            {
                j = i + 1;
                if (sequences.ElementAt(i) == sequences.ElementAt(j))
                    result = false;
            }

            return result;
        }
        static int minSplit(int amount)
        {
            int counter = 0;
            while (amount != 0)
            {
                if (amount >= 50)
                {
                    amount = amount - 50;
                    counter++;
                }
                else if (amount >= 20)
                {
                    amount = amount - 20;
                    counter++;
                }
                else if (amount >= 5)
                {
                    amount = amount - 5;
                    counter++;
                }
                else if (amount >= 1)
                {
                    while (amount != 0)
                    {
                        amount = amount - 1;
                        counter++;
                    }
                }
            }
            return counter;
        }
        public static int notContains(int[] array)
        {
            int j;
            int tmp;
            int min;
            int counter = 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        tmp = array[j];
                        array[j] = array[i];
                        array[i] = tmp;
                    }
                }
            }
            min = array[0];
            while (array.Contains(min + counter))
            {
                counter++;
            }
            return min + counter;
        } 
        static int countVariants(int stearsCount)
        {
            List<int> Mylist = new List<int>();
            List<int> BasicNumbers = new List<int> { 1, 1, 2, 3 };
            Mylist.AddRange(BasicNumbers);
            if (stearsCount > 3)
            {
                while (Mylist.Count != stearsCount + 1)
                {
                    int tmp = Mylist.Count;
                    int number = Mylist.ElementAt(tmp - 1) + Mylist.ElementAt(tmp - 2);
                    Mylist.Add(number);
                }
            }
            int result = Mylist.ElementAt(stearsCount);
            if (stearsCount == 1)
                return BasicNumbers[0];
            else if (stearsCount == 2)
                return BasicNumbers[1];
            else if (stearsCount == 3)
                return BasicNumbers[3];
            return result;
        } 

        static void Main(string[] args)
        {

            Console.WriteLine();
        }
    }
}
