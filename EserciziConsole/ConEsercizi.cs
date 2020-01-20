using System;
using EserciziLibrary;

namespace EserciziConsole
{
    class ConEsercizi
    {
        static void Main(string[] args)
        {
            int n = 0;
            long fattoriale = 0; 
            int a = 0;
            int b = 0;
            int c = 0;
            double d = 0;
            double inverso = 0;
            int max = 0;
            int min = 0;
            Console.WriteLine("Inserisci un numero per calcolare il fattoriale");
            n = int.Parse(Console.ReadLine());
            fattoriale = Esercizi.CalcolaFattoriale(n);


            Console.WriteLine("Inserisci un numero per calcolare il massimo");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            max = Esercizi.CalcolaMax(a,b,c);


            Console.WriteLine("Inserisci un numero per calcolare il Minimo");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            min = Esercizi.CalcolaMin(a,b,c);


            Console.WriteLine("Inserisci un numero per calcolare l'Inverso");
            d = double.Parse(Console.ReadLine());
            inverso = Esercizi.CalcolInverso(d);
        }
    }
}
