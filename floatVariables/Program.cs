using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floatVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float sayi;
            //sayi = 445.57f;
            //Console.WriteLine(sayi);

            //Console.Read();

            float s1, s2, sum;
            Console.WriteLine("Lütfen bir sayi giriniz : ");
            s1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı girin : ");
            s2 = float.Parse(Console.ReadLine());
            sum = s1 + s2;
            Console.WriteLine("Toplam : " + sum);
            Console.Read();
        }
    }
}
