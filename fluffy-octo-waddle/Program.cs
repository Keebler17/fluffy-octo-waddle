using System;

namespace halfpyramid {
	class Program {
		static void Main(string[] args) {
			askInput:
			Console.WriteLine("how big should your half pyramid be?");
			string input = Console.ReadLine();

			int x = 0;
			if (Int32.TryParse(input, out x)) {
				Console.WriteLine();
				halfPyramid(x);
				Console.Read();
			} else {
				Console.WriteLine("input was not an integer.");
				goto askInput;
			}
		}

		static void halfPyramid(int x) {
			String output = "*";

			for (int i = x; i != 0; i--) {
				Console.WriteLine(output);
				output += "*";
			}
		}
	}
}
