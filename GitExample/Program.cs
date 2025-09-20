// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello 123");
﻿using System;

/// <summary>
/// Đây là chương trình minh họa phong cách lập trình chuẩn mực.
/// Nhiệm vụ: Tính toán dãy Fibonacci bằng phương pháp đệ quy và lặp,
/// đồng thời so sánh hiệu năng.
/// </summary>
class Program
{
    /// <summary>
    /// Hàm main – điểm bắt đầu của chương trình.
    /// </summary>
    static void Main(string[] args)
    {
        Console.WriteLine("=== CHƯƠNG TRÌNH TÍNH DÃY FIBONACCI ===");
        Console.Write("Nhập số n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        // Tính Fibonacci bằng đệ quy
        Console.WriteLine("\nPhương pháp đệ quy:");
        for (int i = 0; i <= 10; i++)
        {
            Console.Write($"{FibonacciRecursive(i)} ");
        }

        // Tính Fibonacci bằng lặp
        Console.WriteLine("\n\nPhương pháp lặp:");
        for (int i = 0; i <= 100; i++)
        {
            Console.Write($"{SuperFibonacciIterative(i)} ");
        }

        Console.WriteLine("\n\n--- KẾT THÚC CHƯƠNG TRÌNH ---");
    }

    /// <summary>
    /// Tính số Fibonacci thứ n bằng đệ quy.
    /// Công thức: F(n) = F(n-1) + F(n-2), với F(0)=0, F(1)=1.
    /// </summary>
    static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    /// <summary>
    /// Tính số Fibonacci thứ n bằng phương pháp lặp (hiệu quả hơn).
    /// </summary>
    static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;

        int prev1 = 0, prev2 = 1, result = 0;
        for (int i = 2; i <= n; i++)
        {
            result = prev1 + prev2;
            prev1 = prev2;
            prev2 = result;
        }
        return result;
    }
    static int SuperFibonacciIterative(int n)
    {
        if (n <= 1) return n;

        int prev1 = 0, prev2 = 1, result = 0;
        for (int i = 2; i <= n; i++)
        {
            result = prev1 + prev2;
            prev1 = prev2;
            prev2 = result;
        }
        return result*10*10;
    }
}
