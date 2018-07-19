using System;

namespace BubbleSort {
	class Program {
		static void Main(string[] args) {
			int[] list = { 51, 22, 99, 83, 42, 4, 7, 22, 46, 83, 22, 79, 36, 38, 91, 128 };
			int swap;
			Console.Write("Unsorted list: ");
			for(int i = 0; i < list.Length; i++) {
				Console.Write(list[i] + " ");
			}
			Console.WriteLine("\nSorting...");

			for(int i = 0; i < list.Length; i++) {
				for (int j = 0; j < list.Length-1; j++) {
					if(list[j] > list[j+1]) {
						swap = list[j + 1];
						list[j + 1] = list[j];
						list[j] = swap;
						
						for (int k = 0; k < list.Length; k++) {
							Console.Write(list[k] + " ");
						}
						Console.WriteLine();
					}
				}
			}


			Console.Write("\nSorted list: ");
			for (int k = 0; k < list.Length; k++) {
				Console.Write(list[k] + " ");
			}

			Console.Read();
		}
	}
}
