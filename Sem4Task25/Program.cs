//------------------------------------------------------
//                 Задача 25
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
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

// Возведение числа А в степень В циклом
long Pow(int inputA, int inputB)
{
    long Res1 = 1;
    for (int i = 0; i < inputB; i++)
    {
        Res1 = Res1 * inputA;
    }
    return Res1;
}

// Возвездение числа А в степень В методом Math
double MathPow(int inputA, int inputB)
{
    double Res2 = Math.Pow(inputA, inputB);
    return Res2;
}
// Вывод на экран результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int inputA = ReadData("Введите число, которое хотите возвести в степень: ");
int inputB = ReadData("Введите степень, в которую хотите возвести число: ");
PrintResult("Результат 1 (с помощью цикла): " + Pow(inputA, inputB));
PrintResult("Результат 2 (с помощью метода Math): " + MathPow(inputA, inputB));