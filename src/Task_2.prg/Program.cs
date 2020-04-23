using System;

namespace Task_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите четное число");
			int length = int.Parse(Console.ReadLine());
			if (length%2 != 0)
			{
				System.Environment.FailFast("число не является чётным");//вывод ошибки в результате ввода нечётного числа
			}
			for(int i = 1; i <= length; i++)
			{
				for(int j = i; j <= length; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
