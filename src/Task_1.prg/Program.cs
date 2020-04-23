using System;

namespace Task_1
{
	class Program
	{
		static void Main(string[] args)
		{
			try//пытаемся поймать искключение 
			{
				Console.WriteLine("Введите возраст");//сообщение пользователю
				byte age = Convert.ToByte(Console.ReadLine());//ввод возраста
				int n = age % 10;//далее определение формы слова "год","лет","года"
				if(11 <= age & age <= 20)
				{
					Console.WriteLine("Мне {0} лет", age);
				}
				else if(n == 1)
				{
					Console.WriteLine("Мне {0} год", age);
				}
				else if(2 <= n & n <= 4)
				{
					Console.WriteLine("Мне {0} года", age);
				}
				else if(n >= 5 & n <= 9 | n == 0)
				{
					Console.WriteLine("Мне {0} лет", age);
				}
			}
			catch
			{
				Console.WriteLine("Неверно введен возраст!!!");//вывод в результате выявления исключения 
			}


		}
	}
}
