//-------------------------------------------------------------------
//                      Задача 43
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем
//-------------------------------------------------------------------

// Ввод данных пользователем
double ReadData(string text)
{
    Console.Write(text);
    double number = double.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Вывод результата в консоль
// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

// Поиск точки пересечения двух прямых
double[] FindPoint(double k1, double b1, double k2, double b2)
{
    double[] outtArr = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    outtArr[0] = x;
    outtArr[1] = y;
    return outtArr;
}

//Вводим значения k1, b1, k2, b2
double k1 = ReadData("Введите значение k1:");
double b1 = ReadData("Введите значение b1:");
double k2 = ReadData("Введите значение k2:");
double b2 = ReadData("Введите значение b2:");

//Вычисляем точку пересечения
double[] Point = FindPoint(k1, b1, k2, b2);

//Выводим на экран координаты точки пересечения
PrintResult("Точка пересечения двух прямых: ", $"({Point[0]};{Point[1]})");