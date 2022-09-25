//--------------------------------------------------------------------------
//                                Задача 54
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
//--------------------------------------------------------------------------

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

// Сортируем элементы в строках по убыванмю
void Sort2DArray(int[,] matr)
{
    int[] arr = new int[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[j] = matr[i, j];
        }
        BoobleSort(arr);
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = arr[j];
        }
    }
}

// Сортируем элементы методом пузырька
void BoobleSort(int[] arr)
{
    int tempNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                tempNum = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = tempNum;
            }
        }
    }
}

// Задаем размеры двумерного массива
int inputLen = ReadData("Введите количество строк двумерного массива: ");
int inputCol = ReadData("Введите количество столбцов двумерного массива: ");
int[,] matrix = new int[inputLen, inputCol];

// Создаем и выводим на экран изначальный двумерный массив
Fill2DArray(matrix, 1, 9);
PrintResult("Исходный двумерный массив:");
Print2DArray(matrix);

// Делаем сортировку элементов массива в строках и выводим на экран изменный массив
Sort2DArray(matrix);
PrintResult("Отсортированный двумерный массив: ");
Print2DArray(matrix);