using System;
using System.Linq;

namespace MinhHoa_LinQ
{

    public delegate void In(string message);
    class Program
    {
        static void Main(string[] args)
        {
            ////    int[] a = { 3, 4, 5, 7, 14, 9, 25, 11, 18 };
            ////    //truy van cac phan tu chan cua mang a
            ////    //c1.Query syntax
            ////    //var b = from x in a where x % 2==0 select x;

            ////    //c2.Method syntax
            ////    var b = a.Where(x => x%2==0);

            ////    //xuat b
            ////    Console.WriteLine("Phan tu chan:");
            ////    foreach (var x in b)
            ////    {
            ////        Console.Write(x + " ");
            ////---dinh nghia ham myFunction----------

            ////In myFunction = delegate (string message)
            ////{
            ////    Console.WriteLine(message);
            ////};

            //In myFunction = (message) => Console.WriteLine(message);



            //In yourFunction = (message) =>
            //{
            //    Console.WriteLine(message);
            //    Console.WriteLine("Goodbye");
            //};

            //myFunction("Hello World");
            //yourFunction("Hello Word");

            //Console.ReadLine();

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //lay 5 phan tu dau tien
            var x = a.Skip(0).Take(5);
            //lay 5 phan tu ke tiep 
            var y = a.Skip(5).Take(5);
            //lay 5 phan tu ke tiep 
            var z = a.Skip(10).Take(5);          
          
            Console.ReadLine();

        }


        }
  
}
