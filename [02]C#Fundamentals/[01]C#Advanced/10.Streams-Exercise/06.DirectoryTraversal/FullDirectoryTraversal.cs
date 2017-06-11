namespace _06.DirectoryTraversal
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    public class FullDirectoryTraversal
    {
        private static StringBuilder sb = new StringBuilder();

        private static void Main(string[] args)
        {
            Console.Write("Enter root folder path: ");
            var path = @"..\..\";
            

            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                Traverse(di, 1);

                SaveDataToTextFile(sb);

                Console.WriteLine("Results exported into: report.txt");
            }
            else
            {
                Console.WriteLine($"Not a valid path: {path}");
            }
        }

        private static void SaveDataToTextFile(StringBuilder sb)
        {
            StreamWriter sr = new StreamWriter(@"report.txt");

            using (sr)
            {
                sr.Write(sb.ToString());
            }
        }

        private static void Traverse(System.IO.DirectoryInfo root, int indentetion)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;
            try
            {
                files = root.GetFiles("*.*").Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden)).ToArray();
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                
                sb.AppendLine($"{new string('-', indentetion)}{root.Name}");
                var extensions = files.Select(f => f.Extension).Distinct().OrderBy(x => x);

                foreach (var ext in extensions)
                {
                    
                    sb.AppendLine($"{ext}");
                    foreach (System.IO.FileInfo fi in files.Where(f => f.Extension == ext).OrderByDescending(x => x.Length).ThenBy(ff => ff.Name))
                    {
                       
                        sb.AppendLine($"{new string('~', indentetion + 1)}{fi.Name} - {(decimal)fi.Length / 1024:F3}kb");
                    }
                }
                
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs.OrderBy(d => d.Name))
                {
                    
                    Traverse(dirInfo, indentetion++);
                }
            }
        }
    }
}
