using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Вариант с рекурсией
namespace Lesson2
{
	public sealed class Bsearch
	{
	//	static void Main(string[] args)
        public static void BiSearch()
		{
		    var rand = new Random();// Подключение генератора случайных чисел
			Console.Write("Введите целое число - это количество элементов в массиве: ");
			int n =  Convert.ToInt32(Console.ReadLine());
			n = Math.Abs(n); // только положительные числа
			if (n<3) n=3; // избежать StackOverflowException
			int[] arr = new int[n];
			int x = Math.Abs(rand.Next(n)-1); // Случайное число для поиска 
			for (int j=0;j<arr.Length; j++) arr[j] = rand.Next(89)+10; // заполнение случайными целыми числами массив, cocтоящими из двух цифр
			Array.Sort(arr);// обязательное условие - это отсортированный массив
			Console.WriteLine();
			Console.WriteLine("Будем искать число "+arr[x]+" в числовом массиве из " + n+" чисел.");
			Console.WriteLine();
			for (int j=0;j<arr.Length; j++) 
			{
				Console.Write(arr[j]);
				Console.Write(" ");
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.Write("Искомое число это "+(BinarySearch(arr,arr[ x],0, n-1) + 1) +" элемент массива.");
			Console.WriteLine();
		//	Console.ReadLine();
		}
	// Мой расчет бинарной сортировки O(log n)
	public static int BinarySearch(int[] inputArray, int searchValue,int begin, int end)
	{
		int middle  = ( begin + end) / 2;
		if ( searchValue > inputArray[middle] ) return BinarySearch( inputArray,searchValue,middle,end);
		if ( searchValue < inputArray[middle] ) return BinarySearch( inputArray,searchValue,begin,middle);
		return middle;
	}
	}
}
