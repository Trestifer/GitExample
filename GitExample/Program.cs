// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello 123");
﻿using System;
using System.Collections.Generic;

/// <summary>
/// Chương trình minh họa cách kiểm tra và liệt kê số nguyên tố.
/// Mục tiêu: trình bày phong cách lập trình rõ ràng, có chú thích chi tiết.
/// </summary>
class Program
{
    /// <summary>
    /// Hàm main – điểm bắt đầu chương trình.
    /// </summary>
    static void Main(string[] args)
    {
        Console.WriteLine("=== CHƯƠNG TRÌNH KIỂM TRA SỐ NGUYÊN TỐ ===");

        Console.Write("Nhập một số để kiểm tra: ");
        int number = int.Parse(Console.ReadLine() ?? "0");

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} là số nguyên tố.");
        }
        else
        {
            Console.WriteLine($"{number} KHÔNG phải là số nguyên tố.");
        }

        Console.Write("\nNhập giới hạn trên để liệt kê các số nguyên tố từ 2 đến n: ");
        int limit = int.Parse(Console.ReadLine() ?? "0");

        List<int> primes = GeneratePrimes(limit);

        Console.WriteLine($"\nCác số nguyên tố từ 2 đến {limit}:");
        Console.WriteLine(string.Join(", ", primes));

        Console.WriteLine("\n--- KẾT THÚC CHƯƠNG TRÌNH ---");
    }

    /// <summary>
    /// Kiểm tra một số có phải là số nguyên tố hay không.
    /// </summary>
    /// <param name="n">Số cần kiểm tra.</param>
    /// <returns>true nếu n là số nguyên tố, ngược lại false.</returns>
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        // Chỉ cần kiểm tra tới căn bậc hai của n
        int boundary = (int)Math.Sqrt(n);

        for (int i = 3; i <= boundary; i += 2)
        {
            if (n % i == 0) return false;
        }

        return true;
    }

    /// <summary>
    /// Sinh danh sách các số nguyên tố từ 2 đến n.
    /// </summary>
    /// <param name="n">Giới hạn trên.</param>
    /// <returns>Danh sách số nguyên tố.</returns>
    static List<int> GeneratePrimes(int n)
    {
        List<int> primes = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i)) primes.Add(i);
        }
        return primes;
    }
}
