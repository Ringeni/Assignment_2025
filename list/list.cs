using System;
public class GenericLinkedList<T>
{
    private Node<T> head;
    private class Node<T>
    {
        public T Data{get;set;}
        public Node<T>Next{get;set;}
        public Node(T data)
        {
            Data=data;
            Next=null;
        }
    }
    public void Add(T data)
    {
        Node<T> newNode=new Node<T>(data);
        if(head==null) head=newNode;
        else
        {
            Node<T> current=head;
            while(current.Next!=null) current=current.Next;
            current.Next=newNode;
        }
    }
    public void ForEach(Action<T> action)
    {
        Node<T> current=head;
        while(current!=null)
        {
            action(current.Data);
            current=current.Next;
        }
    }
}
class Program
{
    static void Main()
    {
        GenericLinkedList<int> list=new GenericLinkedList<int>();
        list.Add(3);
        list.Add(5);
        list.Add(1);
        Console.WriteLine("链表元素:");
        list.ForEach(x=>Console.WriteLine(x));
        int sum=0;
        list.ForEach(x=>sum+=x);
        Console.WriteLine($"总和:{sum}");
        int max=int.MinValue;
        list.ForEach(x=>{if(x>max)max=x;});
        Console.WriteLine($"最大值:{max}");
        int min=int.MaxValue;
        list.ForEach(x=>{if(x<min)min=x;});
        Console.WriteLine($"最小值:{min}");
    }
}