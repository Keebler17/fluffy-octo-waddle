using System;

namespace ReverseString {
	class Program {
		static void Main(string[] args) {
			start:
			Console.Write("Enter text to see the reverse. ");

			string input = Console.ReadLine();
			char[] reverse = input.ToCharArray();
			string reverseParsed = "";
			Array.Reverse(reverse);

			for (int i = 0; i < reverse.Length; i++) {
				reverseParsed += reverse[i];
			}

			Console.WriteLine("Reversed string: " + reverseParsed);
			goto start;

		}
	}
}