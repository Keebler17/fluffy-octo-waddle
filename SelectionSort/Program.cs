using System;

namespace SelectionSort {
	class Program {
		static void Main(string[] args) {
			int[] list = { 51, 22, 99, 83, 42, 4, 7, 22, 46, 83, 22, 79, 36, 38, 91, 128 };
			int swap;
			int min;
			Console.Write("Unsorted list: ");
			for (int i = 0; i < list.Length; i++) {
				Console.Write(list[i] + " ");	
			}
			Console.WriteLine("\nSorting...");
			int j = 0;
			for (int i = 0; i < list.Length; i++) {
				min = i;
				for (j = i; j < list.Length; j++) {
					if(list[j] < list[min] ) {
						min = j;
					}
				}

				swap = list[i];
				list[i] = list[min];
				list[min] = swap;

				for (int k = 0; k < list.Length; k++) {
					Console.Write(list[k] + " ");
				}
				Console.WriteLine();
			}


			Console.Write("\nSorted list: ");
			for (int k = 0; k < list.Length; k++) {
				Console.Write(list[k] + " ");
			}

			Console.Read();
		}
	}
}
