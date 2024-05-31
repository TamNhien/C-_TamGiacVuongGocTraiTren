using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap chieu cao tam giac: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = n; j >= i; j--)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}