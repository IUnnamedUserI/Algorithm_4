using System;
using System.Diagnostics;

class HelloWorld
{
    static void Main()
    {
        while (true)
        {
            var Timer = Stopwatch.StartNew();
            Console.WriteLine("[Program] Введите количество элементов массива");
            Console.Write(">>> "); int N = int.Parse(Console.ReadLine());

            Timer.Start();
            int[] int_array = new int[N];
            int Min = 0, Max = 0;
            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                int_array[i] = rnd.Next(-500, 500);
                if (int_array[i] < int_array[Min]) Min = i;
                if (int_array[i] > int_array[Max]) Max = i;
            }

            Console.WriteLine($"[Program] Максимальное значение - [{Max}] {int_array[Max]}");
            Console.WriteLine($"[Program] Минимальное значение - [{Min}] {int_array[Min]}");
            Console.WriteLine($"[Program] Время выполнения - {Timer.Elapsed}");
            Timer.Stop();

            Console.Write(">>> "); string cmd = Console.ReadLine();
            if (cmd == "repeat") continue;
            else break;
        }
    }
}
