using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			List<List<string>> c = new List<List<string>>();
			List<int> r = new List<int>();

			c.Add(new List<string> { "html", "c#" });
			r.Add(0);
			c.Add(new List<string> { "python", "html" });
			r.Add(0);
			c.Add(new List<string> { "html", "c#" });
			r.Add(1);
            TournamentWinner(c, r);



        }
		public static string TournamentWinner(List<List<string>> competitions, List<int> results)
		{
			Dictionary<string, int> winner = new Dictionary<string, int>();
			int value = 0;
			int index = 0;

			foreach (int item in results)
			{
				if (item == 1)
				{
					string teamName = competitions[index][0];
					value += 3;
					winner.Add(teamName, value);
				}
				else if (item == 0)
				{
					string teamName = competitions[index][1];
					value += 3;
					winner.Add(teamName, value);
				}
				index++;
			}
			return "fuck";
		}

		//public static string TournamentWinner(List<List<string>> competitions, List<int> results)
		//{

		//	int __home__ = 0, __away__ = 1, __hometeamwin__ = 1;

		//	Dictionary<string, int> winners = new Dictionary<string, int>();

		//	int matchNum = 0;

		//	foreach (List<string> tmpMatch in competitions)
		//	{

		//		string home = tmpMatch[__home__], away = tmpMatch[__away__];

		//		if (!winners.ContainsKey(home))
		//		{
		//			winners.Add(home, 0);
		//		}
		//		if (!winners.ContainsKey(tmpMatch[__away__]))
		//		{
		//			winners.Add(away, 0);
		//		}

		//		if (results[matchNum] == __hometeamwin__)
		//		{
		//			winners[home] += 3;
		//		}
		//		else
		//		{
		//			winners[away] += 3;
		//		}
		//		matchNum++;
		//	}

		//	string maxWinner = 
		//	foreach(KeyValuePair<string, int> entry in winners)
		//          {

		//          }

		//}
	}
}
