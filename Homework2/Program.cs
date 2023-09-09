using System.Collections.Immutable;
using System.Runtime.ExceptionServices;
using System.Text;
namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exercise 1 first link

            static int[] countBy(int number, int counter)
            {
                int[] array = new int[counter];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = number * (i + 1);
                }

                return array;
            }

            // exercise 1 second link

            string[] mySplit(string str)
            {
                string[] array = str.Trim().Split(' ').ToArray();
                return array;
            }

            string one = "Robin Singh";
            string two = "I love arrays they are my favorite";
            string[] oneResult = mySplit(one);
            string[] twoResult = mySplit(two);
            // Exercise 1 link 3

            int[] Link3(int[] arr)
            {
                int posNumCounter = 0;
                int negNumSum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        posNumCounter++;
                    }
                    else if (arr[i] < 0)
                    {
                        negNumSum += arr[i];
                    }
                }
                int[] nArr = new int[2] { posNumCounter, negNumSum };
                return nArr;
            }
            
            // Exercise 1 link 4

            int squareSum(int[] array)
            {
                int result = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    result += array[i] * array[i];
                }
                return result;
            }

            // Exercise 1 link 5
            
            char[] Link5(int number)
            {
                string str = number.ToString();
                char[] chars = new char[str.Length];
                int y = chars.Length - 1;
                for (int i = 0; i < str.Length;)
                {
                    chars[y] = str[i];
                    y--;
                    i++;
                }
                return chars;
            }

            // Exercise 2

            int[] myArray = { 10, 16, 24, 34, 53, 12, 12, 54, 34, 32, 21, 14, 54, 45 };
            foreach (var item in myArray)
            {
                Console.Write(item + "\t");
            }

            // Exercise 3
            Console.WriteLine("\n");
            for (int i = 10; i <= 100; i++) 
            {
                if  (i % 5== 0)
                {
                    Console.Write(i + "\t");
                }
            }

            // Exercise 4
            Console.WriteLine("\n");
            int c = -20;
            do
            {
                if (c % 20 == 0)
                {
                    Console.WriteLine(c + "\t");
                }
                c--;

            }
            while (c >= -100);

            // Additional exercise 1

            bool isPalindrome(string str)
            {
                string firstStr = str;
                char[] secRev = str.Reverse().ToArray();
                string secondStrRev = new string(secRev); 
                char[] secondChArr = secondStrRev.ToCharArray();
                string secondStr = new string(secondChArr);
                if (firstStr == secondStr)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // Additional exercise 2

            int[] ArrPlusOne(int[] array)
            {
                int[] outArray = new int[array.Length];
                bool incrHasDone = false;
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    bool wasNil = false;
                    if (array[i] < 0)
                    {
                        array[i] = 0;
                        wasNil = true;
                    }
                    if (incrHasDone == false && wasNil == false)
                    {
                        array[i] += 1;
                        incrHasDone = true;
                    }
                    if (array[i] >= 10)
                    {
                        array[i] = 0;
                        incrHasDone = false;
                    }
                    if (i == 0 && array[i] == 0)
                    {
                        if (incrHasDone == false)
                        {
                            array[i] += 1;
                        }
                    }
                    outArray[i] = array[i]; 
                }
                return outArray;
            }

        }

    }
}