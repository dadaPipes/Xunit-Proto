using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

const string folderPath = @"../v3/v3-2.0.0/src/xunit.v3.assert/Asserts";

AddXmlExamples(folderPath);

void AddXmlExamples(string folderPath)
{
    foreach (string file in Directory.GetFiles(folderPath, "*.cs"))
    {
        string content = File.ReadAllText(file);
        string updatedContent = AddExampleTagToSummaries(content);

        if (content != updatedContent) // Only write if there's a change
        {
            File.WriteAllText(file, updatedContent, Encoding.UTF8);
            Console.WriteLine($"Updated: {Path.GetFileName(file)}");
        }
    }
}

string AddExampleTagToSummaries(string content)
{
    // Regex to find <summary> comments
    string pattern = @"(///\s*<summary>[\s\S]+?///\s*</summary>(?:\s*///.*)*)";
    var regex = new Regex(pattern, RegexOptions.Multiline);

    return regex.Replace(content, match =>
    {
        string summaryComment = match.Groups[1].Value;

        if (!summaryComment.Contains("<example>"))
        {
            summaryComment = summaryComment.TrimEnd() + @"    
        /// <example>
        /// <code>
        /// Add an example for this method ?
        /// </code>
        /// Contribution <see href=""https://media.giphy.com/media/gVoBC0SuaHStq/giphy.gif"">guide</see>.
        /// </example>"
        
        ;
        }

        return summaryComment;
    });
}

