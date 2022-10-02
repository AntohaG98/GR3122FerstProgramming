// Вариант Михаила
// // чтение данных из сонсоли
// (int a, int b) ReadData(string line)
// {    
//     Console.Clear();
//     //Выводим сообщение 
//     Console.WriteLine("{0}: ", line);
//     string inputLine = Console.ReadLine() ?? "";

//     // парсим полученную строку
//     string[] inputLineItems = inputLine.Split(",");

//     return (int.Parse(inputLineItems[0]), int.Parse(inputLineItems[1]));
// }


// // возвращает сумму цифр числа numN
// int RecPow(int a, int b)
// {
//     return b == 0 ? 0 : a * a + RecPow(a , b/2);
// }


// // Вывод в консоль
// void PrintResult(int line)
// {
//     Console.WriteLine(line);
// }
// (int a, int b) = ReadData("Введите числа А и B через запятую");

// PrintResult(RecPow(a, b));
// Вариант Евгения
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

int RecPow(int A, int B)
{
    if (B==1) return A;
    return A * RecPow(A, B - 1);
}

int A = ReadData("Введите число: ");
int B = ReadData("Введите степень: ");

PrintResult(RecPow(A,B).ToString());
