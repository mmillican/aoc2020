<Query Kind="Program" />

void Main()
{
	var input = File.ReadAllText("C:\\_Dev\\AdventOfCode\\2020\\day02\\input.txt");
	var lines = input.Split('\n');
	
	var lineRegex = new Regex(@"(\d{0,2})\-(\d{0,2})\s(\w{1})\:\s(\w{1,})");

	var validPasswords = 0;
	foreach (var line in lines)
	{
		var parsedLine = lineRegex.Match(line);

		var letter = char.Parse(parsedLine.Groups[3].Value);
		var minOccur = Int32.Parse(parsedLine.Groups[1].Value);
		var maxOccur = Int32.Parse(parsedLine.Groups[2].Value);
		var password = parsedLine.Groups[4].Value;

		var matchingLetters = password.ToArray().Where(x => x == letter).Count();
		if (matchingLetters >= minOccur && matchingLetters <= maxOccur)
		{
			validPasswords++;
		}		
	}
	
	Console.WriteLine(string.Format("{0} passwords matched", validPasswords));
}

