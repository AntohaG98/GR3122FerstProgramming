//-------------------------------------------------------
//                    Задача 58
// Задайте две матрицы. Напишите программу, которая будет
// которая будет находить произведение двух матриц.
//-------------------------------------------------------

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

// Вывод результата на экран
void PrintResult(string data)
{
    Console.WriteLine(data);
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
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
    Console.WriteLine();
}

//  Умножаем две матрицы
int[,] Multiple2DArray(int[,] matr, int[,] arr)
{
    int[,] matrix = new int[matr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                matrix[i, j] += matr[i, k] * arr[k, j];
            }
        }
    }
    return matrix;
}

// Задаем размеры первого двумерного массива
int inputLen = ReadData("Введите количество строк первого двумерного массива: ");
int inputCol = ReadData("Введите количество столбцов первого двумерного массива: ");
int[,] matrix = new int[inputLen, inputCol];

// Создаем и выводим на экран первый двумерный массив
Fill2DArray(matrix, 1, 9);
PrintResult("Первый двумерный массив:");
Print2DArray(matrix);

// Задаем размеры второго двумерного массива и выводим на экран
PrintResult("У второй матрицы должно быть такое же количество строк, что и у первой: " + inputLen);
int inputCol1 = ReadData("Введите количество столбцов второго двумерного массива: ");
int[,] matrix1 = new int[inputLen, inputCol1];

// Выводим на экран второй двумерный массив
Fill2DArray(matrix1, 1, 9);
PrintResult("Второй двумерный массив: ");
Print2DArray(matrix1);

// Выполняем умножение матриц и выводим на экран их произведение
PrintResult("Произведение двух матриц равно: ");
Print2DArray(Multiple2DArray(matrix, matrix1));