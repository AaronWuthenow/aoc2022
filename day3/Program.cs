using System;

string path = "./input.txt";

if (File.Exists(path))
    Console.WriteLine("File found...");
else
    Console.WriteLine($"Could not find {path}");

string? line;
int sum = 0;

StreamReader sr = new StreamReader(path);

/*while (!sr.EndOfStream)
{
    bool found = false;

    line = sr.ReadLine();
    int half = line.Length / 2;


    for (int i = 0; i < half; i++)
    {
        for (int j = half ; j < line.Length; j++)
        {
            if (line[i] == line[j] && !found)
            {
                found = true;

                if (char.IsLower(line[i]))
                    sum += line[j] - 96;
                else
                    sum += line[j] - 38;   
            }
        }
    }
}
Console.WriteLine(sum);*/


while (!sr.EndOfStream)
{
    bool found = false;

    line = sr.ReadLine();
    int counter = 0;


    for (int i = 0; i < line.Length; i++)
    {
        for (int j = 0; j < line.Length; j++)
        {


            if (line[i] == line[i] && !found && counter <= 3)
            {
                found = true;
                counter++;

                if (char.IsLower(line[i]))
                    sum += line[i] - 96;
                else
                    sum += line[i] - 38;
            }
        }
    }
}
