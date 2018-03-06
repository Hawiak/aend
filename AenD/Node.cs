using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AenD
{
    class Node<T>
    {
        public T Value { get; private set; }
        public Node<T> NextNode { get; set; }
        public Node(T element)
        {
            Value = element;
            NextNode = null;
        }
        public Node(T element, Node<T> previousNode) : this(element)
        {
            previousNode.NextNode = this;
            NextNode = null;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
