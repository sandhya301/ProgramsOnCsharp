using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

class MultiThread
{
    static async Task Main()
    {
        string directory = "C:\\Users\\PGYSW023\\Desktop\\OutputFiles1";
        Directory.CreateDirectory(directory);

        byte[] buffer = new byte[50 * 1024];
        new Random().NextBytes(buffer);

        Stopwatch stopwatch = Stopwatch.StartNew();

        Task[] tasks = new Task[100];

        for (int i = 1; i <= 100; i++)
        {
            int Index = i;
            tasks[i - 1] = Task.Run(async () =>
            {
                string filePath = Path.Combine(directory, $"File_{Index}.bin");

                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    for (int j = 0; j < 200; j++) // 200 * 50KB = 10MB
                    {
                        await fs.WriteAsync(buffer, 0, buffer.Length);
                    }
                }

                Console.WriteLine($"{filePath} Writing Completed");
            });
        }

        await Task.WhenAll(tasks);

        stopwatch.Stop();
        Console.WriteLine($"Multithreaded execution time: {stopwatch.ElapsedMilliseconds} seconds");
    }
}
