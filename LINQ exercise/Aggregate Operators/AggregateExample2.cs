using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{



	class Program
	{

		public static void Main()
		{
			string sentence = "I am proud to be an Indian";

			string[] words = sentence.Split(' ');

			string newsentence = words.Aggregate((w1, w2) => w2 + "-" + w1);

			Console.WriteLine(newsentence);
		}

	}
}

// o/p-
// Indian-an-be-to-proud-am-I
