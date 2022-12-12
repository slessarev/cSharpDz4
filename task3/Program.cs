// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] ArrayFill()
{
    int[] mas = new int[8];
    for (int i = 0; i < 8; i++)
    {
        mas[i] = new Random().Next(0, 1000); // В задаче не указано как задает и каким диапазоном, поэтому пусть будет любое число до 1000
    }
    return mas;
}
void ArrayWrite(int[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length; i++)
    {
        if (i == mas.Length - 1) Console.Write(mas[i]+"]");
        else Console.Write(mas[i] + ", ");
    }
}
ArrayWrite(ArrayFill());