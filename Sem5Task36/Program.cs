//-----------------------------------------------------------
//                       Задача 36
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//-----------------------------------------------------------

// Вводим данные
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Заполняем массив
int[] GenArray(int ArrLength, int Start, int Stop)
{
    int[] array = new int[ArrLength];
    Random ren = new Random();

    for (int i = 0; i < ArrLength; i++)
    {
        array[i] = ren.Next(Start, Stop);
    }
    return array;
}

// находим сумму элементов, расположенных на нечетных позициях
int SumOdd(int[] arr)
{
    int Sum = 0; // Присваиваем сумме нечетных чисел значение 0
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) Sum += arr[i]; // Когда номер элемента массива нечетный-прибавляем значение элемента к сумме
    }
    return Sum; //Возвращаем сумму
}

// Печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

// Вывод на экран
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrLength = ReadData("Введите длину массива: ");
int Start = ReadData("Введите минимальное значение: ");
int Stop = ReadData("Введите максимальное значение: ");

int[] arr = GenArray(arrLength, Start, Stop);
PrintResult("Исходный массив");
PrintArray(arr);

PrintResult("Сумма элементов, расположенных на нечетных позициях массива, равна: " + SumOdd(arr));