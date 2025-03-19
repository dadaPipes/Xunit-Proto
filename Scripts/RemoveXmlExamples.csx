using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

const string folderPath = @"../v3/v3-2.0.0/src/xunit.v3.assert/Asserts";

RemoveXmlExamples(folderPath);

void RemoveXmlExamples(string folderPath)
{
    foreach (string file in Directory.GetFiles(folderPath, "*.cs"))
    {
        string content = File.ReadAllText(file);
        string updatedContent = RemoveExampleTagFromSummaries(content);

        if (content != updatedContent) // Only write if there's a change
        {
            File.WriteAllText(file, updatedContent, Encoding.UTF8);
            Console.WriteLine($"Updated: {Path.GetFileName(file)}");
        }
    }
}

string RemoveExampleTagFromSummaries(string content)
{
    // Regex to match <example> blocks and remove them
    string pattern = @"(\s*///\s*<example>[\s\S]*?///\s*</example>\s*)";
    var regex = new Regex(pattern, RegexOptions.Multiline);

    return regex.Replace(content, ""); // Replace with an empty string to remove
}
