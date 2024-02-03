namespace C_AdvancedTopics.Generics
{
    public class GenericList<T>
    {
        private class Node
        {
            public Node(T value)
            {
                next = null;
                data = value;
            }

            // T as private member data type.
            private T data;

            private Node? next;

            // T as return type of property.
            public T Data
            {
                get { return data; }
                set { data = value; }
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
        }

        private Node? head;

        public GenericList()
        {
            head = null;
        }

        public void AddHead(T item)
        {
            Node n = new Node(item);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node? current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
}
