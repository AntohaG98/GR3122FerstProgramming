//========================================================================
// # 3 Напишите программу, которая будет
// является ли первое число квадратом второго
//========================================================================
string? inputLine = Console.ReadLine();

if(inputLine != null)
{

    int inputDayofWeek = int.Parse(inputLine);

    string [] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресенье";

if(inputDayofWeek > 7 || inputDayofWeek < 1)
{
    Console.WriteLine("Такого дня нет");
}
    Console.WriteLine(dayOfWeek[inputDayofWeek-1]);
}