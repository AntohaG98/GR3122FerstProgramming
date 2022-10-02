//-----------------------------------------------------------
//                       Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
//-----------------------------------------------------------

// Ввод данных пользователем
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Вывод результата на экран
void PrintResult(int line)
{
    Console.WriteLine(line);
}

// Сумма натуральных элементов от M до N
int RecMN(int m, int n)
{
    if (m >= n) return n;
    return m + RecMN(m + 1, n);
}

int m = ReadData("Введите число: ");
int n = ReadData("Введите число: ");

PrintResult(m > n ? RecMN(n, m) : RecMN(m, n));
