using System;

public class Test2 {

public static bool checkFibonacci(int []arr, int n)
{
    if (n == 1 || n == 2)
        return true;

    Array.Sort(arr);

    for(int i = 2; i < n; i++)
    {
       if ((arr[i - 1] + arr[i - 2]) != arr[i])
           return false;
    }
    return true;
}

	public static void Main(string[] args)
{
	int[] arr = new int[10];
    int i;
	Console.Write("Input 10 elements :\n");
    for(i=0; i<10; i++)
    {
	    Console.Write("element {0} : ",i);
	    arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    int n = arr.Length;

    if (checkFibonacci(arr, n))
        Console.WriteLine("Yes, it is Fibonacci");
    else
        Console.WriteLine("No, It is not Fibonacci");
}
}
