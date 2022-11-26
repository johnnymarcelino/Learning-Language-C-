using System;
using System.Collections;
using System.Collections.Generic;
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

            // with File object
            
            //string sourcePath = @"c:\temp\file1.txt";
            //string targetPath = @"c:\temp\file2.txt";
            //try
            //{
            //    // File não necessita de instanciação

            //    File.Copy(sourcePath, targetPath);
            //    string[] lines = File.ReadAllLines(sourcePath);
            //    foreach (string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}


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
            


            // using block

            // without File object

            //try
            //{
            //    string path = @"c:\tests\file.txt";

            //    using (FileStream fs = new FileStream(path, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            while (!sr.EndOfStream)
            //            {
            //                string line = sr.ReadLine();
            //                Console.WriteLine(line);
            //            }
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            // with File object

            string path = @"c:\tests\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }


            // StreamWriter

            string sourcepath = @"c:\tests\file1.txt";
            string targetpath = @"c:\tests\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }



            // Directory and DirectoryInfo


            string path = @"c:\tests";

            try
            {
                // para diretórios

                IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //var folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }

                // para arquivos
                Console.WriteLine();
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);  // alldirectories - p/subpastas tbm
                //var files =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                // para criar novas pastas

                //Directory.CreateDirectory(path + "\\newfolder");
                Directory.CreateDirectory(@"c:\tests\newfolder");

                // para directoryinfo utiliza-se dos mesmo passo a passo, porem instanciando o objeto

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            */


            // PATH

            string path = @"c:\tests\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
