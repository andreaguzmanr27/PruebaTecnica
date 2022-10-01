using System;

public class Test3{

public static bool sort(int []arr)
{
  Array.Sort(arr);
	return true;
}
	public static void Main(string[] args)
{
	int[] arr = new int[10];
    int i;
	int odd = 0;
	int even = 0;

	Console.Write("Input 10 elements :\n");
    for(i=0; i<10; i++)
    {
	    Console.Write("element {0} : ",i);
	    arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    int n = arr.Length;

	Console.Write("\nElements: ");
    for(i=0; i<10; i++)
    {
		sort(arr);
    Console.Write("{0}  ", arr[i]);
		if((Convert.ToDouble(arr[i] % 2)) == 0)
    {
      odd++;
    }
		else {
			even++;
		}
    }
	Console.WriteLine("\nTotal even numbers: "+ even);
	Console.WriteLine("Total odd numbers: "+ odd);
}
}
