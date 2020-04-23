using System;

namespace Task_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Вввдите длину массива");
			int length = int.Parse(Console.ReadLine());
			int[] array = new int[length];
			Random rnd = new Random();
			int chet = 0;//вводим переменную для чётных элементов
			int nechet = 0;//вводим переменную для нечётных элементов
			for(int i = 0; i < length; i++)//далле создаем массив указанной длины, заполненный случайными числами
			{
				array[i] = rnd.Next();
			}
			foreach(int i in array)
			{
				if (i % 2 == 0)//выявляем чётные элементы
				{
					chet++;
				}
				else//выявляем нечетеные элементы
				{
					nechet++;
				}
			}
			Console.WriteLine("Количетсво чётных элементов:{0}", chet);
			Console.WriteLine("Количество нечётных элементов:{0}", nechet);
		}
	}
}
