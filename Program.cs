
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
            //  Exercise 1 - Enter number separated by commas
            //
            //  
            try
            {
                Console.Write("Exercise 1 - Please enter numbers in ascending order separated by commas: ");
                input = Console.ReadLine();
                Console.Write("\nInput numbers: " + input);
                marks = Array.ConvertAll(input.Split(","), input => int.Parse(input));

                Console.Write("\nPlease enter target number: ");
                input2 = Console.ReadLine();
                Console.Write("\nTarget number: " + input2);
                target = int.Parse(input2);

                //  Call Method for Exercise 1
                rc = targetRange(marks, target);
                //
                //  Exercise 2 - Enter string to reverse
                //
                //


                Console.Write("\nExercise 2 - Please enter a string to reverse: ");
                input = Console.ReadLine();
                Console.Write("\nInput string entered: " + input);



                //  Call Method for Exercise 2
                RevString = StringReverse(input);
                Console.Write("\nReversed string: " + RevString);


                //
                //  Exercise 3 - Enter numbers separated by commas
                //
                //

                Console.Write("\nExercise 3 - Please enter numbers separated by commas: ");
                input = Console.ReadLine();
                Console.Write("\nInput numbers: " + input);
                marks = Array.ConvertAll(input.Split(","), input => int.Parse(input));


                //  Call Method for Exercise 3
                rc = MinSum(marks);

                //
                //  Exercise 4 - sort the given string in decreasing order of frequency of occurrence of each character
                //
                //
                Console.Write("\n\nExercise 4 - Please sort string in decreasing order of frequency by character: ");
                string freqsortresultstring;
                freqsortresultstring = Console.ReadLine();

                freqsortresultstring = FreqSort(freqsortresultstring);
                Console.Write("\nSorted string = " + freqsortresultstring);
            }
            catch
            {
                Console.WriteLine("\nAn error has occurred.");
            }

     }
    // 
    // Method:  targetRange
    // Description: Receives an array of integer points sorted in ascending order, the task is to find the initial and final index of a given target point’s value.
    // Input:
    //  marks:  integer array of integer points in ascending order
    //  target: integer target value
    // Returns:
    //  integer - 0
    //
    public static int targetRange(int[] marks, int target)
        {
            int FirstPos;
            int LastPos;

            // Find first index position of target number
            FirstPos = Array.IndexOf(marks, target);
            // Find last index position of target number
            LastPos = Array.LastIndexOf(marks, target);
            
            // Ouptut the first and last index positions of the target number
            Console.Write("\nFirst Pos: " + FirstPos.ToString());
            Console.Write("\nLast Pos:  " + LastPos.ToString());
            return 0;
        }
        // 
        // Method:  StringReverse
        // Description: Given a string, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
        // Input:
        //  s:  String to reverse
        // Returns:
        //    string
        //
        public static string StringReverse(string s)
        {
            int TotalLen;
            int WordLen;
            int BlankPos;
            int CurrPos;
            string OutputWord;
            string OutputPhrase;

            // Initialize variables        
            TotalLen = s.Length;
            CurrPos = 0;
            OutputWord = "";
            OutputPhrase = "";

            // Loop for count of all characters in the string
            for (int i = 0; i < TotalLen; i++)
            {
                // Blank space indicates new word
                if (s[i] == ' ')
                {
                    // Loop for current word
                    for (int j = i - 1; j >= CurrPos; j--)

                    {
                        OutputWord = OutputWord + s[j];

                    }
                   // Add reversed word to output phrase
                    OutputPhrase = OutputPhrase + " " + OutputWord;
                    OutputWord = "";
                    CurrPos = i + 1;
                }
            }
            // Last word in phrase to reverse
            for (int j = TotalLen - 1; j >= CurrPos; j--)
            {
                OutputWord = OutputWord + s[j];
            }
            OutputPhrase = OutputPhrase + " " + OutputWord;
            return OutputPhrase;
        }

        // 
        // Method:  MinSum
        // Description: Given a sorted integer array, make the array elements distinct by increasing each value as needed, while minimizing the array sum. Print the minimum
        // possible sum as output.
        // Input:
        //  nums:  integer array of numbers
        // Returns:
        //    integer
        //
        public static int MinSum(int[] nums)
        {
            int TotalElements;
            int CurrNum;
            Array.Sort(nums);
            int NumSum;

            // How many numbers were input  
            TotalElements = nums.Length;
         
            // Ititialize variables for current number evaluating and sum of numbers
            CurrNum = nums[0];
            NumSum = nums[0];

            // Loop through all numbers
            for (int i = 1; i < TotalElements; i++)
            {
                if (CurrNum == nums[i])     // Are the numbers the same?
                {
                    nums[i] = nums[i] + 1;  // Same number so increment value by 1
                }
                else if (CurrNum > nums[i]) // Number is less than 
                {
                    nums[i] = nums[i-1] + 1;
                }
                CurrNum = nums[i];          // Set current number value
                NumSum += CurrNum;          // Add current number value to sum
            }
            // Loop complete, output the sum of the numbers
            Console.Write("\nArray Sum: " + NumSum.ToString());
            ; return 0;
        }


        //Excercise4

        /*
        Console.Write("\nExercise 4 - Please sort string in decreasing order of frequency by character: ");
        string freqsortresultstring;
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
        Console.Write("\nExercise 5 - The intersection of two arrays: ");
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

        Console.Write("\nExercise 6 - Find two distinct indicies, i and j: ");
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

