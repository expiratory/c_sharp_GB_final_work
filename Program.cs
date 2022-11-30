Console.Clear();

void PrintStringWithOnlyThreeSymbols(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3) count++;
    }
    string[] newStringArray = new string [count];
    int index = 0;
    for (int g = 0; g < stringArray.Length; g++)
    {
            if (stringArray[g].Length <= 3)
            {
                newStringArray[index] = stringArray[g];
                index++;
            }
    }
    Console.WriteLine($"[ {String.Join(", ", newStringArray)} ]");
}

string[] initialStringArray = {"hello", "2", "world", ":-)"};
Console.WriteLine($"[ {String.Join(", ", initialStringArray)} ]");
Console.WriteLine();
PrintStringWithOnlyThreeSymbols(initialStringArray);