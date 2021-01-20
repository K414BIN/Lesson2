using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bsearch.BiSearch(); // запуск бинарного поиска - оформил отдельным классом
            var linkedList = new LinkedList();
            var startNode = new Node() { Value = 99 };// создание 
            linkedList.AddNode( 55);// должно создавать и добавлять, но ничего не происходит
            linkedList.AddNodeAfter(startNode, 11);// не добавляет ! Почему не понял
            linkedList.AddNodeAfter(startNode, 12); // добавляет
            linkedList.AddNodeAfter(startNode, 26); // дбавляет 
            linkedList.AddNodeAfter(startNode, 27); // дбавляет 
            Console.WriteLine();
            linkedList.PrintList(startNode); ;// выводит на экран список
            linkedList.RemoveNode(startNode); // убирает
            Console.WriteLine();
            linkedList.PrintList(startNode);// выводит на экран список
            Console.ReadLine();
         }
        
    }
}
