//---------------------------------------
//               Задача 46
// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
//---------------------------------------

// Ввод данных пользователем
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Вывод результата в консоль
// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}
// Универсальный метод генерации и заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
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


// Печать двумерного массива цветом
void Print2DArrayColored(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{matr[i, j]}\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] arr2D = Fill2DArray(row, column, 10, 100);
Print2DArrayColored(arr2D);