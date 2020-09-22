using System;
using System.IO;

public class FileIO
{
    public void LearnFileHandling()
    {
        string fileName = "file.txt";
        if (File.Exists(fileName)) //it checks whether the file exists or not and gives bool result.
        {
            string fileContent = File.ReadAllText(fileName);
            Console.WriteLine(fileContent);
        }
    
        File.WriteAllText(fileName,"This is just a txt files.");
    }

    public void LearnFileInfo()
    {
        string fileName = "file.txt";
        FileInfo fileInfo = new FileInfo(fileName);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;

        Console.WriteLine($"File Size: {size} bytes");
        Console.WriteLine($"Created: {createdDate}");
    }

    public void LearnDirectories()
    {
        string directoryName = "A";
        Directory.CreateDirectory(directoryName);
    }
}

    //Create a folder "ABC" within which create 10 subfolders
    //Each subfolders should contain a c# file "Hello world program
