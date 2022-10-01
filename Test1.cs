using System;

public class Test1
{
	public static void Main()
	{
    string s;
    const int limit = 20;

    Console.Write("Ingrese el string: ");
    s = Console.ReadLine();
		int c = s.Length;

    if (c > limit)
    {
			string caracteres = s.Substring(0, 20);
			Console.WriteLine("Cadena de texto: " + caracteres + "...");
    }
    else
    {
			string caracteres2 = s.Substring(0, s.Length);
      Console.WriteLine("Cadena de texto :" + caracteres2);
    }
	}
}
