// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Working with file information

// Make sure the example file exists
const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file
string content;
content = File.ReadAllText(filename);
Console.WriteLine(content);

// TODO: We can also get general information using a FileInfo 
FileInfo fileInfo = new FileInfo(filename);
Console.WriteLine($"File Name: {fileInfo.Name}");
Console.WriteLine($"File Size: {fileInfo.Length} bytes");
Console.WriteLine($"File Creation Time: {fileInfo.CreationTime}");

// TODO: File information can also be manipulated
if (fileInfo.Exists) {
    // Rename the file
    string newFileName = "RenamedFile.txt";
    fileInfo.MoveTo(newFileName);
    Console.WriteLine($"File renamed to: {newFileName}");

    // Get the new file info
    FileInfo newFileInfo = new FileInfo(newFileName);
    Console.WriteLine($"New File Name: {newFileInfo.Name}");
    Console.WriteLine($"New File Size: {newFileInfo.Length} bytes");
    Console.WriteLine($"New File Creation Time: {newFileInfo.CreationTime}");
    
} else {
    Console.WriteLine("The file does not exist.");
}


