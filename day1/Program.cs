int[] elfCalories = new int[257];

string path = "../../../ElfList.txt";

// Delete the file if it exists.
if (File.Exists(path))
    Console.WriteLine("File found. Start processing");
else
    Console.WriteLine("Could not find file!");

// Read the file
string? line;
int elf = 0;
StreamReader sr = new(path);
while (!sr.EndOfStream)
{
    line = sr.ReadLine();
    
    if (line != "")
        elfCalories[elf] += int.Parse(line);
    else
        elf++;
}

// Show all Calories
//int totalCalories = 0;
//for (int i = 0; i < elfCalories.Length; i++)
//{
//    totalCalories += elfCalories[i];
//    Console.WriteLine($"Elf {i + 1}: {elfCalories[i]}");
//}

//Console.WriteLine($"Total Calories: {totalCalories}");

// get Max cal
/*
int maxValue = elfCalories.Max();
int maxIndex = elfCalories.ToList().IndexOf(maxValue);

Console.WriteLine($"Most Calories: Elf {maxIndex} with {maxValue} cal");
*/

// Get Max three and get there total Calories
int totalCalories = 0;
int[,] elfs = new int[3,2];
for (int i = 0; i < 3; i++)
{
    int maxValue = elfCalories.Max();
    int maxIndex = elfCalories.ToList().IndexOf(maxValue);
    
    elfs[i,0] = maxIndex;
    elfs[i, 1] = maxValue;
    totalCalories += maxValue;
    
    elfCalories = elfCalories.Where(val => val != maxValue).ToArray();
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Elf {elfs[i,0]}: {elfs[i,1]} cal");
}

Console.WriteLine($"Total Calories: {totalCalories} cal");