using System;

namespace MultiplicationTable
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter Table value: ");
			int tab = Int32.Parse (Console.ReadLine ());
			Console.Write ("Enter the Number of lines you want: ");
			int lim = Int32.Parse (Console.ReadLine ());


			Table t = new Table ();


			// possible to change "step" value 
			// Ex: 0.5 incriment each time
			// make variable in class as double 

			t.printTable (tab, lim);

		}
	}
}


public class Table
{
	public void printTable(int table, int limit, int step=1)
	{

		Console.Clear ();
		Console.WriteLine ("Here is the table: ");

		for (int i = 1; i <= limit; i += step) {
			Console.WriteLine ("{0} x {1} = {2}",table,i,table*i);
		}
	}
}