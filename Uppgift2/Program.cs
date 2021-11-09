using System;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många ord vill du ha i din mening?(1-5 ord)");
            string strNr = Console.ReadLine();
            int tal = int.Parse(strNr);
            if(tal==1)
            Console.WriteLine("Skriv en mening med 1 ord där ordet får innehålla 10 bokstäver med bokstäverna a-z");
            if (tal==2)
            Console.WriteLine("Skriv en mening med 2 ord där orden får innehålla 10 bokstäver var med bokstäverna a-z");
            if (tal==3)
            Console.WriteLine("Skriv en mening med 3 ord där orden får innehålla 10 bokstäver var med bokstäverna a-z");
            if (tal==4)
            Console.WriteLine("Skriv en mening med 4 ord där orden får innehålla 10 bokstäver var med bokstäverna a-z");
            if (tal==5)
            Console.WriteLine("Skriv en mening med 5 ord där orden får innehålla 10 bokstäver var med bokstäverna a-z");
            if (tal>5)
            Console.WriteLine("Max antal ord är 5 ditt pucko. Starta om och försök igen");
            if (tal<1)
            Console.WriteLine("Minst antal ord är 1 ditt pucko. Starta om och försök igen");
            string mening;
            if (tal==1)
            mening = Console.ReadLine();
            if (tal==2)
            mening = Console.ReadLine();
            if (tal==3)
            mening = Console.ReadLine();
            if (tal==4)
            mening = Console.ReadLine();
            if (tal==5)
            mening = Console.ReadLine();
            Console.WriteLine("هَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَهَ");
        }
    }
}
