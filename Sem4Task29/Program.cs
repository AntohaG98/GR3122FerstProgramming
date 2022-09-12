//------------------------------------------------------
//                 Задача 29
// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
//------------------------------------------------------

// Ввод данных
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Создание и заполнение массива
int[] GenArray(int ArrLen, int Start, int Stop) // Задаем длину массива и диапозон случайных чисел, заполняемых массив
{
    int[] array = new int[ArrLen];
    Random ren = new Random();
    for (int i = 0; i < ArrLen; i++) // Циклом заполняем массив случайными числами
    {
        array[i] = ren.Next(Start, Stop + 1);
    }
    return array;
}

// Вывод массива на экран
void PrintArray(int[] Arr)
{
    Console.Write("Полученный массив: ["); // Сначала выводим на экран открывающую квадратную скобку
    for (int i = 0; i < Arr.Length - 1; i++) // Затем циклом выводим все элементы массива, кроме последнего, через запятую
    {
        Console.Write(Arr[i] + ", ");
    }
    Console.WriteLine(Arr[Arr.Length - 1] + "]"); // Наконец, выводим последний элемент массива и закрывающую квадратную скобку
}

int ArrLen = ReadData("Введите длину массива: ");
int Start = ReadData("Введите минимальное число: ");
int Stop = ReadData("Введите максимальное число: ");
PrintArray(GenArray(ArrLen, Start, Stop));