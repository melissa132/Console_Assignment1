
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string input;
        public static string input2;
        public static int[] marks;
        public static int target;
        public static int rc;
        public static string RevString;
        static void Main(string[] args)
        {
            //
            //  Exercise 1 Code - Enter number separated by commas
            //
            //  
            Console.Write("Exercise 1 - Please enter numbers separated by commas: ");
            input = Console.ReadLine();
            Console.Write("\nInput numbers: " + input);
            marks = Array.ConvertAll(input.Split(","), input => int.Parse(input));

            Console.Write("\nPlease enter target number: ");
            input2 = Console.ReadLine();
            target = int.Parse(input2);
            Console.Write("\nTarget number: " + target);

            //  Call Method for Exercise 1
            rc = targetRange(marks, target);

            //
            //  Exercise 2
            //
            //
            Console.Write("\nExercise 2 - Please enter a string to reverse: ");
            input = Console.ReadLine();
            Console.Write("\nInput string entered: " + input);

            //  Call Method for Exercise 2
            RevString = StringReverse(input);
            Console.Write("\nReversed string: " + RevString);


            //
            //  Exercise 3
            //
            //  
            Console.Write("\nExercise 3 - Please enter numbers separated by commas: ");
            input = Console.ReadLine();
            Console.Write("\nInput numbers: " + input);
            marks = Array.ConvertAll(input.Split(","), input => int.Parse(input));

            //  Call Method for Exercise 3
            rc = MinSum(marks);
        }

        // here is a comment

        public static int targetRange(int[] marks, int target)
        {
            int FirstPos;
            int LastPos;

            FirstPos = Array.IndexOf(marks, target);
            LastPos = Array.LastIndexOf(marks, target);
            Console.Write("\nFirst Pos: " + FirstPos.ToString());
            Console.Write("\nLast Pos:  " + LastPos.ToString());
            return 0;
        }
        public static string StringReverse(string s)
        {
            int TotalLen;
            int WordLen;
            int BlankPos;
            int CurrPos;
            string OutputWord;
            string OutputPhrase;

            TotalLen = s.Length;
            CurrPos = 0;
            OutputWord = "";
            OutputPhrase = "";

            for (int i = 0; i < TotalLen; i++)
            {
                if (s[i] == ' ')
                {
                    for (int j = i - 1; j >= CurrPos; j--)

                    {
                        OutputWord = OutputWord + s[j];

                    }
                    OutputPhrase = OutputPhrase + " " + OutputWord;
                    OutputWord = "";
                    CurrPos = i + 1;
                }
            }
            for (int j = TotalLen - 1; j >= CurrPos; j--)
            {
                OutputWord = OutputWord + s[j];
            }
            OutputPhrase = OutputPhrase + " " + OutputWord;
            return OutputPhrase;
        }
        public static int MinSum(int[] nums)
        {
            int TotalElements;
            int CurrNum;
            Array.Sort(nums);
            int NumSum;

            TotalElements = nums.Length;
            CurrNum = nums[0];
            NumSum = nums[0];
            for (int i = 1; i < TotalElements; i++)
            {
                if (CurrNum == nums[i])
                {
                    nums[i] = nums[i] + 1;
                }
                CurrNum = nums[i];
                NumSum += CurrNum;
            }
            Console.Write("\nArray Sum: " + NumSum.ToString());
            ; return 0;
        }


        //Excercise4

        /*string freqsortresultstring;
        freqsortresultstring = FreqSort("Dell");
        Console.Write(freqsortresultstring);
        */

        public static string FreqSort(string s)
        {
            Dictionary<char, int> sresult = new Dictionary<char, int>();
            char c;
            int numberoftimes;
            bool charexists;

            for (int i = 0; i < s.Length; i++)
            {
                c = s[i];
                charexists = sresult.ContainsKey(c);
                if (charexists)
                    continue;
                numberoftimes = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == c)
                        numberoftimes++;
                }
                sresult.Add(c, numberoftimes);
            }
            string output = "";
            foreach (KeyValuePair<char, int> kvp in sresult.OrderByDescending(key => key.Value))
            {
                for (int k = 0; k < kvp.Value; k++)
                    output += kvp.Key;
            }
            return output;

        }
        //Excercis5
        /*
        int[] intersectresult;
        intersectresult = intersectionarrays(new int[] { 3,6,2 }, new int[] { 6,3,6,7,3});
        Console.Write('[');
        for (int i = 0; i < intersectresult.Length; i++)
            Console.Write(intersectresult[i]);
        Console.Write(']');
        */
        public static int[] intersectionarrays(int[] a, int[] b)
        {
            Array.Sort(a);
            Array.Sort(b);

            List<int> alist = a.ToList();
            List<int> blist = b.ToList();

            List<int> result = new List<int>();
            int index;

            for (int i = 0; i < alist.Count; i++)
            {
                index = blist.IndexOf(alist[i]);
                if (index != -1)
                {
                    result.Add(alist[i]);
                    blist.RemoveAt(index);
                }
            }

            return result.ToArray();

        }
        //Excercise6
        /*

        char[] inputarr = { 'a', 'b', 'c', 'a' , 'b', 'c'};
        bool returnvalue;
        int absdiff = 2;
        returnvalue = containsduplicate(inputarr,absdiff );
        Console.WriteLine(returnvalue);
        */
        public static bool containsduplicate(char[] a, int b)
        {
            bool exists = false;
            char c;
            for (int i = 0; i < a.Length; i++)
            {
                c = a[i];
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] == c && Math.Abs(j - i) == b)
                    {
                        exists = true;
                        break;
                    }

                }
                if (exists)
                    break;
            }
            return exists;

        }
    }
}


















