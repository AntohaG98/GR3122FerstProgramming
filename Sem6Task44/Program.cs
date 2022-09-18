//----------------------------------------------------------
//                      Задача 44
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
//----------------------------------------------------------

// Вариант Анатолия
// Создание словаря.
Dictionary<int, double> fiboDict = new Dictionary<int, double>
{
    { 0, 1 },
    { 1, 1 }
};

// Фибоначи рекурсия.
double FibonachiRec(int numb, Dictionary<int, double> fiboDict)
{
    if (fiboDict.ContainsKey(numb))
        return fiboDict[numb];

    else
    {
        double fiboSum = FibonachiRec(numb - 2, fiboDict) + FibonachiRec(numb - 1, fiboDict);
        fiboDict.Add(numb, fiboSum);
        return fiboSum;
    }
}

// Фибоначи цикл
double FibonachiСycle(int numb)
{
    double fiboPrev = 1;
    double fibo = 1;
    for (int i = 2; i <= numb; i++)
    {
        double tmp = fibo;
        fibo += fiboPrev;
        fiboPrev = tmp;
    }
    return fibo;
}


int fiboNumb = 50;


for (int i = 0; i <= fiboNumb; i++)
{
    Console.WriteLine($"{i} --> {FibonachiRec(i, fiboDict)}");
    Console.WriteLine($"{i} --> {FibonachiСycle(i)}");
}
