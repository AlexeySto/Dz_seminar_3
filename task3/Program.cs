// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

int GetCube(int n)     // Возводим в квадрат
{
    return n * n * n;
}

if (number >= 0)
{
    Console.Write(number + " -> ");
    int count = 1;
    while (count < number)
    {
        Console.Write(GetCube(count) + ", ");
        count++;
    }

    Console.WriteLine(GetCube(number) + ".");
}
else
{
    Console.WriteLine("Введено число меньше 0.");
}
