using System;

string path = "./input.txt";

// Figure out if we can work with the file
if (File.Exists(path))
    Console.WriteLine("File found. Start processing");
else
    Console.WriteLine("Could not find file!");

// A - Rock - X; B - Paper - Y; C - Scissor - Z
// R:1; P:2; S:3 - Loss:0; Draw:3; Win:6