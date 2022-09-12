//------------------------------------------------------
//                 Задача 27
// Напишите Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
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

// Вывод на экран
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Нахождение количества цифр длиной строки
int CalculateDigits(int num)
{
    string numString = num.ToString();
    return numString.Length;
}

// Нахождение количества цифр методом с логарифмом
int CalcDigitLog(int num)
{
    return (int)(Math.Log10(num) + 1);
}

// Нахождение количества цифр
int DigitCount(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += 1;
        number = number / 10;
    }
    return sum;
}

int number = ReadData("Введите число: ");

// Фиксируем и выводим на экран время выполнения первого варианта, затем само количество цифр
DateTime d1 = DateTime.Now;
int numberOfDigits = CalculateDigits(number);
Console.WriteLine(DateTime.Now - d1);

PrintResult("Количество цифр в числе: " + numberOfDigits);

// Фиксируем и выводим на экран время выполнения второго варианта, затем само количество цифр
DateTime d2 = DateTime.Now;
numberOfDigits = CalcDigitLog(number);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Количество цифр в числе: " + numberOfDigits);

// Фиксируем и выводим на экран время выполнения третьего варианта, затем само количество цифр
DateTime d3 = DateTime.Now;
numberOfDigits = DigitCount(number);
Console.WriteLine(DateTime.Now - d3);

PrintResult("Количество цифр в числе: " + numberOfDigits);