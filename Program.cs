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
            Console.WriteLine();
            var linkedList = new LinkedList();
            var startNode = new Node() { Value = 99 };// создание 
            linkedList.AddNode( 55);// должно создавать и добавлять, но ничего не происходит
            linkedList.AddNodeAfter(startNode, 11);//  добавляет
            linkedList.AddNodeAfter(startNode, 12); // добавляет
            linkedList.AddNodeAfter(startNode, 26); // дбавляет 
            linkedList.AddNodeAfter(startNode, 27); // дбавляет 
            linkedList.AddNode(76);
            linkedList.Print();
            linkedList.RemoveNode(2);
            // linkedList.PrintList(startNode); ;// выводит на экран список
            // linkedList.RemoveNode(startNode); // убирает
            Console.WriteLine();
            linkedList.Print();
            Console.ReadLine();
         }
        
    }
}
