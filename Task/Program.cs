//task 8

Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.Read());
if (a % 2 == 0)
{Console.WriteLine("Четное, делится без остатка");
}
else
{Console.WriteLine("Нечетное, делится с остатком");
}