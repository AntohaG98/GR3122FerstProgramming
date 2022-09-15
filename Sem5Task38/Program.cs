//-----------------------------------------------------------
//                       Задача 38
// Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементами массива.
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
double[] GenArray(int ArrLength, int Stop)
{
    double[] array = new double[ArrLength];
    Random ren = new Random();

    for (int i = 0; i < ArrLength; i++)
    {
        array[i] = Math.Round((ren.NextDouble() * Stop), 2);
    }
    return array;
}

//Находим максимальный элемент массива
double MaxElement(double[] arr)
{
    int iMax = 0; //Посчитаем первый элемент массива максимальным по значению
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[iMax]) iMax = i;
    }
    return arr[iMax];//Возвращаем значение максимального элемента массива
}

//Находим минимальный элемент массива
double MinElement(double[] arr)
{
    int iMin = 0; //Посчитаем первый элемент массива минимальным по значению
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[iMin]) iMin = i;
    }
    return arr[iMin];//Возвращаем значение минимального элемента массива
}

// Печатаем массив
void PrintArray(double[] arr)
{
    Console.Write("[" + arr[0] + " ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + " ");
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
int Stop = ReadData("Введите максимальное значение: ");

double[] arr = GenArray(arrLength, Stop);
PrintResult("Исходный массив");
PrintArray(arr);

PrintResult("Максимальный элемент массива: " + MaxElement(arr));

PrintResult("Минимальный элемент массива: " + MinElement(arr));

PrintResult("Разница между макс-ым и мин-ым элементами массива: " + Math.Round((MaxElement(arr)-MinElement(arr)), 2));