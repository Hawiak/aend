using System;
using System.Collections;
using System.Linq;

namespace AenD
{

    public class SingleLinkedList<T> : ISingleLinkedList<T>, IEnumerable
    {
        private Node<T> Head;
        private Node<T> Tail;
        public int Count { get; private set; }


        public SingleLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Add(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException();
            }
            Node<T> nodeToAdd = null;
            if (Count == 0)
            {
                nodeToAdd = new Node<T>(element);
                Head = nodeToAdd;
                Tail = Head;
                Count++;
                return true;
            }
            else
            {
                nodeToAdd = new Node<T>(element, Tail);
                Tail = nodeToAdd;
                Count++;
                return true;
            }
        }

        public bool Remove(T element)
        {
            Node<T> nodeBeforeFoundNode = null;
            var currentNode = Head;
            if (element == null)
            {
                return false;
            }
            if (Count == 0)
            {
                return false;
            }
            while (!Equals(currentNode.Value, element))
            {
                nodeBeforeFoundNode.NextNode = currentNode;
                currentNode = currentNode.NextNode;
            }


            if (Equals(currentNode, null))
            {
                return false;
            }

            if (currentNode == Head)
            {
                Head = currentNode.NextNode;
                Count--;
                return true;
            }
            nodeBeforeFoundNode.NextNode = currentNode.NextNode;
            Count--;
            return true;
        }



        public bool Contains(T element)
        {
            if (Count == 0)
            {
                return false;
            }
            if (element == null)
            {
                throw new ArgumentNullException();
            }
            Node<T> current = Head;
            while (!Equals(current, Tail))
            {
                current = current.NextNode;
            }
            if (Equals(current, null))
            {
                return false;
            }
            return true;
        }


        public IEnumerator GetEnumerator()
        {
            var node = Head;
            while (node != null)
            {
                yield return node.Value;
                node = node.NextNode;
            }
        }

        public override string ToString()
        {
            string returnString = "";

            foreach (T item in this)
            {
                returnString = returnString + item.ToString() + "\n";
            }

            return returnString;
        }
    }
}