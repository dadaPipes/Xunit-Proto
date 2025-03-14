using System;
using System.IO;

const string folderPath = @"v3\v3-2.0.0\src\xunit.v3.assert\Asserts";
ChangeClassNamesToFileNames(folderPath);

void ChangeClassNamesToFileNames(string folderPath)
{
    foreach (string file in Directory.GetFiles(folderPath, "*.cs"))
    {
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
        string content = File.ReadAllText(file);

        // Replace class name
        string updatedFileContent = content.Replace("partial class Assert", $"class {fileNameWithoutExtension}");

        File.WriteAllText(file, updatedFileContent);
        Console.WriteLine($"Updated class name in {file}");
    }
}