//---------------------------------------------------------------------------------------
//                              Задача 34
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька
//---------------------------------------------------------------------------------------

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
int[] GenArray(int ArrLength)
{
    int[] array = new int[ArrLength];
    Random ren = new Random();

    for (int i = 0; i < ArrLength; i++)
    {
        array[i] = ren.Next(100, 1000);
    }
    return array;
}

//Подсчет четных чисел
int CountEven(int[] arr)
{
    int a = 0; // Задаем счетчик четных чисел в массиве равным нулю
    for (int i = 0; i < arr.Length; i++) // Циклом проходим по созданному массиву
        if (arr[i] % 2 == 0) a += 1; // Проверяем каждый элемент массива: если число четное-увеличиваем счетчик на 1
    return a; // Возвращаем значение счетчика четных чисел
}

// Сортировка пузырьком исходного массива
int[] BoobleSort(int[] arr)
{
    int TempNum = 0; //Создаем третью локальную перменную для метода Пузырька
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                TempNum = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = TempNum;
            }
        }
    }
    return arr;
}

// Печатаем массив
void PrintArray(int[] Arr)
{
    Console.Write("[" + Arr[0] + ", ");
    for (int i = 1; i < Arr.Length - 1; i++)
    {
        Console.Write(Arr[i] + ", ");
    }
    Console.Write(Arr[Arr.Length - 1] + "]");
    Console.WriteLine();
}

// Вывод на экран
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int ArrLength = ReadData("Введите длину массива: ");//Задаем длину массива
int[] arr = GenArray(ArrLength);//Заполнение массива случайными числами от 100 до 999

PrintResult("Исходный массив: ");
PrintArray(arr); //Вывод на экран полученного исходного массива

PrintResult("Отсортированный по возрастанию массив: ");
PrintArray(BoobleSort(arr)); //Вывод на экран отсортированного по возрастанию массива

PrintResult("Количество четных чисел в массиве: " + CountEven(arr)); //Вывод на экран значения счетчика четных чисел в массиве