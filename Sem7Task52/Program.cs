//-----------------------------------------------------------
//                   Задача 52
//  Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
//-----------------------------------------------------------

// Ввод данных пользователем
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Вывод на экран
void PrintResult(string data)
{
    Console.WriteLine(data);
}

// Генерация случайного двумерного массива.
int[,] Gen2DArr(int arrLen, int arrDepth, int arrMin, int arrMax)
{
    int[,] arr = new int[arrLen, arrDepth];
    Random rnd = new Random();
    for (int i = 0; i < arrLen; i++)
    {
        for (int j = 0; j < arrDepth; j++)
        {
            arr[i, j] = rnd.Next(arrMin, arrMax);
        }
    }
    return arr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Находим среднее арифметическое по столбцам
double[] Count(int[,] matr)
{
    double[] arr = new double[matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[j] = arr[j] + matr[i, j];
        }
    }

    FindMidleArifmetic(arr, matr.GetLength(0));
    return arr;
}

// Находим среднее арифметическое
double[] FindMidleArifmetic(double[] arr, int numbers)
{
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = Math.Round(arr[k] / numbers, 2);
    }
    return arr;
}

// Печать одномерного массива(средние арифметические столбцов двумерного массива)
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
}

int inputLen = ReadData("Введите число строк двумерного массива M: ");
int inputCol = ReadData("Введите число столбцов двумерного массива N: ");
int Start = ReadData("Введите минимальное значение элемента массива: ");
int Stop = ReadData("Введите максимальное значение элемента массива: ");

int[,] matrix = Gen2DArr(inputLen, inputCol, Start, Stop);

PrintResult("Исходный массив: ");
Print2DArray(matrix);

Console.WriteLine("Средние арифметические:");
PrintArray(Count(matrix));