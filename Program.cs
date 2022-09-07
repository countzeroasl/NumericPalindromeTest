namespace NumericPalindromeTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

			Find the largest palindrome made from the product of two 3-digit numbers.

			URL: https://projecteuler.net/problem=4
			*/

			int product = 0;
			int solution = 0;
			int firstNum;
			int secondNum;
			int lowerBound = 100;

			bool IsPalindrome(int number)
			{
				int numForward = 0;
				int numBackward = 0;

				//Set up to mathematically compare the number with it's reverse
				numForward = number;
				string s = number.ToString();
				char[] charArray = s.ToCharArray();
				Array.Reverse(charArray);
				string s1 = new string(charArray);
				numBackward = Convert.ToInt32(s1);

				if (numForward == numBackward)  //If it's equal, it's a Palindrome
				{
					return true;
				}
				return false;

			}

			//Cycle through the combinations of 3-digit numbers
			for (firstNum = 999; firstNum >= lowerBound; --firstNum)
			{
				for (secondNum = 999; secondNum >= lowerBound; --secondNum)
				{
					product = firstNum * secondNum;
					if (IsPalindrome(product))  //Check if product of the two numbers is a palindrome
					{
						if (product > solution) //If it is, and it is larger than any previous solution, store it.
							solution = product;
						break;
					}
				}
			}

			//Program output
			Console.WriteLine("The largest palindrome made from the product of two 4-digit numbers is: " + solution);
		}
	}
}