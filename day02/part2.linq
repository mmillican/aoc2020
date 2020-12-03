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
		var firstPos = Int32.Parse(parsedLine.Groups[1].Value);
		var secondPos = Int32.Parse(parsedLine.Groups[2].Value);
		var password = parsedLine.Groups[4].Value;

		var passwordLetters = password.ToArray();
		var firstLetter = password[firstPos - 1];
		var secondLetter = password[secondPos - 1];
		
		if ((firstLetter == letter && secondLetter != letter) || (firstLetter != letter && secondLetter == letter))
		{
			validPasswords++;
		}
	}
	
	Console.WriteLine(string.Format("{0} passwords matched", validPasswords));
}

