//===========================================================================
// # 8 Напишите программу, которая принимает на вход число (N),
// а на выходе показывает все четные числа от 1 до N.
//===========================================================================

//Вводим число
Console.Write("Введите число N:");
string? inputLineN = Console.ReadLine();

if (inputLineN != null) //Проверяем, что на входе не пустые данные, и приступаем к выводу четных чисел
{
    int N = int.Parse(inputLineN);
    int B = 1;
    while (B < N)
    {
        if (B % 2 == 0)
        {
            Console.Write(B + ", ");
        }
        B = B + 1;
    }
    Console.Write(N);
}