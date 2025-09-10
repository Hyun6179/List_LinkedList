namespace _20250910
{
    class myList<T>
    {
        public int capacity { get; set; }
        public int count { get; set; }

        T[] list;


        public void Add(T item)
        {
            if (count >= capacity)
            {
                T[] newList = list;
                if (capacity == 0) capacity++;
                else capacity *= 2;
                list = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    list[i] = newList[i];
                }
            }

            list[count] = item;
            count++;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < count; i++)
            {
                if (i < count - 1) list[i] = list[i + 1];
                else count--;
            }
        }
    }

    public class Node
    {
        public Node Next;
        public Node Prev;

        public int data;
    }

    class LinkedList<T>
    {
        int count;
        Node? Head = null;
        Node? Tail = null;

        public Node Add(int item)
        {
            Node node = new Node();

            if (Head == null)
            {
                Head = node;
                Tail = node;
            }

            else
            {
                Tail.Next = node;
                node.Prev = Tail;
                Tail = node;
            }

            node.data = item;
            count++;
            return node;
        }

        public void RemoveAt(Node node)
        {
            if (node.Prev == null)
            {
                node.Next.Prev = null;
            }

            if (node.Next == null)
            {
                node.Prev.Next = null;
            }

            if (node.Prev != null)
            {
                node.Prev.Next = node.Next;
                node.Next.Prev = node.Prev;
            }

            if (node.Next != null)
            {
                node.Next.Prev = node.Prev;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            myList<int> list = new myList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            list.RemoveAt(2);

            list.Add(60);

            LinkedList<int> linked = new LinkedList<int>();
            linked.Add(1);
            linked.Add(2);
            Node node = linked.Add(3);
            linked.Add(4);
            linked.Add(5);

            linked.RemoveAt(node);
        }
    }
}

