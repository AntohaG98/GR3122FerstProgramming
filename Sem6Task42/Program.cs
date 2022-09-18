//-----------------------------------------------
//                Задача 42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
//-----------------------------------------------

//Вариант Константина
// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

string DecToBin(int number)
{
    string binNumber = "";

    while (number > 0)
    {
        binNumber = number % 2 + binNumber;
        number = number / 2;
    }

    return binNumber;
}

int inputNumber = ReadData("Введите число: ");

PrintResult($"Число {inputNumber} в двоичном представлении: {DecToBin(inputNumber)}");


//int numb = ReadData("Введите число: ");
//string numbBin = Convert.ToString(numb, 2);
