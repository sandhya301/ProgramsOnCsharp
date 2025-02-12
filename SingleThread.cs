using System;
using System.Diagnostics;
using System.IO;

class SingleThread
{
    static void Main()
    {
        string directory = "C:\\Users\\PGYSW023\\Desktop\\OutputFiles";
        Directory.CreateDirectory(directory);

        byte[] data = new byte[50 * 1024];
        new Random().NextBytes(data);

        Stopwatch stopwatch = Stopwatch.StartNew();

        for (int i = 1; i <= 100; i++)
        {
            string filePath = Path.Combine(directory, $"File_{i}.bin");

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                for (int j = 0; j < 200; j++) // 200 * 50KB = 10MB
                {
                    fs.Write(data, 0, data.Length);
                }
            }

            Console.WriteLine($"{filePath} Writing Completed");
        }

        stopwatch.Stop();
        Console.WriteLine($"Single threaded execution time: {stopwatch.ElapsedMilliseconds} seconds");
    }
}
