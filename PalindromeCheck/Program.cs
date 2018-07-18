using System;

namespace PalindromeCheck {
	class Program {
		static void Main(string[] args) {
			start:
			Console.Write("Enter text to see if it is a palindrome. ");

			string input = Console.ReadLine();
			char[] reverse = input.ToCharArray();
			string reverseParsed = "";
			Array.Reverse(reverse);

			for(int i = 0; i < reverse.Length; i++) {
				reverseParsed += reverse[i];
			}

			if (input == reverseParsed) {
				Console.WriteLine("That is a palindrome.");
			} else {
				Console.WriteLine("That is not a palindrome.");
			}

			goto start;
			
		}
	}
}