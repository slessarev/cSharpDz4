// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (без использования Math.Pow).

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
int DegreeFunction(int num, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result = result * num;
    }
    return result;
}
int InputData(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

Console.Clear();
int a=InputData("Введите число А: ");
int b = InputData("Введите число B: ");
int result = DegreeFunction(a,b);
Console.WriteLine($"Число {a} в степени {b} равно: {result}");