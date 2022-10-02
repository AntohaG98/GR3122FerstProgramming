// Чтение данных из консоли
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // Метод, принимает строку, выводит в консоль
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// string LineGenRec(int numN)
// {
//     //Точка остановки
//     if (numN == 0) return "";
//     string outLine = LineGenRec(numN - 1) + " " + numN;
//     return outLine;
// }

// int SumDigit(int num)
// {
//     if (num / 10 == 0)
//         return num;
//     return SumDigit(num / 10) + num % 10;
// }


// int numN = ReadData("Введите число N: ");
// string resultLine = LineGenRec(numN);
// PrintResult(resultLine);

// int number = ReadData("Введите число: ");
// int sum = SumDigit(number);
// PrintResult("Сумма цифр в числе: " + sum);

// Вариант Михаила
// чтение данных из сонсоли
int ReadData(string line)
{
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";
    return int.Parse(inputLine);
}

// возвращает сумму цифр числа numN
int RecSumDigit(int numN)
{
    return numN == 0 ? 0 : numN % 10 + RecSumDigit(numN / 10);
}

// Вывод в консоль
void PrintResult(int line)
{
    Console.WriteLine(line);
}

PrintResult(RecSumDigit(ReadData("Введите число")));
