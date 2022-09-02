//------------------------------------------------------------------------------------
//                                  Задача 11
// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.
//-----------------------------------------------------------------------------------

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int firstDigit = number/100;
int thirdDigit = number%10;
int outputNumber = firstDigit*10 + thirdDigit;
Console.WriteLine(outputNumber);

//Вариант Евгения
System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(100, 1000);
Console.WriteLine(number);
int firstDigit = number / 100;
int thirdDigit = number % 10;
Console.WriteLine(firstDigit*10+thirdDigit);

//Вариант Михаила
void MyVariant()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);
    char [] charArray = number.ToString().ToCharArray();
    Console.WriteLine("" + charArray[0] + charArray[2]);
}
MyVariant();

//Вариант Константина
void Variant1()
{
    Console.WriteLine("Вариант 1:");
    int number = new Random().Next(100, 1000);
    Console.WriteLine(number);
    char[] charArray = number.ToString().ToCharArray();
    Console.Write(charArray[0]);
    Console.WriteLine(charArray[2]);
}
Variant1();