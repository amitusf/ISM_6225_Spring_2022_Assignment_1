/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINITION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}",final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[]{"Marshall", "Student","Center"};
            string[] bulls_string2 = new string[]{"MarshallStudent", "Center"};
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch ='c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"

        Example 2:
        Input: s = "aeiou"
        Output: ""

        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                //Creating a list with all the vowels
                List<string> list = new List<string> { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

                //Using foreach loop to check each char in a word, if it's a vowel its being replaced with null string
                foreach (string i in list)
                {
                    s = s.Replace(i, "");
                }

                //Returing the results in Command prompt
                return s;

            }
            catch (Exception)
            {
                throw;
            }

        }
        //reflection - question was straigtforward and simple
        //learning - it made me realise that with Intellisense I dont need to remember the syntaxes,
        //time taken - 15 mins


        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false

       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // write your code here.

                //Storing length of input srings into variables
                int bulls_string1_len = bulls_string1.Length;
                int bulls_string2_len = bulls_string2.Length;

                //Initializing empty strings
                string compare_string1 = "";
                string compare_string2 = "";

                //Using for loops to Concatnat all the words into 1 string with all lower cases chars 
                for (int i = 0; i < bulls_string1_len; i++)
                {
                    compare_string1 = compare_string1 + bulls_string1[i].ToString().ToLower();
                }
                for (int i = 0; i < bulls_string2_len; i++)
                {
                    compare_string2 = compare_string2 + bulls_string2[i].ToString().ToLower();
                }

                //Comparing the strings using Equals function
                if (compare_string1.Equals(compare_string2))
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {

                throw;
            }

        }
        //reflection - initiallly i was trying to compare each chars from both the strings, it was getting complex so dropped that approach
        //learning - came to know about Equals function, there are so many in built functions for strings
        //time taken - 30 mins

        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                //Initializing empty list
                List<int> bull_bucks_list = new List<int>();
                //Storing array into the list
                bull_bucks_list = bull_bucks.ToList();
                //Variable for storing occurances of the integers
                int occurance;
                //Variable for summing up the unique integers
                int unique_sum = 0;
                //Using foreach loop and counting all the integers from input array 
                foreach (int i in bull_bucks)
                {
                    //using findall function on array
                    occurance = bull_bucks_list.FindAll(x => x == i).Count();
                    //If the int appears only once then adding unique_sum variable
                    if (occurance == 1)
                    {
                        unique_sum= unique_sum + i;
                    }
                }
                          
                return unique_sum;
 
            }
            catch (Exception)
            {
                throw;
            }
        }
        //reflection - I tried different approaches like taking distinct and subtracting from main array but did not get right answers 
        //learning - exlpored funtions for array
        // time taken - 3 hours


        /*

        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>

        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // write your code here.
                //getting length of the grid; as it is a square not need to worry about the axis
                int grid_len = bulls_grid.GetLength(0);
                //variable for storing sum of the diagonals
                int grid_sum = 0;
                //1sr case - when the grid has only 1 element
                if (grid_len == 1)
                    grid_sum = bulls_grid[0, 0];
                //2nd case - if the grid is even(even*even)
                else if (grid_len % 2 == 0)
                {
                    //using for loop and adding 4 corners of the square
                    for (int i = 0; i < grid_len / 2; i++)
                    {
                        grid_sum = grid_sum + bulls_grid[i, i] + bulls_grid[grid_len - 1 - i, grid_len - 1 - i]
                           + bulls_grid[i, grid_len - 1 - i] + bulls_grid[grid_len - 1 - i, i];
                    }

                }
                //3rd case - if the grid is odd (odd*odd)
                else if (grid_len % 2 == 1)
                {
                    //using for loop and adding 4 corners of the square 
                    for (int i = 0; i < (grid_len - 1) / 2; i++)
                    {
                        grid_sum = grid_sum + bulls_grid[i, i] + bulls_grid[grid_len - 1 - i, grid_len - 1 - i]
                           + bulls_grid[i, grid_len - 1 - i] + bulls_grid[grid_len - 1 - i, i]
                           ;
                    }
                    //adding the center element for odd grid
                    grid_sum = grid_sum + bulls_grid[(grid_len - 1) / 2, (grid_len - 1) / 2];
                }

                return grid_sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        //reflection - I am more comfortable with 2d array now, this solution is more generic, works for rectangle as well
        //learning - questions seemed hard at the beginning, could not find solution for few hours
        //time taken - 8 hours


        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"

        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                //initializing new array of same length as input string
                string[] new_string = new string[bulls_string.Length];
                //using foreach loop on indices array
                foreach (int i in indices)
                {
                    //storing chars from input string into new array as per position of the indices array
                    new_string[indices[i]] = bulls_string[i].ToString();
                }
                //using for loop and concatnating all the items from array into string in order
                string s = ""; // initialinzinng empty string
                for (int j = 0; j < indices.Length; j++)
                {
                    s = s + new_string[j];
                }
                return s;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        //reflection - tried zip both the array and sort but could not succeed at it, developed this solution instead
        //learning - i have used zip function in python but could not replicate the same here as I am new to the syntaxes
        //time taken - 4 hours


        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.

        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".

        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                //initializing empty strings
                String prefix_string ="";
                string rev_string = "";
                //finding and storing the index location of 'ch' into string
                int index_ch = bulls_string6.IndexOf(ch);
                //using for loop till the location of 'ch'
                for (int i = 0; i <= index_ch; i++)
                {
                    //storing chars in empty string in reverse order
                    rev_string = bulls_string6[i] + rev_string;
                }
                //removing chars till 'ch' from the input string and concatnating reversed string 
                prefix_string = rev_string + bulls_string6.Substring(index_ch + 1);
                return (prefix_string);
            }
            catch (Exception)
            {

                throw;
            }
            //reflection - the question was similar to examples in Beginners guide to C# book
            //learning - came to know about indexOf function
            //time taken - 30 hour

        }
    }
}
