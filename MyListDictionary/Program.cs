using System;

namespace MyListDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> isimler = new MyList<int, string>();
            isimler.Add(6,"Damla");
            isimler.Add(2,"Hakan");

            isimler.goster();
        }
    }
}
