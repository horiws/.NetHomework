using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> node = this.Head;

            //traverse this list until the tail node
            while(node != null)
            {
                action(node.Data);
                node = node.Next;
            }
        }
   
    }
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int max;
            int min;

            //initialize this list
            GenericList<int> genericList = new GenericList<int> ();
            genericList.Add(2);
            genericList.Add(3);
            genericList.Add(4);
            genericList.Add(5);

            //assign this two variables with the head node's value
            max = min = genericList.Head.Data;

            Action<int> action = a =>
            {
                Console.Write(a + " ");
                sum += a;

                if(a > max) { max = a; }
                if(a < min) { min = a; }
            };
            
            genericList.ForEach(action);

            Console.WriteLine($"\nSum:{sum}, max:{max}, min:{min}");

        }
    }
}
