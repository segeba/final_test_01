string[] initArr()
{
    int initArrLength;
    while (true)
    {
        Console.Write("Input array size: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out initArrLength) && initArrLength > 0) break;
        else Console.WriteLine("Invalid input. Please enter a positive number.");
    }
    string[] initArr = new string[initArrLength];
    for (int i = 0; i < initArr.Length; i++)
    {
        System.Console.Write($"Input element {i + 1}: ");
        initArr[i] = Convert.ToString(Console.ReadLine());
        while (initArr[i] == "")
        {
            System.Console.Write($"Input element {i + 1}: ");
            initArr[i] = Convert.ToString(Console.ReadLine());
        }
    }
    return initArr;
}

string[] modArr(string[] initArr)
{
    int modArrLength = 1;
    for (int i = 0; i < initArr.Length; i++)
    {
        if (initArr[i].Length < 4) modArrLength++;
    }
    string[] modArr = new string[modArrLength];
    int j = 0;
    for (int i = 0; i < initArr.Length; i++)
    {
        if (initArr[i].Length < 4)
        {
            modArr[j] = initArr[i];
            j++;
        }
    }
    return modArr;
}

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write(Array[i] + " ");
    }
}

string[] array = initArr();
System.Console.WriteLine("");
System.Console.Write("Initial Array: ");
PrintArray(array);

System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.Write("Overwrited Array: ");
PrintArray(modArr(array));