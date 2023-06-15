using System;
using System.Reflection.Metadata.Ecma335;

string path = "../../../input.txt";

// Figure out if we can work with the file
if (File.Exists(path))
    Console.WriteLine("File found. Start processing");
else
    Console.WriteLine("Could not find file!");

// A - Rock - X; B - Paper - Y; C - Scissor - Z
// R:1; P:2; S:3 - Loss:0; Draw:3; Win:6

string? line;
int totalScore = 0;

StreamReader sr = new(path);

//// Part One
//while (!sr.EndOfStream)
//{
//    line = sr.ReadLine();

//    if (line[2] == 'X')
//    {
//        if (line[0] == 'A')
//        {
//            totalScore += (int)GameValues.X;
//            totalScore += (int)GameValues.Draw;
//        }
//        else if (line[0] == 'B')
//        {
//            totalScore += (int)GameValues.X;
//            totalScore += (int)GameValues.Loss;
//        }
//        else if (line[0] == 'C')
//        {
//            totalScore += (int)GameValues.X;
//            totalScore += (int)GameValues.Win;
//        }
//    }
//    else if (line[2] == 'Y')
//    {
//        if (line[0] == 'A')
//        {
//            totalScore += (int)GameValues.Y;
//            totalScore += (int)GameValues.Win;
//        }
//        else if (line[0] == 'B')
//        {
//            totalScore += (int)GameValues.Y;
//            totalScore += (int)GameValues.Draw;
//        }
//        else if (line[0] == 'C')
//        {
//            totalScore += (int)GameValues.Y;
//            totalScore += (int)GameValues.Loss;
//        }
//    }
//    else if (line[2] == 'Z')
//    {
//        if (line[0] == 'A')
//        {
//            totalScore += (int)GameValues.Z;
//            totalScore += (int)GameValues.Loss;
//        }
//        else if (line[0] == 'B')
//        {
//            totalScore += (int)GameValues.Z;
//            totalScore += (int)GameValues.Win;
//        }
//        else if (line[0] == 'C')
//        {
//            totalScore += (int)GameValues.Z;
//            totalScore += (int)GameValues.Draw;
//        }
//    }
//}

//Console.WriteLine(totalScore);

// Part two
while (!sr.EndOfStream)
{
    line = sr.ReadLine();

    if (line[0] == 'A') // Rock
    {
        if (line[2] == 'Y') // Draw
        {
            totalScore += (int) GameValues.A;                      // X -> Loss
            totalScore += (int) GameValues.Draw;
        }
        else if (line[2] == 'X') // Loss
        {
            totalScore += (int) GameValues.C;
            totalScore += (int) GameValues.Loss;
        }
        else if (line[2] == 'Z') // Win
        {
            totalScore += (int) GameValues.B;
            totalScore += (int) GameValues.Win;
        }
    }
    else if (line[0] == 'B') // Paper
    {
        if (line[2] == 'Y') // Draw
        {
            totalScore += (int)GameValues.B;
            totalScore += (int)GameValues.Draw;
        }
        else if (line[2] == 'X') // Loss
        {
            totalScore += (int)GameValues.A;
            totalScore += (int)GameValues.Loss;
        }
        else if (line[2] == 'Z') // Win
        {
            totalScore += (int)GameValues.C;
            totalScore += (int)GameValues.Win;
        }
    }
    else if (line[0] == 'C') // Scissor
    {
        if (line[2] == 'Y') // Draw
        {
            totalScore += (int)GameValues.C;
            totalScore += (int)GameValues.Draw;
        }
        else if (line[2] == 'X') // Loss
        {
            totalScore += (int)GameValues.B;
            totalScore += (int)GameValues.Loss;
        }
        else if (line[2] == 'Z') // Win
        {
            totalScore += (int)GameValues.A;
            totalScore += (int)GameValues.Win;
        }
    }
}

Console.WriteLine(totalScore);

enum GameValues
{
    A = 1,
    X = 1, // Rock
    B = 2,
    Y = 2, // Paper
    C = 3,
    Z = 3, // Scissor

    Loss = 0,
    Draw = 3,
    Win = 6
};