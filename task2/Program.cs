// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumSummer(int num)
{
    int sum = 0;
    for (int i = 0; num > 0; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
int InputData(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int num = InputData("Введите число: ");

Console.WriteLine($"Сумма всех цифр равна: {NumSummer(num)}");