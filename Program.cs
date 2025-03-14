using System.Text.RegularExpressions;

namespace Xunit_Proto;

internal class Program
{
    static void Main(string[] args)
    {
        ChangeClassNamesToFileNames(@"v3\v3-2.0.0\src\xunit.v3.assert\Asserts");
    }

    static void ChangeClassNamesToFileNames(string folderPath)
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
    }
}
