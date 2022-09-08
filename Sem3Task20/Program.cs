int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

double CalculateDistance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return distance;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите координату X первой точки: ");
int y1 = ReadData("Введите координату Y первой точки: ");
int x2 = ReadData("Введите координату X второй точки: ");
int y2 = ReadData("Введите координату Y второй точки: ");

double result = CalculateDistance(x1, y1, x2, y2);
PrintResult("Расстояние между точками: " + Math.Round(result, 2));