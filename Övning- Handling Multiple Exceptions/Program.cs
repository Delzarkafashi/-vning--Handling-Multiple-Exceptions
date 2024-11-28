using System;

class Program
{
    static void HanteraInmatningOchArrayÅtkomst(string indata, int index)
    {

        int[] nummerArray = { 1, 2, 3 };

        try
        {
            int konverteratNummer = int.Parse(indata);

            int arrayVärde = nummerArray[index];

            Console.WriteLine($"Värdet vid index {index} är: {arrayVärde}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Fel: Ogiltigt format på indata.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine($"Fel: Index {index} är utanför tillåtet intervall.");
        }
    }

    static void Main(string[] args)
    {
        KörTestfall();
    }

    static void KörTestfall()
    {
        Console.WriteLine("Testfall 1: Giltig indata");
        HanteraInmatningOchArrayÅtkomst("2", 1); 

        Console.WriteLine("\nTestfall 2: Ogiltig sträng");
        HanteraInmatningOchArrayÅtkomst("abc", 1); 

        Console.WriteLine("\nTestfall 3: Ogiltigt index");
        HanteraInmatningOchArrayÅtkomst("2", 5); 
    }
}
