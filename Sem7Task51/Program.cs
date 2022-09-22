//---------------------------------------------------------------------
//                              Задача 51
// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

// Печать двумерного массива
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
}
// Ищем сумму диагонали
int Change2DArray(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matr[i, j];
            }

        }
    }
    return sum;
}

int m = ReadData("Введите количество столбцов: ");
int n = ReadData("Введите количество строк: ");
int[,] matrix = new int[m, n];

//Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);


PrintResult("Сумма главной диагонали: ", Change2DArray(matrix).ToString());
