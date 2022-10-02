// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Вывод результата в консоль
void PrintResult(string data)
{
    Console.WriteLine(data);
}

string LineGenRec(int numN)
{
    //Точка остановки
    if (numN == 0) return "";
    string outLine = LineGenRec(numN - 1) + " " + numN;
    return outLine;
}

int numN = ReadData("Введите число N:");
string resultLine = LineGenRec(numN);
PrintResult(resultLine);