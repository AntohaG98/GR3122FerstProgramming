// чтение данных из сонсоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

// double Calculate(int X1, int X2, int Y1, int Y2)
// {
//     double Res = Math.Sqrt(Math.Pow((X2-X1)), 2) + Math.Pow((Y2-Y1),2);
//     return Res;
// }

// string QuterBorderAsk(int numQuter)
// {
//     if (numQuter==1)
//         return "x>0 y>0";
//     if (numQuter==2)
//         return "x<0 y>0";
//     if (numQuter==3)
//         return "x<0 y<0";
//     if (numQuter==4)
//         return "x>0 y<0";

//     return "";
// }

void PrintResult(string Res)
{
    Console.WriteLine("Длина отрезка равна " + Res);
}


int X1 = ReadData("Введите первую координату точки X: ");
int X2 = ReadData("Введите вторую координату точки X: ");
int Y1 = ReadData("Введите первую координату точки Y: ");
int Y2 = ReadData("Введите первую координату точки Y: ");


// double res = Calculate(X1, X2, Y1, Y2);

// PrintResult(res);