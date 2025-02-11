using System;
using System.IO;
using System.Text;


namespace Programs
{
    class Program1
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\PGYSW023\Desktop\Programs\output.txt";
            Console.WriteLine("Enter multiple lines of text.Type STOP to end.");
            StringBuilder sb = new StringBuilder();
            try
            {
                while (true)
                {
                    string inputText = Console.ReadLine();
                    if (inputText.Contains("STOP"))
                    {

                        break;
                    }

                    sb.AppendLine(inputText);


                }
                File.WriteAllText(path, sb.ToString());
                string readText = File.ReadAllText(path);
                Console.WriteLine("\n");
                Console.WriteLine("File Content:\n");
                Console.WriteLine(readText);


            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Error:Access to your file is denied.Please check your file permission");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Error: The Directory your looking for is not found.Please Check the Path.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}