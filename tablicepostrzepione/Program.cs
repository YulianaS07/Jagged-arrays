internal class Program
{
    private static void Main(string[] args)
    {
        char[][] jagged = ReadJaggedArrayFromStdInput();
        PrintJaggedArrayToStdOutput(jagged);
        jagged = TransposeJaggedArray(jagged);
        Console.WriteLine();
        PrintJaggedArrayToStdOutput(jagged);
    }

    static char[][] ReadJaggedArrayFromStdInput()
    {
        int nr = int.Parse(Console.ReadLine());
        char[][] tab = new char[nr][];
        for (int i = 0; i < tab.Length; i++)
        {
            string[] tabl = Console.ReadLine().Split(" ");
            tab[i] = new char[tabl.Length];
            for (int j = 0; j < tabl.Length; j++)
            {
                tab[i][j] = char.Parse(tabl[j]);
            }
        }
        return tab;
    }

    static void PrintJaggedArrayToStdOutput(char[][] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            for (int j = 0; j < tab[i].Length ; j++)
            {
                Console.Write($"{tab[i][j]} ");
            }
            Console.WriteLine();
        }
    }

    static char[][] TransposeJaggedArray(char[][] tab)
    {
        int wier = tab.Length;
        int kol = 0;
        for (int i = 0;i < wier;i++)
        {
            if (tab[i].Length > kol)
                kol = tab[i].Length;
        }
        char[][] tabTrans = new char[kol][];
        for ( int i = 0; i < kol; i++)
        {
            tabTrans[i] = new char[wier];
            for (int j = 0; j < wier; j++)
            {
                if (i < tab[j].Length)
                    tabTrans[i][j] = tab[j][i];
                else
                    tabTrans[i][j] = ' ';
            }
        }
        return tabTrans;
    }
}