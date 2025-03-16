using System;
using System.IO;

// TODO:
// Jeg bør gøre dette til en liste over strenge/mappestier, så jeg bare kan tilføje flere mapper til listen og køre scriptet imod.
// (YAGNI lige nu). Men så igen, Open/Closed Principle, så jeg kan tilføje mappestier efter behov, uden at skulle tilføje en metode pr. repo.

// TODO:
// Skriv en kommentar om HVORFOR at jeg har lavet det her script. Hvad er formålet? Hvad er problemet, som jeg prøver at løse? (imens at jeg husker det)

const string folderPath = @"v3\v3-2.0.0\src\xunit.v3.assert\Asserts";

ReplaceClassNamesWithTheirFileName(folderPath);

void ReplaceClassNamesWithTheirFileName(string folderPath)
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