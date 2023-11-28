class Program
{
    static void Main()
    {

        int count = int.Parse(Console.ReadLine());
        char op = char.Parse(Console.ReadLine());
        
        DrawSquare(count, op);
    }

    static void DrawSquare(int sideLength, char character)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                if (i == 0 || i == sideLength - 1 || j == 0 || j == sideLength - 1)
                {
                    Console.Write(character);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
