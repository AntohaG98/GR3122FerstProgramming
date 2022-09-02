//------------------------------------------------------------------------------
//                                  Задача 14
// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
//------------------------------------------------------------------------------

//Вариант Евгения
// Console.Write("Введите число: ");
// string? inputLineA = Console.ReadLine();
// int inputNumberA = int.Parse(inputLineA);
// if(inputNumberA%7==0 && inputNumberA%23==0)
// {
//     Console.Write("Число кратно одновременно 7 и 23");
// }
// else
// {
//     Console.Write("Число не кратно одновременно 7 и 23");
// }


//Вариант Михаила
// int number, resultA, resultB;
// // запрашивает число у пользователь, в качестве аргумента принимает текст запроса и команду выхода из программы.
// int RequestNumber(string text = "Enter number", string exitCmd = "q")
// {
//     while (true) // код в цикле выполняется пока пользователь не введет целое число или команду выхода из программы
//     {
//         Console.Write(text + ": ");
//         string? inputLine = Console.ReadLine();

//         if (inputLine == null)
//         {
//             continue;
//         }
//         if (inputLine.ToLower() == exitCmd)
//         {
//             Environment.Exit(0);
//         }
//         if (int.TryParse(inputLine, out int number))
//         {
//             return number;
//         }
//     }
// }
// // чтение данных из сонсоли
// void ReadData()
// {
//     number = RequestNumber("Enter number");
// }
// // Определяем кратность чисел
// void CalculateData()
// {
//     resultA = number % 7;
//     resultB = number % 23;
// }
// // Вывод данных
// void PrintData()
// {
//     if (resultA == 0 && resultB == 0)
//     {

//         Console.WriteLine("Число кртно 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine("Число не кртно 7 и 23");
//     }
// }
// ReadData();
// CalculateData();
// PrintData();

//Вариант Анатолия
string? inputLineA = Console.ReadLine();
if (inputLineA != null) Console.Write(((int.Parse(inputLineA) % 7 == 0) && (int.Parse(inputLineA) % 23 == 0)) ? ("Кратно") : ("Не кратно"));
