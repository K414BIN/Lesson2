using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class LinkedList : ILinkedList
    {
        private Node _startNode;
        private Node _endNode;
        private int _count;

        public void AddNode(int value)
        {
           if (_startNode==null)
            {
                _startNode = new Node { Value = value };
                _endNode = _startNode;
            }
            _count++;
        } 
 
        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node { Value = value };
            var nextItem = node.NextItem;
            node.NextItem = newNode;
            newNode.NextItem = nextItem;
            _count++;
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
            throw new NotImplementedException();
        }

        public void RemoveNode(Node node)
        {
            if (node.NextItem == null) return;

            var nextItem = node.NextItem.NextItem;
            node.NextItem = nextItem;
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
    }
}
