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

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
