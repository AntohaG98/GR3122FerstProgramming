//------------------------------------------------------------
//                        Задача 56
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов
//------------------------------------------------------------

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

// Выводим двумерный массив на экран
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Находим строку с наименьшей суммой элементов
int FindMinRow(int[,] matr)
{
    int min = int.MaxValue;
    int sum = 0;
    int outIndexRow = -1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        if (min > sum)
        {
            min = sum;
            outIndexRow = i + 1;
        }
        sum = 0;
    }
    return outIndexRow;
}

// Задаем размеры двумерного массива
int inputLen = ReadData("Введите количество строк двумерного массива: ");
int inputCol = ReadData("Введите количество столбцов двумерного массива: ");
int[,] matrix = new int[inputLen, inputCol];

// Создаем и выводим на экран изначальный двумерный массив
Fill2DArray(matrix, 1, 9);
PrintResult("Исходный двумерный массив:");
Print2DArray(matrix);

// Выводим на экран строку с минимальной суммой элементов
PrintResult("Номер строки с наименьшей суммой элементов: " + FindMinRow(matrix).ToString());