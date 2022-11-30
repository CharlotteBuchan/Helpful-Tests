
using System.IO;

    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer;
            writer = new StreamWriter("test.txt");

            writer.WriteLine("hello world");
            writer.Close();

            Console.WriteLine("done");

            var fileName = @"D:\charlotte.txt";
            var fileName2 = @"D:\work\charlotte.txt";
            string copy = "This is not a dummy text";

            File.WriteAllText(fileName, "This is dummy text");
            // Create the file, or overwrite if the file exists.
            File.Move(fileName, fileName2);


            Console.WriteLine(File.GetLastAccessTime(fileName));
            

            /*
            using FileStream fs = File.Create(fileName);
            using var sr = new StreamWriter(fs);

            sr.WriteLine(copy);
            */
            Console.WriteLine("done");

        


        }
    }
