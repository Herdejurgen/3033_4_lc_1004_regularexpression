// Jack Herdejurgen 113436899
// Oct 4, 2022
// Regular Expression

using System.Text.RegularExpressions;

string testStr = "123abc456789abc. 123ABC";

// test_string = @"\n123\t";

Regex regex = new Regex(@"ab|cd{2}");

var r = regex.Matches(testStr);

Console.ReadKey();