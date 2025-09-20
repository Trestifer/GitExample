using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CHƯƠNG TRÌNH KIỂM TRA SỐ HOÀN HẢO ===");

        Console.Write("Nhập một số để kiểm tra: ");
        int number = int.Parse(Console.ReadLine() ?? "0");

        if (IsPerfectNumber(number))
        {
            Console.WriteLine($"{number} là số hoàn hảo.");
        }
        else
        {
            Console.WriteLine($"{number} KHÔNG phải là số hoàn hảo.");
        }

        Console.Write("\nNhập giới hạn trên để liệt kê các số hoàn hảo từ 2 đến n: ");
        int limit = int.Parse(Console.ReadLine() ?? "0");

        List<int> perfectNumbers = GeneratePerfectNumbers(limit);

        Console.WriteLine($"\nCác số hoàn hảo từ 2 đến {limit}:");
        Console.WriteLine(string.Join(", ", perfectNumbers));

        Console.WriteLine("\n--- KẾT THÚC CHƯƠNG TRÌNH ---");
    }

    // Hàm kiểm tra số hoàn hảo
    static bool IsPerfectNumber(int n)
    {
        if (n < 2) return false;

        int sum = 1; // 1 luôn là ước số
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                sum += i;
        }

        return sum == n;
    }

    // Sinh danh sách số hoàn hảo
    static List<int> GeneratePerfectNumbers(int n)
    {
        List<int> perfectNumbers = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            if (IsPerfectNumber(i)) perfectNumbers.Add(i);
        }
        return perfectNumbers;
    }
}