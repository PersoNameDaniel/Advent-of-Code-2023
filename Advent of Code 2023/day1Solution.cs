using System.IO;

// Read from a text file
string path = @"C:\example.txt";
string[] lines = File.ReadAllLines(path);
foreach (string line in lines)
{
    Console.WriteLine(line);
}