//---------------------------------------------
//                Задача 47
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
//---------------------------------------------

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
double[,] Gen2DArr(int arrLen, int arrDepth)
{
    double[,] arr = new double[arrLen, arrDepth];
    Random rnd = new Random();
    for (int i = 0; i < arrLen; i++)
    {
        for (int j = 0; j < arrDepth; j++)
        {
            arr[i, j] = System.Math.Round((rnd.NextDouble() * 100), 2);
        }
    }
    return arr;
}

// Печать двумерного массива
void Print2DArray(double[,] matr)
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

int inputLen = ReadData("Введите количество строк двумерного массива: "); //Вводим число строк будущего двумерного массива
int inputCol = ReadData("Введите количество стобцов двумерного массива: "); //Вводим число столбцов будущего двумерного массива

PrintResult("Полученный двумерный массив:");
Print2DArray(Gen2DArr(inputLen, inputCol));