using System;
using static System.Net.Mime.MediaTypeNames;

namespace batchio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // operation.FileExists();
            //operation.Filecopy();
            //operation.Delete();
           
            //operation opr = new operation();
            // opr.StreamReader();
            // opr.StreamWriter();
            //opr.StreamWriters();

            serialze sr = new serialze();
            sr.Serialize();
            sr.Deserialize();

         
        }
    }
}
