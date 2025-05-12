using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Welcome to the program.");

        Palindrome_number Ahh = new Palindrome_number();
        int x = 12321;
        Console.WriteLine(Ahh.Palindrome_numberCheck(x));

    }
}

class TwoSumAHH
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j)
                {
                    return new int[] { i, j };
                }
            }
        }
        return null;
    }
}

class Palindrome_number
{
    public bool Palindrome_numberCheck(int num)
    {
        string str = num.ToString();
        int length = str.Length / 2;
        bool isPalindrome = true;

        for (int i = 0; i < length; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                isPalindrome = false;
                break;  // No need to keep checking
            }
        }

        return isPalindrome;
    }
}






