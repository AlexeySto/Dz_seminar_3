// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int RungVal(int num, int rung)       // Определяет цифру разряда. num - число, rung номер разряда
{
    num = num % Convert.ToInt32(Math.Pow(10,rung));
    int count =1;
    while (count < rung)
    {
        num = num / 10;
        count++;
    }
    return num;
}

if ( Math.Abs(number) > 9999 && Math.Abs(number) < 100000)
{
    if (RungVal(number,5) == RungVal(number,1) && RungVal(number,4) == RungVal(number,2))
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