using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList;
        public int  Count { get; private set; }
        public int Capacity => InnerList.Length;

        public Array()
        {
            InnerList = new T[2];
            Count = 0;
        }

        public Array(params T[] initial)
        {
            InnerList = new T[initial.Length];
            Count = 0;
            foreach (var item in initial)
            {
                Add(item);
            }
        }

        //public Array( IEnumarable<T> collection)
        //{
        //    InnerList = new T[collection.ToArray().Length];
        //    Count = 0;
        //    foreach(var item in collection)
        //    {
        //        Add((T)item);
        //    }
        //}
        // eleman ekleme işlemi 
        public void Add(T item) 
        {
            // overflow capacity hatasını düzeltmek için
            if(InnerList.Length == Count)
                DoubleArray();
            
            InnerList[Count] = item;
            Count++;
        }

        private void DoubleArray()
        {   // bu fonksiyonla capastiyi değiştirebilirz
            var temp = new T[InnerList.Length*2];
            // innerlist ifademiz immutable olduğu için lenghtini değiştirmek için iki şekilde işlem yapabiliriz
            /*
             * for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = InnerList[i];
                }
            dizinin gözlerine sırayla kopyalama işlemi yaparız bu for döngüsüyle
             */

            // ya da bu for döngüsü yerine sistem üzerindeki array sınıfının copy methodunu kullanabilirz.
            // source destination ve ne kadar kopyalama yapılacağının bilgisni verdiğimizde kopyalamay yapabiliriz.
            System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;
        }
        public T Remove()
        {
            if(Count == 0)
            {
                throw new Exception("there is no more item to removed from the array");
            }

            if(InnerList.Length/4 == Count) 
            {
                HalfArray();        
            }
            var temp = InnerList[Count-1];
            if (Count > 0)
            {
                Count--;
            }
            
            return temp;
        }

        private void HalfArray()
        {
            //yarıya indirebilmemiz için dizinin boyutunun her zaman ikinin üstünde olması gerekir
            if(InnerList.Length>2)
            {
                var temp = new T[InnerList.Length / 2];
                System.Array.Copy(InnerList, temp, temp.Length);
                InnerList = temp;
            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InnerList.Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
    }
}
