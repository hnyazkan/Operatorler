using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("****Atama ve İşlemli Atama Operatörleri****");
           //Atama ve İşlemli Atama
           int x = 5;
           int y = 5;
           y = y+2;
           Console.WriteLine(y);
           y += 2;
           Console.WriteLine(y);
           y /= 1;
           Console.WriteLine(y);

           x *= 2;
           Console.WriteLine(x);

           Console.WriteLine("****Mantıksal Operatörler****");
           //Mantıksal Operatörler
           // &&, ||, !
           bool isSuccess = true;
           bool isCompleted = false;

           if(isSuccess && isCompleted)
             Console.WriteLine("Perfect!");

           if(isSuccess || isCompleted)
             Console.WriteLine("Great!");

           
           if(isSuccess && !isCompleted)
             Console.WriteLine("Fine!");

           Console.WriteLine("****İlişkisel Operatörler****");
            //ilişkisel operatörler
            //<, >, <=, >=, ==, !=

            int a = 4;
            int b = 5;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("****Aritmetik Operatörler****");
            //Aritmetik operatörler
            // /, *, +, -

            int sayı1 = 20;
            int sayı2 = 10;
            int sonuc1 = sayı1/sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1*sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1+sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1-sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = ++sayı1;
            Console.WriteLine(sonuc1);

            // % mod almak
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);


           





           
        }
    }
}
