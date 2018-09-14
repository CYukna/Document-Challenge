using System;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Document\r");

                string title = "";
                title = Console.ReadLine();

                Console.WriteLine("Enter Document title:");

                string content = "";
                content = Console.ReadLine();

                Console.WriteLine("Enter document content: ");

                string fileName = title + ".txt";

                string path = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory.fileName);
                
                if (File.Exists(path))
                {
                    Console.WriteLine("Exception");
                }

                Console.WriteLine(fileName + "was successfully saved. The document contains" + content.Length + "characters.");
            }

            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }
            
    }
}
