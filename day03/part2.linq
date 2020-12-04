<Query Kind="Program" />

void Main()
{
	var input = File.ReadAllText("C:\\_Dev\\AdventOfCode\\2020\\day03\\input.txt");
	var lines = input.Split('\n');

	Int64 allSlopesCount = Compute(lines, 1, 1)
		* Compute(lines, 3, 1)
		* Compute(lines, 5, 1)
		* Compute(lines, 7, 1)
		* Compute(lines, 1, 2);	
	
	Console.WriteLine("{0} trees", allSlopesCount);
}

Int64 Compute(string[] lines, int xMove, int yMove)
{
	var x = 0;
	var y = 0;
	Int64 count = 0;

	x += xMove;
	x %= lines[0].Length - 1;
	y += yMove;

	while (y < lines.Length)
	{
		if (lines[y][x] == '#')
		{
			count += 1;
		}

		x += xMove;
		x %= lines[0].Length - 1;
		y += yMove;
	}

	Console.WriteLine("Slope count {0}", count);
	return count;
}

