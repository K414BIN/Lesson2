using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
  public sealed  class Node
    {
        public int Value { get; set; }
        public Node PrevItem { get; set; }
        public Node NextItem { get; set; }
    }
}
