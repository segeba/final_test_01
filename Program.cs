//функция для ввода начального массива с клавиатуры
string[] initialArr()
{
    int initArrLength;
    while (true)
    {
        Console.Write("Input array size: ");
        string input = Console.ReadLine();
        // Попытка преобразовать введенную строку в целое число
        // Если преобразование удалось и число больше нуля, выходим из цикла
        if (int.TryParse(input, out initArrLength) && initArrLength > 0) break;
        // Если преобразование не удалось или число меньше/равно нулю, выводим сообщение об ошибке
        else Console.WriteLine("Invalid input. Please enter a positive number.");
    }
    string[] initArr = new string[initArrLength];
    for (int i = 0; i < initArr.Length; i++)
    {
        //ввод элемента массива с клавиатуры
        System.Console.Write($"Input element {i + 1}: ");
        //
        string? element = Console.ReadLine();
        initArr[i] = element ?? string.Empty;
        //если не введено значение, то выводится повторный запрос на ввод элемента массива
        while (initArr[i] == "")
        {
            System.Console.Write($"Invalid input. Please enter element {i + 1}: ");
            element = Console.ReadLine();
            initArr[i] = element ?? string.Empty;
        }
    }
    return initArr;
}

//Формирования нового массива из начального массива согласно условию задачи
string[] modifiedArr(string[] initArr)
{
    string[] modArr;
    int modArrLength = 0;
    //подсчет количества элементов массива, которые меньше 4 символов
    for (int i = 0; i < initArr.Length; i++)
    {
        if (initArr[i].Length < 4) modArrLength++;
    }
    //создание нового массива, если в начальном массиве есть элементы, удовлетворяющие условию задачи
    if (modArrLength > 0) modArr = new string[modArrLength];
    //если в начальном массиве нет элементов, удовлетворяющих условию задачи, то возвращается пустой массив
    else return modArr = Array.Empty<string>();
    int j = 0;
    //заполнение нового массива элементами из исходного массива, которые меньше 4 символов
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

//Вывод массива на экран
void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write(Array[i] + " ");
    }
}

//вывод начального массива
string[] array = initialArr();
System.Console.WriteLine("");
System.Console.Write("Initial Array: ");
PrintArray(array);

//вывод измененного массива
System.Console.WriteLine("");
System.Console.WriteLine("");
string[] modArray = modifiedArr(array);
if (modArray.Length != 0)
{
    System.Console.Write("Modified Array: ");
    PrintArray(modArray);
}
else
{
    System.Console.Write("No elements in the array are less than 4 characters.");
}