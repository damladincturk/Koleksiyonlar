using System;
namespace GenericsIntro
{
    class MyList<TKey,TValue>
    {
        TKey[] items;
        TValue[] items2;

        public MyList() {

            items = new TKey[0];
            items2 = new TValue[0];

        }

        internal void Add(string v)
        {
            throw new NotImplementedException();
        }

        public void Add(TKey item,TValue item2) {

            TKey[] tempsArray1 = items;
            TValue[] tempsArray2 = items2;
            items = new TKey[items.Length + 1];
            items2 = new TValue[items2.Length + 1];

            for (int i = 0; i < tempsArray1.Length; i++)
            {
                items[i] = tempsArray1[i];
                items2[i] = tempsArray2[i];
            }

            items[items.Length - 1] = item;
            items2[items2.Length - 1] = item2;

        }

        public int Lenght
        {

            get { return items.Length; }
           
        }
        public int Lenght2
        {

            get { return items2.Length; }

        }
    }
}
