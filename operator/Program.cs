using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //atama ve işlemli atama
           int x=3;
           int y=4;
           int z=x+y;
           Console.WriteLine("z nin değer "+z);

           z+=4;
           Console.WriteLine("z nin yeni değeri"+z);
           //mantıksal operaotrler
           // || veya && ve ! değil
           bool isSucces=true;
           bool isCompleted=false;


        if(isSucces && isCompleted)
            Console.WriteLine("çok iyi");
        //ilişkisel ifadeler
        //<, >, >=, ==, !=

        int a =3;
        int b =4;

        if(a<b)
            Console.WriteLine("küçük");
        else
            Console.WriteLine("büyük");

        //ilişkisel operator
        // *, /i &,

        int g=4;
        int s=2;
        int sonuc=a&b;
        Console.WriteLine("sonuc"+sonuc);
        // mod alma
        // %

        
        }

    }
}