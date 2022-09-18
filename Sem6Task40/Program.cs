//--------------------------------------------------------------------------
//                       Задача 40
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
//--------------------------------------------------------------------------

// Вариант Константина
// Метод считывания данных пользователя
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Метод, принимает строку, выводит в консоль
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// bool TriangleTest(int a, int b, int c)
// {
//     return (a + b > c) && (a + c > b) && (b + c > a);
// }

// int a = ReadData("Введите длину стороны a: ");
// int b = ReadData("Введите длину стороны b: ");
// int c = ReadData("Введите длину стороны c: ");

// PrintResult(TriangleTest(a, b, c) ? "Такой треугольник может быть" : "Такого треугольника не может быть");

// Вариант Евгения
// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

bool TrglTest(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int a = ReadData("Введите сторону треугольника а: ");
int b = ReadData("Введите сторону треугольника b: ");
int c = ReadData("Введите сторону треугольника c: ");

PrintResult(TrglTest(a, b, c) ? "Такой треугольник существует" : "Такого треугольника не существует");

