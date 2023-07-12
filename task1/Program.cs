// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int RungVal(int num, int rung)       // Определяет цифру разряда. num - число, rung номер разряда
{
    return num = num - num / (10 ** 2);
}

int MinusDel(int n)      // Берем число по модулю
{
    if ( n < 0)
    {
        return n * -1;
    }
    else
    {
        return n;
    }
}

int number1 = MinusDel(number);

if ( number1 > 9999 && number1 < 10000)
{
    if (RungVal(number1,5) == RungVal(number1,1) && RungVal(number1,4) == RungVal(number1,2))
    {
        Console.WriteLine(number + " -> да");
    }
    else
    {
        Console.WriteLine(number + " -> нет");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число.");
}