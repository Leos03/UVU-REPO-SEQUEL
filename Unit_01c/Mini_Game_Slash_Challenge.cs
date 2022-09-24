using System;

public class Program
{
	public void Main()
	{
		static void Main(string[] args)
		{
			string secretWord = "Toaster";
			string guess = "";
			int guessCount = 0;
			int guessLimit = 5;
			bool noGueses = false;
			
			while(guess ! = secretWord && noGueses)
			{
				if guessCount < guessLimit
				{
					Console.WriteLine("Insert Guess >:) : ");
					guess = Console.ReadLine();
					guessCount++;
				}
				else
				{
					noGueses = true;
				}
				
			}
			if (noGueses)
			{
				Console.WriteLine("oof...");
			}
			else
			{
				Console.WriteLine("Yays");
			}
		}
	}
}