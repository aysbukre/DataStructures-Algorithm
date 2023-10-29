using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }
        // liste başına ekleme işlemi
        // algoritma yeni node'un pointerını mevcut head'i işaret edecek şekilde güncellenir
        //yani yeni node head olarak işaretlenir. bir tane yeni düğüm tasarımı oluşturulacak.
        //daha sonra pointer güncellenecek sonra da new node head olarak işaretlenecek.
        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }
        //liste sonuna ekleme işlemi

        public  void AddLast (T value) 
        { 
            var newNode = new SinglyLinkedList<T>(value);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            var current = Head;
            while (current != null)
            {
                current= current.Next;
            }
            current.Next = newNode;
        }
    }
}
