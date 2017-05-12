namespace _04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class File
    {
        public string Directory { get; set; }

        public string Name { get; set; }

        public string Extention { get; set; }

        public long Size { get; set; }
    }
    public class Files
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            var filesData = new Dictionary<string, File>();

            for (int i = 0; i < count; i++)
            {
                var currentFile = Console.ReadLine().Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var fileInfo = currentFile[currentFile.Length - 1].Split(new[] { ';' });
                var fullFileName = fileInfo[0];
                var fileSize = long.Parse(fileInfo[1]);
                var fileExtention = fullFileName.Split('.')[fullFileName.Split('.').Length - 1];

                if (!filesData.ContainsKey(fullFileName))
                {
                    filesData[fullFileName] = new File();
                }

                filesData[fullFileName] = new File
                {
                    Name = fullFileName,
                    Size = fileSize,
                    Directory = currentFile[0],
                    Extention = fileExtention
                };
            }

            var filesCommand = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var extention = filesCommand[0];
            var root = filesCommand[2];

            var fileExists = false;

            var sortedFilesData = filesData.OrderByDescending(x => x.Value.Size).ThenBy(x => x.Key);

            foreach (var kvp in sortedFilesData)
            {
                var fileName = kvp.Key;
                var fileSize = kvp.Value.Size;
                var fileExtention = kvp.Value.Extention;
                var fileDirectory = kvp.Value.Directory;

                if (fileDirectory == root && extention == fileExtention)
                {
                    Console.WriteLine($"{fileName} - {fileSize} KB ");
                    fileExists = true;
                }

            }

            if (!fileExists) Console.WriteLine("No");
        }
    }
}
