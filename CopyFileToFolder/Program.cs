using System;
using System.IO;

namespace CopyFileToFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            readfiles();

            Console.ReadLine();
        }

        public static void readfiles()
        {
            string[] filePaths = Directory.GetFiles("D:\\logs");
            foreach (var filename in filePaths)
            {
                string file = filename.ToString();

                //Do your job with "file"  
                //string str = "D:\\logs\\archive\\test.txt";  //file.ToString();
                string str = "D:\\logs\\archive" + filename.ToString().Replace("D:\\logs", "");  //file.ToString();
                if (!File.Exists(str))
                    File.Copy(file, str);

                File.Delete(file);
            }
        }
    }
}
