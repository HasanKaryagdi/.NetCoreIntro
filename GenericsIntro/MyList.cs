using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace GenericsIntro
{
    class MyList<T> // T =>Type
    {
        T[] items;
        //ctor =>Constructor : bir class newlendiğinde çalışsan bloga ctor denir
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // geçici referans ,öncekı verileri korumak için tutulur
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; 
        }
    }
}
