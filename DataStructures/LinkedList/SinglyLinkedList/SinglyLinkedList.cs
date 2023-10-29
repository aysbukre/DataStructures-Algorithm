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
        private bool isHeadNull => Head == null;
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

        /*
        public  void AddLast (T value) 
        { 
            var newNode = new SinglyLinkedList<T>(value);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            var current = Head;
            while (current.Next!= null)
            {
                current= current.Next;
            }
            current.Next = newNode;
        }
        */
        //listenin arasına ekleme
        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            //node ifadesi bir düğümdür ve boş olamaz eğer boş olursa diye bir hata gönderiyoruz.
            if (node == null)
            {
                throw new ArgumentNullException();
                
            }
            // bu listesinin boş olmaması lazim ki başka bir düğüm eklensin bunun için de uyarı gönderiyoruz.
            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }
            //SinglyLinkedListNode<T> node burada bir referans düğümü vermem gerekiyor ismini de node yaptık
            // T sadece bir değer 
            //önce bir düğüm oluşturacağım
            var newNode = new SinglyLinkedListNode<T>((T)value);    
            var current = Head;
            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The reference node not exist");

        }

    }
}
