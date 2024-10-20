using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                List<int> missingNumbers = new List<int>(); // Create a list to store missing numbers
                HashSet<int> numSet = new HashSet<int>(nums);
                for (int i = 1; i <= nums.Length; i++)   // Loop through numbers from 1 to n and check which are missing
                {
                    if (!numSet.Contains(i))
                    {
                        missingNumbers.Add(i);
                    }
                }
                return missingNumbers; // Return list of missing numbers
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in FindMissingNumbers: " + ex.Message);
                throw; // Rethrow the exception after logging it
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                int[] result = new int[nums.Length]; // Create result array to store sorted elements
                int evenIndex = 0;    // Two pointers for even and odd numbers
                int oddIndex = nums.Length - 1;

                foreach (int num in nums)
                {
                    if (num % 2 == 0)
                    {
                        result[evenIndex++] = num;
                    }
                    else
                    {
                        result[oddIndex--] = num;
                    }
                }
                return result;    // Return the array sorted by parity
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in SortArrayByParity: " + ex.Message);
                throw; // Rethrow the exception after logging it
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                Dictionary<int, int> map = new Dictionary<int, int>();  // Create a dictionary to store the number and its index
                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];   // Find complement
                    if (map.ContainsKey(complement))
                    {
                        return new int[] { map[complement], i };  // If complement exists, return the indices
                    }
                    map[nums[i]] = i;   // Otherwise, add the number to the map with its index
                }
                return new int[0]; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in TwoSum: " + ex.Message);
                throw; // Rethrow the exception
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                Array.Sort(nums);  // Sort the array first
                int n = nums.Length;  // Calculate the maximum product of three numbers
                return Math.Max(nums[0] * nums[1] * nums[n - 1], nums[n - 1] * nums[n - 2] * nums[n - 3]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in MaximumProduct: " + ex.Message);
                throw; // Rethrow the exception 
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                if (decimalNumber == 0) return "0";  // Handle case for 0
                string binary = "";   // String to store binary result
                while (decimalNumber > 0) // Loop to convert decimal to binary
                {
                    binary = (decimalNumber % 2) + binary;
                    decimalNumber /= 2; // Divide by 2
                }
                return binary;  // Return binary result
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DecimalToBinary: " + ex.Message);
                throw; // Rethrow the exception 
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                int left = 0, right = nums.Length - 1;
                while (left < right)
                {
                    int mid = (left + right) / 2;
                    if (nums[mid] > nums[right])
                    {
                        left = mid + 1;  // Search in the right half
                    }
                    else
                    {
                        right = mid; // Search in the left half
                    }
                }
                return nums[left]; // Return the minimum element
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in FindMin: " + ex.Message);
                throw; // Rethrow the exception 
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                if (x < 0) return false; // Negative numbers are not palindromes
                int original = x, reversed = 0;
                 while (x != 0)                 // Reverse the number

                {
                    int pop = x % 10;
                    x /= 10;
                    reversed = reversed * 10 + pop;
                }
                return original == reversed;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in IsPalindrome: " + ex.Message);
                throw; // Rethrow the exception 
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                if (n <= 1) return n;  // Base cases for Fibonacci
                int a = 0, b = 1;
                for (int i = 2; i <= n; i++)   // Loop to calculate the nth Fibonacci number
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;  // Return the nth Fibonacci number
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Fibonacci: " + ex.Message);
                throw; // Rethrow the exception
            }
        }
    }
}
