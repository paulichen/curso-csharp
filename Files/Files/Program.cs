using System;
using System.IO;

namespace Files {
    class Program {
        static void Main(string[] args) {
            string sourcePath = "../../../../../File1.txt";
            //string targetPath = @"C:\Users\paulichen\Desktop\Experity\c#.net\Classes\File2.txt";
            //FileStream fs = null;
            StreamReader sr = null;
            try {
                //fs = new FileStream(sourcePath, FileMode.Open);
                //sr = new StreamReader(fs);
                sr = File.OpenText(sourcePath);
                while(!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
                /*FileInfo fileinfo = new FileInfo(sourcePath);
                //fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach(string line in lines) {
                    Console.WriteLine(line);
                }*/

            } catch(IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } finally {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}
