// Select many-
// It is used to project each element of a sequence to an IEnumerable<T> and flattens the resulting sequences into one sequence. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinqExamples
{

	class Bouquet
	{
		public List<string> Flowers { get; set; }
	}
	class myclass
	{
		static void Main(string[] args)
		{

			List<Bouquet> bouquets = new List<Bouquet>();
			bouquets.Add(new Bouquet { Flowers = new List<string>() { "sunflower", "daisy", "daffodil", "larkspur" } });
			bouquets.Add(new Bouquet { Flowers = new List<string> { "tulip", "rose", "orchid" } });
			bouquets.Add(new Bouquet { Flowers = new List<string> { "gladiolis", "lily", "snapdragon", "aster", "protea" } });
			bouquets.Add(new Bouquet { Flowers = new List<string> { "larkspur", "lilac", "iris", "dahlia" } });

			var result1 = bouquets.Select(f => f.Flowers);
			// Above var is IEnumerable<List<string>> type which contains the list of floweres stored into List bouquets....
			// select only project the items of one list 



			var result2 = bouquets.SelectMany(f => f.Flowers);
			// here we have used SelectMany which retrieves every element from all the list of flowers hence here var represent the IEnumerable<string> only..


			// now see the difference of calling all values from both the result..
			Console.WriteLine("------------------------Result of Select --------------------------------------");
			foreach (var r in result1)
			{
				foreach (var s in r)
					Console.WriteLine(s);
			}

			Console.WriteLine("-------------------------Result of SelectMany------------------------------------");
			foreach (var r in result2)
				Console.WriteLine(r);
		}
	}
}
