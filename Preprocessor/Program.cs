using System.Text.RegularExpressions;

namespace Preprocessor;

internal class Program
{
    static void Main(string[] args)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string folderPath = Path.Combine(currentDirectory, "..", "Xunit-Proto", "v3", "v3-2.0.0", "src", "xunit.v3.assert", "Asserts");

        RenameClassNamesToMatchFileNames(folderPath);
    }
    static void RenameClassNamesToMatchFileNames(string folderPath)
    {
        foreach (string file in Directory.GetFiles(folderPath, "*.cs"))
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
            string content = File.ReadAllText(file);

            // Replace class name
            string updatedFileContent = Regex.Replace(content, @"partial class Assert", $"class {fileNameWithoutExtension}");

            File.WriteAllText(file, updatedFileContent);
            Console.WriteLine($"Updated class name in {file}");
        }

        Console.WriteLine("Class renaming complete.");
    }
}
