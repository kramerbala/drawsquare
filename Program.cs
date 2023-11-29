class Program
{
    public static void Main()
    {

        int count = int.Parse(Console.ReadLine()); //szam beolvasasa es int-e alakitas
        char op = char.Parse(Console.ReadLine()); //karakter beolvasasa es char-a alakitas
        
        DrawSquare(count, op); //fuggvenhivas a szam es a karakter parameterrel

        Console.ReadLine();
    }

    public static void DrawSquare(int sideLength, char character) //fuggveny deklaracio int char tipusu parameterekkel
    {
        for (int i = 0; i < sideLength; i++) // for ciklus a sorokhoz -> i.sor
        {
            for (int j = 0; j < sideLength; j++) // for ciklus az oszlopokhoz -> j.oszlop
            {
                if (i == 0 || i == sideLength - 1 || j == 0 || j == sideLength - 1) // ha i == 0 (legfelso sor) vagy i == sideLength - 1 (legalso sor) vagy j == 0 (bal oldal) vagy j == sideLength - 1 (jobb oldal)
                {
                    Console.Write(character); // karakter kiirasa
                }
                else
                {
                    Console.Write(" "); // szokoz kiirasa
                }
            }
            Console.WriteLine(); // uj sor, hiszen az adott sor osszes oszlopat kiirtuk (j nem < sideLength (for loop a 16. sorban))
        }
    }
}

