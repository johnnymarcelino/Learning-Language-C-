using System;
using System.IO;


// Trabalhando com Files


namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            // File and FileInfo

            string sourceParth = @"c:\tests\file1.txt";
            string targeteParth = @"c:\tests\file2.txt";

            try
            {
                // FileInfo necessita de instanciação

                FileInfo fileInfo = new FileInfo(sourceParth);
                fileInfo.CopyTo(targeteParth);
                string[] lines = File.ReadAllLines(sourceParth);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";
            try
            {
                // File não necessita de instanciação

                File.Copy(sourcePath, targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            */

            // FileStream and StreamReader

            //string path = @"c:\tests\file1.txt";
            //FileStream fs = null;
            //StreamReader sr = null;
            //try
            //{
            //    fs = new FileStream(path, FileMode.Open);
            //    sr = new StreamReader(fs);
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (sr != null)
            //        sr.Close();
            //    if (fs != null)
            //        fs.Close();
            //}

            // another exemplo less convencional - with the object File

            string path = @"c:\tests\file1.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);

                // in case of read all lines of the file

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }
    }
}
