using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int number1, int number2)
        {
            int toplam = number1 + number2;
            Console.WriteLine("Sonuc: " + toplam);
        }
        public void Cikar(int number1, int number2)
        {
            int cikarma = number1 - number2;
            Console.WriteLine("Sonuc: " + cikarma);
        }
        public void Carp(int number1, int number2)
        {
            int carpma = number1 * number2;
            Console.WriteLine("Sonuc: " + carpma);
        }
    }
}
