// Take method returns a specified number of elements from the start of the collection. The number of items to return is specified using the count parameter this method expects.

// Skip method skips a specified number of elements in a collection and then returns the remaining elements. The number of items to skip is specified using the count parameter this method expects. 

// Please Note: For the same argument value, the Skip method returns all of the items that the Take method would not return.

// TakeWhile method returns elements from a collection as long as the given condition specified by the predicate is true. 

// SkipWhile method skips elements in a collection as long as the given condition specified by the predicate is true, and then returns the remaining elements.

string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
IEnumerable<string> result = countries.Take(3);
foreach (string country in result)
{
	Console.WriteLine(country);
}

// or

string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
IEnumerable<string> result = (from country in countries
							  select country).Take(3);
foreach (string country in result)
{
	Console.WriteLine(country);
}

string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
IEnumerable<string> result = countries.Skip(3);
foreach (string country in result)
{
	Console.WriteLine(country);
}

string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
IEnumerable<string> result = countries.TakeWhile(s => s.Length > 2);
foreach (string country in result)
{
	Console.WriteLine(country);
}

string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
IEnumerable<string> result = countries.SkipWhile(s => s.Length > 2);

foreach (string country in result)
{
	Console.WriteLine(country);
}

