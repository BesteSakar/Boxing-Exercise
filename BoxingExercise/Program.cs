using System;

namespace BoxingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //a değişkenime stack içerisinde bir yer ayırdık..
            // ve adresine 456 sayısını yerleştirdim..
            int a = 456;


            // boxing yaparak a değişkenimi "o" değişkenime kopyaladım.
            //burada da heap içerisinde bir nesne oluşturup,456 yı koyduk..
            //yani hem stackde hemde heap te 456 sayısını tutmuş oldum..
            object o = a;

            // a değişkenimin değerini değiştirdik..
            a = 800;

            // belleğimizde olan hem stackteki hem heap veriyi konsola yazdırdım..

            System.Console.WriteLine("Değer tipi(Value-type) değişken içeriği ={0}", a);
            System.Console.WriteLine("Değer tipi(Object-type) değişken içeriği ={0}", o);



        }
    }
}
