// The string.Intern method optimizes string memory and performance. It allows you to put strings in the runtime�s shared string pool.
using System;

static void Sample()
{
    string n = 'tests';
    Console.WriteLine(string.Intern(n));
}
