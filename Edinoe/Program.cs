class Proga
{
    public static void Main() // основная часть
    {
        Console.WriteLine("Нужны цыфры: ");
        int[] n = Array.ConvertAll(Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries), int.Parse); //сюда вводят значения игнорируя " ", ",", ";"
        int[] resultat = UnecalniyNumber(n);
        Console.WriteLine($"Уникальные числа: {resultat[0]}, {resultat[1]}");
    }
    public static int[] UnecalniyNumber(int[] nums) // поиск двух унекальных номеров
    {
        int hor = 0;
        foreach (int x in nums) // поиск основного "или"
        {
            hor ^= x;
        }
        int diff = hor & -hor; 
        int[] res = new int[2];
        foreach (int x in nums)
        {
            if ((x & diff) == 0)
            {
                res[0] ^= x;
            }
            else
            {
                res[1] ^= x;
            }
        }
        return res;
    }
}