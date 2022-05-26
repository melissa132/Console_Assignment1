
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string    input;
        public static string    input2;
        public static int[]     marks;
        public static int       target;
        public static int       rc;
        public static string    RevString;
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
            int       FirstPos;
            int       LastPos;

            FirstPos = Array.IndexOf(marks, target);
            LastPos = Array.LastIndexOf(marks, target);
            Console.Write("\nFirst Pos: " + FirstPos.ToString());
            Console.Write("\nLast Pos:  " + LastPos.ToString());
            return 0;
        }
        public static string StringReverse(string s)
        {
            int     TotalLen;
            int     WordLen;
            int     BlankPos;
            int     CurrPos;
            string OutputWord;
            string  OutputPhrase;

            TotalLen = s.Length;
            CurrPos = 0;
            OutputWord = "";
            OutputPhrase = "";

            for (int i = 0; i < TotalLen; i++)
            {
                if (s[i] == ' ')
                {
                    for (int j = i-1; j >= CurrPos; j--)

                    {
                        OutputWord = OutputWord + s[j];

                    }
                    OutputPhrase = OutputPhrase + " " + OutputWord;
                    OutputWord = "";
                    CurrPos = i + 1;
                }
            }
            for (int j = TotalLen-1; j >= CurrPos; j--)
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
            for (int i= 1; i < TotalElements; i++)
            {
                if (CurrNum == nums[i])
                {
                    nums[i] = nums[i] + 1;
               }
                CurrNum = nums[i];
                NumSum += CurrNum;
            }
            Console.Write("\nArray Sum: " + NumSum.ToString());
;           return 0;
        }
    }
}

//next test demo