using System;
using System.IO;
using System.Text.RegularExpressions;

const string folderPath = @"../v3/v3-2.0.0/src/xunit.v3.assert/Asserts";

updateXmlExamples(folderPath);

void updateXmlExamples(string folderPath)
{
    string oldString = "";
    string newString = "";

    foreach (string filePath in Directory.GetFiles(folderPath, "*.cs"))
    {
        string content = File.ReadAllText(filePath);

        // Regex pattern to find content inside <example>...</example>
        string newContent = Regex.Replace(content, @"(?<=<example>)([\s\S]*?)(?=<\/example>)",
        match => match.Value.Replace(oldString, newString));

        File.WriteAllText(filePath, newContent);
        Console.WriteLine($"Updated <example> content in {filePath}");
    }

    Console.WriteLine("XML string replacement complete");
}
