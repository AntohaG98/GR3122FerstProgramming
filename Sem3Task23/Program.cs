// -------------------------------------------------------------------------------
//                           Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// -------------------------------------------------------------------------------

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

// Создание первой строчки от 1 до N и второй строчки от 1 до N^3 с вывводом на экран
void LineNumberPow(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        Console.Write(Math.Pow(i, pow) + "\t");
        i++;
    }
    Console.WriteLine(Math.Pow(i, pow) + "\t");
}

int num = ReadData("Введите число N:");

LineNumberPow(num, 1);
LineNumberPow(num, 3);