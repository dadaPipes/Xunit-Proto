using System;
using System.IO;

const string folderPath = @"../v3\v3-2.0.0\src\xunit.v3.assert\Asserts";

ReplaceNamespaceNamesWithTheirFolderName(folderPath);

void ReplaceNamespaceNamesWithTheirFolderName(string folderPath)
{
    foreach (string file in Directory.GetFiles(folderPath, "*.cs"))
    {
        string folderName = new DirectoryInfo(folderPath).Name;
        string content = File.ReadAllText(file);
        // Replace namespace name
        string updatedFileContent = content.Replace("namespace Xunit", $"namespace {folderName}");
        File.WriteAllText(file, updatedFileContent);
        Console.WriteLine($"Updated namespace name in {file}");
    }
}