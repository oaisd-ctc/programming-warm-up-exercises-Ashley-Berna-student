using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1;
            int b = 0;
            int c = 5;
            int d = 10;
            int[] e = {1, 2, 3, 4, 5};
            int[] f = {5, 4, 10, -3};
            int[] g = {-10, 3, 8, 9, 20};
            string words = "abcdefg";
            string hello = "Hello, how are you?";
            string greeting = "hi, how are you?";
            string palendrome = "madam";
            string notPalendrome = hello;

            //Use the Main method to test your functions.
            //Add()
            Console.WriteLine($"{c} + {d} = {Add(c, d)}");
            Console.WriteLine($"{a} + {d} = {Add(a, d)}");
            Console.WriteLine($"{a} + {b} = {Add(a, b)}");
            Console.WriteLine("");

            //IsEven()
            Console.WriteLine($"Is this number even? {a} {IsEven(a)}");
            Console.WriteLine($"Is this number even? {d} {IsEven(d)}");
            Console.WriteLine($"Is this number even? {b} {IsEven(b)}");
            Console.WriteLine("");

            //MaxOfThree()
            Console.WriteLine($"{a}, {b}, {c}. Here is the biggest number: {MaxOfThree(b, c, a)}");
            Console.WriteLine($"{a}, {d}, {c}. Here is the biggest number: {MaxOfThree(d, c, a)}");
            Console.WriteLine($"{d}, {b}, {c}. Here is the biggest number: {MaxOfThree(b, c, d)}");
            Console.WriteLine("");

            //StringLength()
            Console.WriteLine($"The length of '{words}' is: {StringLength(words)}");
            Console.WriteLine($"The length of '{hello}' is: {StringLength(hello)}");
            Console.WriteLine($"The length of '{greeting}' is: {StringLength(greeting)}");
            Console.WriteLine("");


            Console.WriteLine($"Does this sentance start with 'Hello'? {hello}, {StartsHello(hello)}");
            Console.WriteLine($"Does this sentance start with 'Hello'? {greeting}, {StartsHello(greeting)}");
            Console.WriteLine($"Does this sentance start with 'Hello'? {palendrome}, {StartsHello(palendrome)}");
            Console.WriteLine("");


            Console.WriteLine($"{greeting} reversed is: {ReverseString(greeting)}");
            Console.WriteLine($"{hello} reversed is: {ReverseString(hello)}");
            Console.WriteLine($"{palendrome} reversed is: {ReverseString(palendrome)}");
            Console.WriteLine("");


            Console.WriteLine($"The factorial of {b} is: {Factorial(b)}");
            Console.WriteLine($"The factorial of {c} is: {Factorial(c)}");
            Console.WriteLine($"The factorial of {d} is: {Factorial(d)}");
            Console.WriteLine("");


            Console.WriteLine($"is {d} a prime number? {IsPrime(d)}");
            Console.WriteLine($"is {b} a prime number? {IsPrime(b)}");
            Console.WriteLine($"is {c} a prime number? {IsPrime(c)}");
            Console.WriteLine("");


            Console.WriteLine($"The fibonacci of {c} is: {Fibonacci(c)}");
            Console.WriteLine($"The fibonacci of {b} is: {Fibonacci(b)}");
            Console.WriteLine($"The fibonacci of {d} is: {Fibonacci(d)}");
            Console.WriteLine("");


            Console.WriteLine($"{String.Join( ", ",e)}. The biggest number is {LargestInArray(e)}");
            Console.WriteLine($"{String.Join( ", ",f)}. The biggest number is {LargestInArray(f)}");
            Console.WriteLine($"{String.Join( ", ",g)}. The biggest number is {LargestInArray(g)}");
            Console.WriteLine("");


            Console.WriteLine($"is this message a palindrome? {palendrome}. {IsPalindrome(palendrome)}");
            Console.WriteLine($"is this message a palindrome? {hello}. {IsPalindrome(hello)}");
            Console.WriteLine($"is this message a palindrome? {greeting}. {IsPalindrome(greeting)}");
            Console.WriteLine("");


            Console.WriteLine($"The sum of {String.Join( ", ",e)} is {ArraySum(e)}");
            Console.WriteLine($"The sum of {String.Join( ", ",f)} is {ArraySum(f)}");
            Console.WriteLine($"The sum of {String.Join( ", ",g)} is {ArraySum(g)}");
            Console.WriteLine("");


            Console.WriteLine($"The number of times the letter h appears in '{greeting}' is: {CharCount(greeting, 'h')}");
            Console.WriteLine($"The number of times the letter w appears in '{hello}' is: {CharCount(hello, 'w')}");
            Console.WriteLine($"The number of times the letter a appears in '{palendrome}' is: {CharCount(palendrome, 'a')}");
            Console.WriteLine("");


            Console.WriteLine($"sentance 1, {hello}, and sentance 2, {greeting}, put together is {ConcatenateStrings(hello, greeting)}");
            Console.WriteLine($"sentance 1, {palendrome}, and sentance 2, {greeting}, put together is {ConcatenateStrings(palendrome, greeting)}");
            Console.WriteLine($"sentance 1, {hello}, and sentance 2, {palendrome}, put together is {ConcatenateStrings(hello, palendrome)}");
            Console.WriteLine("");


            Console.WriteLine($"Swapping the first and last letter of this sentance, {hello}. {SwapEnds(hello)}");
            Console.WriteLine($"Swapping the first and last letter of this sentance, {greeting}. {SwapEnds(greeting)}");
            Console.WriteLine($"Swapping the first and last letter of this sentance, {palendrome}. {SwapEnds(palendrome)}");
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            // TODO: Implement this method.
            int solution = a + b;
            return solution;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            // TODO: Implement this method.
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            // HINT: You might want to use Math.Max function.
            // TODO: Implement this method.
            int biggerNum = Math.Max(a, b);
            return Math.Max(biggerNum, c);
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            // TODO: Implement this method.
            int length = s.Length;
            return length;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            // HINT: Use the string method "StartsWith".
            // TODO: Implement this method.
            if (s.StartsWith("Hello"))
            {
                return true;
            }
            return false;
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            // TODO: Reverse the charArray.
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            else
            {
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                }
                return n;
            }
            // TODO: Calculate the factorial.
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            // TODO: Return the correct boolean value.
            return true;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            // TODO: Calculate the nth Fibonacci number.
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                // TODO: Find the largest number in the array.
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            // TODO: Determine if the string is a palindrome.
            char[] cArray = s.ToCharArray();
            Array.Reverse(cArray);
            string revStr = new string(cArray);
            if (s == revStr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            // TODO: Calculate the sum of the array's elements.
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            // TODO: Count how many times character c appears in string s.
            int n = 0;

            while ((n = s.IndexOf(c, n) + 1) !=0)
            {
                n++;
                count++;
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            // TODO: Concatenate the two strings with a space in between.
            string conStr = string.Concat(str1, " ", str2);
            return conStr;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            // TODO: Swap the first and last characters and return the modified string.
            return lastChar + s.Substring(1, s.Length - 2) + firstChar;
        }
    }
}
