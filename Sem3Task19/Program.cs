// -------------------------------------------------------------------------------
//                           Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// -------------------------------------------------------------------------------


// Ввод числа для проверки
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Проверка на палиндром
bool CheckPalindrom(int number)
{
    if ((number / 10000 == number % 10) && ((number / 1000) % 10 == (number / 10) % 10)) //Проверка числа на палиндром
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Вывод результатов на экран
void PrintResult(bool answer) 
{
    Console.WriteLine(answer ? "Число является палиндромом!" : "Число не является палиндромом!");
}

int number = ReadData("Введите пятизначное число: ");
PrintResult(CheckPalindrom(number));