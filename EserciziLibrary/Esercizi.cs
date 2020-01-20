using System;

namespace EserciziLibrary
{
    public class Esercizi
    {
        public static long CalcolaFattoriale(long n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * CalcolaFattoriale(n - 1);
        }
        public static int CalcolaMax(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c && b > a)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
         public static int CalcolaMin(int a,int b,int c)
         {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < c && b < a)
            {
                return b;
            }
            else
            {
                return c;
            }
         }
        public static double CalcolInverso(double d)
        {
            return 1 / d;
        }
    }
}
