using System;
using System.Collections.Generic;

namespace fluffy_octo_waddle {
	class Program {
		private const string Value = "What would you like to order? Type done to finish. ";
		public static List<string> order = new List<string>();
		public static List<float> price = new List<float>();
		public static string input = "";

		public static string[] menu = { "bagel", "piece of toast", "dog canned food", "french fries", "binary executable", "water bottle" };
		public static float[] prices = { 4.99f, 2.14f, 7.48f, 3.64f, 7.16f, 2.56f };

		static void Main(string[] args) {
			Console.WriteLine("Welcome to the .ASM shop, with reasonable prices. You are the c+1 th visitor. c++;");

			Console.WriteLine("Menu:");
			for (int i = 0; i != menu.Length; i++) {
				Console.Write(menu[i] + ": ");
				Console.WriteLine(prices[i].ToString());
			}
			Console.Write(Value);
			while (input != "done") {
				input = Console.ReadLine();
				var index = Array.IndexOf(menu, input);
				if (index == -1) {
					Console.Write("Invalid choice. What else would you like to order? Type done to finish. ");
				} else {
					order.Add(menu[index]);
					price.Add(prices[index]);
					Console.Write("Added a " + menu[index] + " to your cart!\nWhat else would you like to order? Type done to finish. ");
				}
			}

			string[] cart = order.ToArray();
			float[] pricearray = price.ToArray();
			float tax = 0.08625f;
			float total = 0f;
			Console.WriteLine("Your cart: ");
			float subtotal = 0;
			for (int i = 0; i < cart.Length; i++) {
				subtotal += pricearray[i];
				Console.WriteLine(cart[i]);
			}
			subtotal = (float)Math.Round(subtotal, 2);
			Console.WriteLine("Subtotal: " + subtotal);
			tax = tax * subtotal;
			tax = (float)Math.Round(tax, 2);
			Console.WriteLine("Tax: {0}", tax);
			total = subtotal + tax;
			total = (float)Math.Round(total, 2);
			Console.WriteLine("Total: {0}", total);


			Console.Read();
		}

	}
}
