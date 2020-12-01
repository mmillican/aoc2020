<Query Kind="Program" />

void Main()
{
	var input = File.ReadAllText("C:\\_Dev\\AdventOfCode\\2020\\day01\\input.txt");
	var numbers = input.Split('\n').Select(x => Convert.ToInt32(x));
	
	var result = 0;
	foreach(var x in numbers)
	{
		foreach(var y in numbers)
		{
			if (x + y == 2020)
			{
				result = x * y;
				break;
			}
		}
	}
	
	result.Dump();	
}

// Define other methods and classes here
