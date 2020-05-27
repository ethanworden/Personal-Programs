// C# program for building Heap from Array 
using System;
using System.Collections.Generic;
using System.Linq;

public class BuildHeap
{

	// To heapify a subtree rooted with node i which is 
	// an index in arr[].Nn is size of heap 
	static void maxHeapify(int[] arr, int n, int i)
	{
		int largest = i; // Initialize largest as root 
		int l = 2 * i + 1; // left = 2*i + 1 
		int r = 2 * i + 2; // right = 2*i + 2 

		// If left child is larger than root 
		if (l < n && arr[l] > arr[largest])
			largest = l;

		// If right child is larger than largest so far 
		if (r < n && arr[r] > arr[largest])
			largest = r;

		// If largest is not root 
		if (largest != i)
		{
			int swap = arr[i];
			arr[i] = arr[largest];
			arr[largest] = swap;

			// Recursively heapify the affected sub-tree 
			maxHeapify(arr, n, largest);
		}

	}





	static void minHeapify(int[] arr, int n, int i)
		{
			int smallest = i; // Initialize largest as root 
			int l = 2 * i + 1; // left = 2*i + 1 
			int r = 2 * i + 2; // right = 2*i + 2 

			// If left child is smaller than root 
			if (l < n && arr[l] < arr[smallest])
				smallest = l;

			// If right child is smaller than smallest so far 
			if (r < n && arr[r] < arr[smallest])
				smallest = r;

			// If largest is not root 
			if (smallest != i)
			{
				int swap = arr[i];
				arr[i] = arr[smallest];
				arr[smallest] = swap;

				// Recursively heapify the affected sub-tree 
				minHeapify(arr, n, smallest);
			}
		}



		// Function to build a Max-Heap from the Array 
		static void buildMaxHeap(int[] arr, int n)
	{
		int[] test = new int[arr.Length];
		arr.CopyTo(test, 0);


		// Index of last non-leaf node 
		int startIdx = (n / 2) - 1;

		// Perform reverse level order traversal 
		// from last non-leaf node and heapify 
		// each node 
		for (int i = startIdx; i >= 0; i--)
		{
			maxHeapify(arr, n, i);
		}
		Console.Write("Max Heap ");
		printHeap(arr, arr.Length);

		Console.WriteLine("This was inplemented as a max heap: " + test.SequenceEqual(arr));
	}




	static void buildMinHeap(int[] arr, int n)
	{

		int[] test = new int[arr.Length];
		arr.CopyTo(test,0);
		

		// Index of last non-leaf node 
		int startIdx = (n / 2) - 1;

		// Perform reverse level order traversal 
		// from last non-leaf node and heapify 
		// each node 
		for (int i = startIdx; i >= 0; i--)
		{
			minHeapify(arr, n, i);
		}
		Console.Write("Min Heap ");
		printHeap(arr, arr.Length);

		Console.WriteLine("This was inplemented as a min heap: " + test.SequenceEqual(arr));

	}

	// A utility function to print the array 
	// representation of Heap 
	static void printHeap(int[] arr, int n)
	{
		Console.WriteLine("array representation is:");

		for (int i = 0; i < n; ++i)
			Console.Write(arr[i] + " ");

		Console.WriteLine();
	}

	public static void Main()
	{


		List<int> list = new List<int>();

		int i;


		Console.Write("Enter Numbers: ");
		string s = Console.ReadLine();
		var parts = s.Split(',');
		int[] heap = new int[parts.Length];


		for (i = 0; i < parts.Length; i++)
		{
			heap[i] = Convert.ToInt32(parts[i]);
			//Console.WriteLine("\n\nNumber {0} is {1}: ", i, heap[i]);
		}


		buildMinHeap(heap,heap.Length);
		buildMaxHeap(heap, heap.Length);
	}
}


