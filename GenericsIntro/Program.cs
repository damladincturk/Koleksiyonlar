using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> isimler = new MyList<int, string>();
            isimler.Add(1,"Damla");
            isimler.Add(2, "Hakan");
            isimler.Add(3, "Emre");

           
        }
    }
}
