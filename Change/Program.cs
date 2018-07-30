using System;

namespace Change {
	class Program {
		static void Main(string[] args) {
			start:
			Console.WriteLine("Note: Prices will only count to two decimal places.");
			Console.Write("Price: ");
			string sprice = Console.ReadLine();

			if(float.TryParse(sprice, out float price)) {
				
			} else {
				Console.WriteLine("Not a valid number.");
				goto start;
			}

			paid:
			Console.Write("Paid: ");
			string spaid = Console.ReadLine();

			if(float.TryParse(spaid, out float paid)) {

			} else {
				Console.WriteLine("Not a valid number");
				goto paid;
			}

			float difference = paid - price;
			if(0 > difference) {
				Console.WriteLine("That is not enough money.");
				goto start;
			}

			Console.WriteLine("Price: " + sprice + "\nPaid: " + spaid);

			Console.WriteLine("Change:");

			while(true) {
				if(difference - 100 > 0) {
					Console.WriteLine("$100");
					difference -= 100;
				} else if(difference - 50 > 0) {
					Console.WriteLine("$50");
					difference -= 50;
				} else if(difference - 20 > 0) {
					Console.WriteLine("$20");
					difference -= 20;
				} else if(difference - 10 > 0) {
					Console.WriteLine("$10");
					difference -= 10;
				} else if(difference - 5 > 0) {
					Console.WriteLine("$5");
					difference -= 5;
				} else if(difference - 2 > 0) {
					Console.WriteLine("$2");
					difference -= 2;
				} else if(difference - 1 > 0) {
					Console.WriteLine("$1");
					difference -= 1;
				} else if(difference - 0.50 > 0) {
					Console.WriteLine("$0.50");
					difference -= 0.50f;
				} else if(difference - 0.25 > 0) {
					Console.WriteLine("$0.25");
					difference -= 0.25f;
				} else if(difference - 0.10 > 0) {
					Console.WriteLine("$0.10");
					difference -= 0.10f;
				} else if(difference - 0.05 > 0) {
					Console.WriteLine("$0.05");
					difference -= 0.05f;
				} else if(difference - 0.01 > 0) {
					Console.WriteLine("$0.01");
					difference -= 0.01f;
				} else {
					break;
				}
			}
			Console.Read();
			
		}
	}
}
