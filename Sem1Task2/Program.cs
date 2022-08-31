//===========================================================================
// # 2 Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее.
//===========================================================================

//Вводим два числа
Console.Write("Введите число A:");
string? inputLineA = Console.ReadLine();
Console.Write("Введите число B:");
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null) //Проверяем, что на входе не пустые данные, и приступаем к сравнению
{
    int A = int.Parse(inputLineA);
    int B = int.Parse(inputLineB);
    if (A > B)
    {
        Console.WriteLine("Число A > B");
    }
    else
    {
        Console.WriteLine("Число B > A");
    }
}