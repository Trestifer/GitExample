using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CHƯƠNG TRÌNH KIỂM TRA SỐ ARMSTRONG ===");

        Console.Write("Nhập một số để kiểm tra: ");
        int number = int.Parse(Console.ReadLine() ?? "0");

        if (IsArmstrong(number))
        {
            Console.WriteLine($"{number} là số Armstrong.");
        }
        else
        {
            Console.WriteLine($"{number}  là số Armstrong.");
        }

        Console.Write("\nNhập giới hạn trên để liệt kê các số Armstrong từ 1 đến n: ");
        int limit = int.Parse(Console.ReadLine() ?? "0");

        List<int> armstrongNumbers = GenerateArmstrongNumbers(limit);

        Console.WriteLine($"\nCác số Armstrong từ 1 đến {limit}:");
        Console.WriteLine(string.Join(", ", armstrongNumbers));

        Console.WriteLine("\n--- KẾT THÚC CHƯƠNG TRÌNH ---");
    }

    // Hàm kiểm tra số Armstrong
    static bool IsArmstrong(int n)
    {
        string s = n.ToString();
        int power = s.Length;
        int sum = 0;

        foreach (char c in s)
        {
            int digit = c - '0';
            sum += (int)Math.Pow(digit, power);
        }

        return sum == n;
    }

    // Sinh danh sách số Armstrong
    static List<int> GenerateArmstrongNumbers(int n)
    {
        List<int> armstrongNumbers = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (IsArmstrong(i)) armstrongNumbers.Add(i);
        }
        return armstrongNumbers;
    }
}
