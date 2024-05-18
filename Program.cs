﻿//функция для ввода начального массива с клавиатуры
string[] initArr()
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
string[] modArr(string[] initArr)
{
    int modArrLength = 1;
    //подсчет количества элементов массива, которые меньше 4 символов
    for (int i = 0; i < initArr.Length; i++)
    {
        if (initArr[i].Length < 4) modArrLength++;
    }
    string[] modArr = new string[modArrLength];
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
string[] array = initArr();
System.Console.WriteLine("");
System.Console.Write("Initial Array: ");
PrintArray(array);

//вывод измененного массива
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.Write("Overwrited Array: ");
PrintArray(modArr(array));