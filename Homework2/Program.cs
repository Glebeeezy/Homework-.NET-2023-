namespace Homework2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // exercise 1 first link
            // two arguments that will return an array of the first n multiples of x. 
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
            // function that split a string and convert it into an array of words.
            string[] mySplit(string str)
            {
                string[] array = str.Trim().Split(' ').ToArray();
                return array;
            }

            // Exercise 1 link 3
            // Returns an array, where the first element is the count of positives numbers and the second element is sum of negative numbers.
            int[] CountOfPositivesSumOfNegatives(int[] arr)
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
            // square sum function so that it squares each number passed into it and then sums the results together.
            int SquareSum(int[] array)
            {
                int result = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    result += array[i] * array[i];
                }
                return result;
            }

            // Exercise 1 link 5
            // return the digits of number within an array in reverse order.
            char[] ReversedArrayOfDigits(int number)
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
            // function that checks if something is a palindrome. 
            bool isPalindrome(string str)
            {
                string firstStr = str;
                char[] secRev = str.Reverse().ToArray();
                string secondStr = new(secRev);
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
            // return an array that has 1 added to the value represented by the array.
            int[] ArrPlusOne(int[] array)
            {
                int[] outArray = new int[array.Length];
                bool incrementHasDone = false;
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    bool wasNull = false;
                    if (array[i] < 0)
                    {
                        array[i] = 0;
                        wasNull = true;
                    }
                    if (!incrementHasDone && !wasNull)
                    {
                        array[i] += 1;
                        incrementHasDone = true;
                    }
                    if (array[i] >= 10)
                    {
                        array[i] = 0;
                        incrementHasDone = false;
                    }
                    if (i == 0 && array[i] == 0)
                    {
                        if (incrementHasDone == false)
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