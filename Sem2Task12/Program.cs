//----------------------------------------------------------------------------------------------------------------------
//                                  Задача 12
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток от деления.
//----------------------------------------------------------------------------------------------------------------------

// Console.Write("Введите число A:");
// string? inputLineA = Console.ReadLine();
// Console.Write("Введите число B:");
// string? inputLineB = Console.ReadLine();

// int A = int.Parse(inputLineA);
// int B = int.Parse(inputLineB);

// bool R = (B % A == 0);

// if (R)
// {
//     Console.WriteLine("Число B кратно A");
// }
// else
// {
//     Console.WriteLine("Не кратно, " + B % A);
// }

int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

ReadData();
ConculateData();
PrintData();

//Получаем два числа от пользователя
void ReadData()
{
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
}

//Определяем кратность чисел
void ConculateData()
{
    result = (inputNumberB % inputNumberA == 0);
}

//Выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
    }
}



//Вариант Евгения
// string? inputLineA = Console.ReadLine();
// string? inputLineB = Console.ReadLine();

// if (inputLineA != null && inputLineB != null)
// {
//     int inputNumberA = (int)int.Parse(inputLineA);
//     int inputNumberB = (int)int.Parse(inputLineB);

//     Console.WriteLine(inputNumberB%inputNumberA==0?"Является кратным":inputNumberB%inputNumberA);
// }

//вариант Константина
// void Variant1()
// {
//     Console.Write("Введите первое число: ");
//     string? inputLineA = Console.ReadLine();
//     Console.Write("Введите второе число: ");
//     string? inputLineB = Console.ReadLine();

//     int inputNumberA = int.Parse(inputLineA);
//     int inputNumberB = int.Parse(inputLineB);

//     Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));
// }
// Variant1();