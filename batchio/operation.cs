using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace batchio
{
    public class operation
    {
        public static void FileExists()
        {
            String path = @"C:\\Users\\CSC\\source\\repos1\\batchio\\batchio\\ex.txt";

            if (File.Exists(path))
            {
                Console.WriteLine(path);
            }
            else
            {
                Console.WriteLine("file not found");
            }
        }
       

        

        public static void Filecopy()
        {
            var path = @"C:\Users\CSC\source\repos1\batchio\batchio\ex.txt";

            var copypath = @"C:\Users\CSC\source\repos1\batchio\batchio\ex1.txt";

            File.Copy(path, copypath);
            Console.ReadKey();
        }

        public static void Delete()
        {
            String path = @"C:\Users\CSC\source\repos1\batchio\batchio\ex1.txt";

            File.Delete(path);

        }
        public void StreamReader()
        {
            String path = @"C:\\Users\\CSC\\source\\repos1\\batchio\\batchio\\sam.txt";

            using(StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                
            }
        }
        public void StreamWriter()
        {
            String path = @"C:\\Users\\CSC\\source\\repos1\\batchio\\batchio\\sam.txt";

            using (StreamWriter sw = File.AppendText(path))
            
            {
                sw.WriteLine("hiiiiii My Goal");
                sw.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
        }
        public void StreamWriters()
        {
            StreamWriter sw = new StreamWriter(@"C:\\Users\\CSC\\source\\repos1\\batchio\\batchio\\sam.txt");
            sw.WriteLine("Hii Maha");
            sw.Close();
        }

    }
}
