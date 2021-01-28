using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class LinkedList : ILinkedList
    {
        public  Node _startNode { get; set; }
        public Node _endNode { get; set; }
        public int _count { get; set; }

        public void AddNode(int value)
        {
           if (_startNode==null)
            {
                _startNode = new Node { Value = value };
                _endNode = _startNode;
            }
           else
           {
                _endNode.NextItem = new Node { Value = value };
                _endNode.NextItem.PrevItem = _endNode;
                _endNode = _endNode.NextItem;
            }
            _count++;
        }
        public LinkedList(params int[] list) : this()
        {
            int countList = 0;
            while (countList < list.Length)
            {
                AddNode(list[countList]);
                countList++;
            }
        }
        public LinkedList(int value) : this()
        {
            AddNode(value);
        }
        public LinkedList()
        {
            _startNode = null;
            _endNode = null;
            _count = 0;
        }
        public void AddNodeAfter(Node node, int value)
        {
            if (node.NextItem != null)
            {
                var newNode = new Node { Value = value };
                var oldNextItem = node.NextItem;
                var oldPrevItem = node;
                newNode.PrevItem = oldPrevItem;
                newNode.NextItem = oldNextItem;

                oldNextItem.PrevItem = newNode;
                oldPrevItem.NextItem = newNode;

                _count++;
            }
            else AddNode(value);
        }


        public Node FindNode(int searchValue)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            return _count;
        }

        public void RemoveNode(int index)
        {
            if ( index == 1 )
            {
                RemoveNode(_startNode);
            }
            else if (index == _count)
            {
                RemoveNode(_endNode);
            }
            else
            {
                Node node = _startNode.NextItem;
                for (int j=2; j<index; j++)
                {
                  node = node.NextItem;
                }
                RemoveNode(node);
            }


        }

        public void RemoveNode(Node node)
        {
            if (node == _startNode)
            {
                _startNode = _startNode.NextItem;
                _startNode.PrevItem = null;
            }
            else if (node == _endNode)
            {
                _endNode = _endNode.PrevItem;
                _endNode.NextItem = null;
            }
            else
            {
                node.PrevItem.NextItem= node.NextItem;
                node.NextItem.PrevItem = node.PrevItem;
            }
            _count--;
        }
        public int GetValue(Node startNode, int itemIndex)
        {
               
            int currentIndex = 0;
            var currentNode = startNode;
            while (currentNode != null)
            {
                if (currentIndex == itemIndex - 1)
                {
                    return currentNode.Value;
            
                }
                currentNode = currentNode.NextItem;
                currentIndex++;
            }
            return -1;
        }
        public void PrintList(Node node)
        {
            Console.WriteLine($"Элемент списка\t\tЗначение\n" + $"==================================");
            for (int j = 0; j < _count; j++) Console.WriteLine($"\t({j})\t\t{GetValue(node,j)}");
        }
        public void Print()
        {
            Node CurrentNode = _startNode;
            int i = 0;
            Console.WriteLine($"Элемент списка\t\tЗначение\n" + $"==================================");
            while  (CurrentNode != null)
            {
                i++;
                Console.Write('\t');
                Console.Write(i);
                Console.Write('\t');
                Console.Write('\t');
                Console.Write(CurrentNode.Value);
                Console.WriteLine();
                CurrentNode = CurrentNode.NextItem;
            }
            
        }
        public bool Equals(LinkedList linkedList)
        {
            var actualNode = _startNode;
            var expectedNode = linkedList._startNode;
            if (_count != linkedList._count) return false;
            while (actualNode != null)
            {
                if (actualNode.Equals(expectedNode))
                {
                    return false;
                }
                actualNode = actualNode.NextItem;
                expectedNode = expectedNode.NextItem;
            }
            return true;
        }
        public bool Equals(int[] expectedArray)
        {
            var actualNode = _startNode;
            if (_count != expectedArray.Length)
            {
                return false;
            }
            foreach (int val in expectedArray)
            {
                if (actualNode.Value != val)
                {
                    return false;
                }
                actualNode = actualNode.NextItem;
            }
            return true;
        }
    }
}
