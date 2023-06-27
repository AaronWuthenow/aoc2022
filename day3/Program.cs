using System;

string path = "./input.txt";

if (File.Exists(path))
    Console.WriteLine("File found...");
else
    throw new FileNotFoundException($"Could not find {path}");

Console.ReadKey();

string? line;

StreamReader sr = new StreamReader(path);

while (!sr.EndOfStream)
{
    line = sr.ReadLine();
}