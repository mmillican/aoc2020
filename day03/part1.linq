<Query Kind="Program" />

void Main()
{
	var input = File.ReadAllText("C:\\_Dev\\AdventOfCode\\2020\\day03\\input.txt");
	var lines = input.Split('\n');
	
	var x = 0;
	var y = 0;
	var count = 0;
	
	x += 3;
	x %= lines[0].Length - 1;
	y += 1;
	
	while (y < lines.Length)
	{
		if (lines[y][x] == '#')
		{
			count += 1;
		}

		Console.WriteLine("{0}, {1} -> {2}", y, x, lines[y][x]);
		
		x += 3;
		x %= lines[0].Length - 1;
		y += 1;
	}
	
	Console.WriteLine("{0} trees", count);
}

