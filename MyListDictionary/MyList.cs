using System;
namespace MyListDictionary
{
    class MyList<TKeys,TValues>
    {

        TKeys[] dizi1;
        TValues[] dizi2;

        //constractor : classı newlersek otamatik çalışıcak olan 
        public MyList()
        {
            dizi1 = new TKeys[0];
            dizi2 = new TValues[0];
        }


        public void Add(TKeys item1,TValues item2)
        {
            TKeys[] tempsArray1 = dizi1;
            TValues[] tempsArray2 = dizi2;
            dizi1 = new TKeys[dizi1.Length+1];
            dizi2 = new TValues[dizi2.Length+1];

            for (int i = 0; i < tempsArray1.Length; i++)
            {
                dizi1[i] = tempsArray1[i];
                dizi2[i] = tempsArray2[i];
            }

            dizi1[dizi1.Length - 1] = item1;
            dizi2[dizi2.Length - 1] = item2;
        }

        public void goster()
        {
           
                for (int i = 0; i < dizi1.Length; i++)
                {
                    Console.WriteLine(dizi1[i].ToString()+" d"+dizi2[i]);
         
                }
            
        }
        
    }
}
