//--------------------------------------------------------------------------------------
//                                        Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
//--------------------------------------------------------------------------------------

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
void PrintResult(string prefix, string data)
{
    if (data.Equals("-1"))
    {
        Console.WriteLine("Искомый элемент отсутствует");
    }
    else
    {
        Console.WriteLine(prefix + data);
    }
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

// Поиск желаемого элемента массива
double FindElement(double[,] array2D, int x, int y)
{
    if (x < array2D.GetLength(0) && y < array2D.GetLength(1))
    {
        return array2D[x, y];
    }
    else { return -1; }
}

int inputLen = ReadData("Введите количество строк двумерного массива M: "); //Вводим число строк будущего двумерного массива
int inputCol = ReadData("Введите количество стобцов двумерного массива N: "); //Вводим число столбцов будущего двумерного массива
double[,] matrix = Gen2DArr(inputLen, inputCol);

Console.WriteLine("Полученный двумерный массив:"); // Вывод на экран искомого массива
Print2DArray(matrix);

int x = ReadData("Введите искомый столбец(от 0 до M): "); // Задаем первую координату разыскиваемого элемента
int y = ReadData("Введите искомую строку(от 0 до N): "); // Задаем вторую координату разыскиваемого элемента

PrintResult("Искомый элемент: ", FindElement(matrix, x, y).ToString()); // Выводим на экран значение разыскиваемого элемента